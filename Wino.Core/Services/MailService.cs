﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.Text;
using MoreLinq;
using Serilog;
using SqlKata;
using Wino.Core.Domain;
using Wino.Core.Domain.Entities;
using Wino.Core.Domain.Enums;
using Wino.Core.Domain.Interfaces;
using Wino.Core.Domain.Models.Comparers;
using Wino.Core.Domain.Models.MailItem;
using Wino.Core.Extensions;
using Wino.Core.Requests;

namespace Wino.Core.Services
{
    public class MailService : BaseDatabaseService, IMailService
    {
        private const int ItemLoadCount = 20;

        private readonly IFolderService _folderService;
        private readonly IContactService _contactService;
        private readonly IAccountService _accountService;
        private readonly ISignatureService _signatureService;
        private readonly IThreadingStrategyProvider _threadingStrategyProvider;
        private readonly IMimeFileService _mimeFileService;


        private readonly ILogger _logger = Log.ForContext<MailService>();

        public MailService(IDatabaseService databaseService,
                           IFolderService folderService,
                           IContactService contactService,
                           IAccountService accountService,
                           ISignatureService signatureService,
                           IThreadingStrategyProvider threadingStrategyProvider,
                           IMimeFileService mimeFileService) : base(databaseService)
        {
            _folderService = folderService;
            _contactService = contactService;
            _accountService = accountService;
            _signatureService = signatureService;
            _threadingStrategyProvider = threadingStrategyProvider;
            _mimeFileService = mimeFileService;
        }

        public async Task<MailCopy> CreateDraftAsync(MailAccount composerAccount,
            MimeMessage createdDraftMimeMessage,
            MimeMessage replyingMimeMessage = null,
            IMailItem replyingMailItem = null)
        {
            bool isImapAccount = composerAccount.ServerInformation != null;

            string fromName;

            if (isImapAccount)
                fromName = composerAccount.ServerInformation.DisplayName;
            else
            {
                var composerContact = await _contactService.GetAddressInformationByAddressAsync(composerAccount.Address);

                fromName = composerContact?.Name ?? composerAccount.Address;
            }

            var draftFolder = await _folderService.GetSpecialFolderByAccountIdAsync(composerAccount.Id, SpecialFolderType.Draft);

            // Get locally created unique id from the mime headers.
            // This header will be used to map the local draft copy with the remote draft copy.
            var mimeUniqueId = createdDraftMimeMessage.Headers[Constants.WinoLocalDraftHeader];

            var copy = new MailCopy
            {
                UniqueId = Guid.Parse(mimeUniqueId),
                Id = Guid.NewGuid().ToString(), // This will be replaced after network call with the remote draft id.
                CreationDate = DateTime.UtcNow,
                FromAddress = composerAccount.Address,
                FromName = fromName,
                HasAttachments = false,
                Importance = MailImportance.Normal,
                Subject = createdDraftMimeMessage.Subject,
                PreviewText = createdDraftMimeMessage.TextBody,
                IsRead = true,
                IsDraft = true,
                FolderId = draftFolder.Id,
                DraftId = $"{Constants.LocalDraftStartPrefix}{Guid.NewGuid()}",
                AssignedFolder = draftFolder,
                AssignedAccount = composerAccount,
                FileId = Guid.NewGuid()
            };

            // If replying, add In-Reply-To, ThreadId and References.
            bool isReplying = replyingMimeMessage != null;

            if (isReplying)
            {
                if (replyingMimeMessage.References != null)
                    copy.References = string.Join(",", replyingMimeMessage.References);

                if (!string.IsNullOrEmpty(replyingMimeMessage.MessageId))
                    copy.InReplyTo = replyingMimeMessage.MessageId;

                if (!string.IsNullOrEmpty(replyingMailItem?.ThreadId))
                    copy.ThreadId = replyingMailItem.ThreadId;
            }

            await Connection.InsertAsync(copy);


            await _mimeFileService.SaveMimeMessageAsync(copy.FileId, createdDraftMimeMessage, composerAccount.Id);

            ReportUIChange(new DraftCreated(copy, composerAccount));

            return copy;
        }

        public Task<List<string>> GetMailIdsByFolderIdAsync(Guid folderId)
            => Connection.QueryScalarsAsync<string>("SELECT Id FROM MailCopy WHERE FolderId = ?", folderId);


        private string BuildMailFetchQuery(MailListInitializationOptions options)
        {
            // If the search query is there, we should ignore some properties and trim it.
            //if (!string.IsNullOrEmpty(options.SearchQuery))
            //{
            //    options.IsFocusedOnly = null;
            //    filterType = FilterOptionType.All;

            //    searchQuery = searchQuery.Trim();
            //}

            // SQLite PCL doesn't support joins.
            // We make the query using SqlKatka and execute it directly on SQLite-PCL.

            var query = new Query("MailCopy")
                        .Join("MailItemFolder", "MailCopy.FolderId", "MailItemFolder.Id")
                        .WhereIn("MailCopy.FolderId", options.Folders.Select(a => a.Id))
                        .Take(ItemLoadCount)
                        .SelectRaw("MailCopy.*");

            if (options.SortingOptionType == SortingOptionType.ReceiveDate)
                query.OrderByDesc("CreationDate");
            else if (options.SortingOptionType == SortingOptionType.Sender)
                query.OrderBy("FromName");

            // Conditional where.
            switch (options.FilterType)
            {
                case FilterOptionType.Unread:
                    query.Where("MailCopy.IsRead", false);
                    break;
                case FilterOptionType.Flagged:
                    query.Where("MailCopy.IsFlagged", true);
                    break;
            }

            if (options.IsFocusedOnly != null)
                query.Where("MailCopy.IsFocused", options.IsFocusedOnly.Value);

            if (!string.IsNullOrEmpty(options.SearchQuery))
                query.Where(a =>
                            a.OrWhereContains("MailCopy.PreviewText", options.SearchQuery)
                            .OrWhereContains("MailCopy.Subject", options.SearchQuery)
                            .OrWhereContains("MailCopy.FromName", options.SearchQuery)
                            .OrWhereContains("MailCopy.FromAddress", options.SearchQuery));

            if (options.ExistingUniqueIds?.Any() ?? false)
            {
                query.WhereNotIn("MailCopy.UniqueId", options.ExistingUniqueIds);
            }

            //if (options.Skip > 0)
            //{
            //    query.Skip(options.Skip);
            //}

            return query.GetRawQuery();
        }

        public async Task<List<IMailItem>> FetchMailsAsync(MailListInitializationOptions options)
        {
            var query = BuildMailFetchQuery(options);

            var mails = await Connection.QueryAsync<MailCopy>(query);

            // Fill in assigned account and folder for each mail.
            // To speed things up a bit, we'll load account and assigned folder in groups
            // to reduce the query time.

            var groupedByFolders = mails.GroupBy(a => a.FolderId);

            foreach (var group in groupedByFolders)
            {
                MailItemFolder folderAssignment = null;
                MailAccount accountAssignment = null;

                folderAssignment = await _folderService.GetFolderAsync(group.Key).ConfigureAwait(false);

                if (folderAssignment != null)
                {
                    accountAssignment = await _accountService.GetAccountAsync(folderAssignment.MailAccountId).ConfigureAwait(false);
                }

                group.ForEach(a =>
                {
                    a.AssignedFolder = folderAssignment;
                    a.AssignedAccount = accountAssignment;
                });
            }

            // Remove items that has no assigned account or folder.
            mails.RemoveAll(a => a.AssignedAccount == null || a.AssignedFolder == null);

            // Each account items must be threaded separately.

            if (options.CreateThreads)
            {
                var threadedItems = new List<IMailItem>();

                var groupedByAccounts = mails.GroupBy(a => a.AssignedAccount.Id);

                foreach (var group in groupedByAccounts)
                {
                    if (!group.Any()) continue;

                    var accountId = group.Key;
                    var groupAccount = mails.First(a => a.AssignedAccount.Id == accountId).AssignedAccount;

                    var threadingStrategy = _threadingStrategyProvider.GetStrategy(groupAccount.ProviderType);

                    // Only thread items from Draft and Sent folders must present here.
                    // Otherwise this strategy will fetch the items that are in Deleted folder as well.
                    var accountThreadedItems = await threadingStrategy.ThreadItemsAsync(group.ToList());

                    if (accountThreadedItems != null)
                    {
                        threadedItems.AddRange(accountThreadedItems);
                    }
                }

                threadedItems.Sort(options.SortingOptionType == SortingOptionType.ReceiveDate ? new DateComparer() : new NameComparer());

                return threadedItems;
            }
            else
            {
                // Threading is disabled. Just return everything as it is.

                mails.Sort(options.SortingOptionType == SortingOptionType.ReceiveDate ? new DateComparer() : new NameComparer());

                return new List<IMailItem>(mails);
            }
        }

        private async Task<List<MailCopy>> GetMailItemsAsync(string mailCopyId)
        {
            var mailCopies = await Connection.Table<MailCopy>().Where(a => a.Id == mailCopyId).ToListAsync();

            foreach (var mailCopy in mailCopies)
            {
                await LoadAssignedPropertiesAsync(mailCopy).ConfigureAwait(false);
            }

            return mailCopies;
        }

        private async Task LoadAssignedPropertiesAsync(MailCopy mailCopy)
        {
            if (mailCopy == null) return;

            // Load AssignedAccount and AssignedFolder.

            var folder = await _folderService.GetFolderAsync(mailCopy.FolderId);

            if (folder == null) return;

            var account = await _accountService.GetAccountAsync(folder.MailAccountId);

            if (account == null) return;

            mailCopy.AssignedAccount = account;
            mailCopy.AssignedFolder = folder;
        }

        public async Task<MailCopy> GetSingleMailItemWithoutFolderAssignmentAsync(string mailCopyId)
        {
            var mailCopy = await Connection.Table<MailCopy>().FirstOrDefaultAsync(a => a.Id == mailCopyId);

            if (mailCopy == null) return null;

            await LoadAssignedPropertiesAsync(mailCopy).ConfigureAwait(false);

            return mailCopy;
        }

        public async Task<MailCopy> GetSingleMailItemAsync(string mailCopyId, string remoteFolderId)
        {
            var query = new Query("MailCopy")
                            .Join("MailItemFolder", "MailCopy.FolderId", "MailItemFolder.Id")
                            .Where("MailCopy.Id", mailCopyId)
                            .Where("MailItemFolder.RemoteFolderId", remoteFolderId)
                            .SelectRaw("MailCopy.*")
                            .GetRawQuery();

            var mailItem = await Connection.FindWithQueryAsync<MailCopy>(query);

            if (mailItem == null) return null;

            await LoadAssignedPropertiesAsync(mailItem).ConfigureAwait(false);

            return mailItem;
        }

        public async Task<MailCopy> GetSingleMailItemAsync(Guid uniqueMailId)
        {
            var mailItem = await Connection.FindAsync<MailCopy>(uniqueMailId);

            if (mailItem == null) return null;

            await LoadAssignedPropertiesAsync(mailItem).ConfigureAwait(false);

            return mailItem;
        }

        // v2

        public async Task DeleteMailAsync(Guid accountId, string mailCopyId)
        {
            var allMails = await GetMailItemsAsync(mailCopyId).ConfigureAwait(false);

            foreach (var mailItem in allMails)
            {
                await DeleteMailInternalAsync(mailItem).ConfigureAwait(false);

                // Delete mime file.
                // Even though Gmail might have multiple copies for the same mail, we only have one MIME file for all.
                // Their FileId is inserted same.
                await _mimeFileService.DeleteMimeMessageAsync(accountId, mailItem.FileId);
            }
        }

        #region Repository Calls

        private async Task InsertMailAsync(MailCopy mailCopy)
        {
            if (mailCopy == null)
            {
                _logger.Warning("Null mail passed to InsertMailAsync call.");
                return;
            }

            if (mailCopy.FolderId == Guid.Empty)
            {
                _logger.Warning("Invalid FolderId for MailCopyId {Id} for InsertMailAsync", mailCopy.Id);
                return;
            }

            _logger.Debug("Inserting mail {MailCopyId} to Folder {FolderId}", mailCopy.Id, mailCopy.FolderId);

            await Connection.InsertAsync(mailCopy).ConfigureAwait(false);

            ReportUIChange(new MailAddedMessage(mailCopy));
        }

        public async Task UpdateMailAsync(MailCopy mailCopy)
        {
            if (mailCopy == null)
            {
                _logger.Warning("Null mail passed to UpdateMailAsync call.");

                return;
            }

            _logger.Debug("Updating mail {MailCopyId} with Folder {FolderId}", mailCopy.Id, mailCopy.FolderId);

            await Connection.UpdateAsync(mailCopy).ConfigureAwait(false);

            ReportUIChange(new MailUpdatedMessage(mailCopy));
        }

        private async Task DeleteMailInternalAsync(MailCopy mailCopy)
        {
            if (mailCopy == null)
            {
                _logger.Warning("Null mail passed to DeleteMailAsync call.");

                return;
            }

            _logger.Debug("Deleting mail {Id} with Folder {FolderId}", mailCopy.Id, mailCopy.FolderId);

            await Connection.DeleteAsync(mailCopy).ConfigureAwait(false);

            ReportUIChange(new MailRemovedMessage(mailCopy));
        }

        #endregion

        private async Task UpdateAllMailCopiesAsync(string mailCopyId, Func<MailCopy, bool> action)
        {
            var mailCopies = await GetMailItemsAsync(mailCopyId);

            if (mailCopies == null || !mailCopies.Any())
            {
                _logger.Warning("Updating mail copies failed because there are no copies available with Id {MailCopyId}", mailCopyId);

                return;
            }

            _logger.Information("Updating {MailCopyCount} mail copies with Id {MailCopyId}", mailCopies.Count, mailCopyId);

            foreach (var mailCopy in mailCopies)
            {
                bool shouldUpdateItem = action(mailCopy);

                if (shouldUpdateItem)
                {
                    await UpdateMailAsync(mailCopy).ConfigureAwait(false);
                }
                else
                    _logger.Information("Skipped updating mail because it is already in the desired state.");
            }
        }

        public Task ChangeReadStatusAsync(string mailCopyId, bool isRead)
            => UpdateAllMailCopiesAsync(mailCopyId, (item) =>
            {
                item.IsRead = isRead;

                return true;
            });

        public Task ChangeFlagStatusAsync(string mailCopyId, bool isFlagged)
            => UpdateAllMailCopiesAsync(mailCopyId, (item) =>
            {
                item.IsFlagged = isFlagged;

                return true;
            });

        public async Task CreateAssignmentAsync(Guid accountId, string mailCopyId, string remoteFolderId)
        {
            // Note: Folder might not be available at the moment due to user not syncing folders before the delta processing.
            // This is a problem, because assignments won't be created.
            // Therefore we sync folders every time before the delta processing.

            var localFolder = await _folderService.GetFolderAsync(accountId, remoteFolderId);

            if (localFolder == null)
            {
                _logger.Warning("Local folder not found for remote folder {RemoteFolderId}", remoteFolderId);
                _logger.Warning("Skipping assignment creation for the the message {MailCopyId}", mailCopyId);

                return;
            }

            var mailCopy = await GetSingleMailItemWithoutFolderAssignmentAsync(mailCopyId);

            if (mailCopy == null)
            {
                _logger.Warning("Can't create assignment for mail {MailCopyId} because it does not exist.", mailCopyId);

                return;
            }

            // Copy one of the mail copy and assign it to the new folder.
            // We don't need to create a new MIME pack.
            // Therefore FileId is not changed for the new MailCopy.

            mailCopy.UniqueId = Guid.NewGuid();
            mailCopy.FolderId = localFolder.Id;
            mailCopy.AssignedFolder = localFolder;

            await InsertMailAsync(mailCopy).ConfigureAwait(false);
        }

        public async Task DeleteAssignmentAsync(Guid accountId, string mailCopyId, string remoteFolderId)
        {
            var mailItem = await GetSingleMailItemAsync(mailCopyId, remoteFolderId).ConfigureAwait(false);

            if (mailItem == null)
            {
                _logger.Warning("Mail not found with id {MailCopyId} with remote folder {RemoteFolderId}", mailCopyId, remoteFolderId);

                return;
            }

            var localFolder = await _folderService.GetFolderAsync(accountId, remoteFolderId);

            if (localFolder == null)
            {
                _logger.Warning("Local folder not found for remote folder {RemoteFolderId}", remoteFolderId);

                return;
            }

            await DeleteMailInternalAsync(mailItem).ConfigureAwait(false);
        }

        public async Task<bool> CreateMailAsync(Guid accountId, NewMailItemPackage package)
        {
            var account = await _accountService.GetAccountAsync(accountId).ConfigureAwait(false);

            if (account == null) return false;

            if (string.IsNullOrEmpty(package.AssignedRemoteFolderId))
            {
                _logger.Warning("Remote folder id is not set for {MailCopyId}.", package.Copy.Id);
                _logger.Warning("Ignoring creation of mail.");

                return false;
            }

            var assignedFolder = await _folderService.GetFolderAsync(accountId, package.AssignedRemoteFolderId).ConfigureAwait(false);

            if (assignedFolder == null)
            {
                _logger.Warning("Assigned folder not found for {MailCopyId}.", package.Copy.Id);
                _logger.Warning("Ignoring creation of mail.");

                return false;
            }

            var mailCopy = package.Copy;
            var mimeMessage = package.Mime;

            mailCopy.UniqueId = Guid.NewGuid();
            mailCopy.AssignedAccount = account;
            mailCopy.AssignedFolder = assignedFolder;
            mailCopy.FolderId = assignedFolder.Id;

            // Only save MIME files if they don't exists.
            // This is because 1 mail may have multiple copies in different folders.
            // but only single MIME to represent all.

            // Save mime file to disk.
            var isMimeExists = await _mimeFileService.IsMimeExistAsync(accountId, mailCopy.FileId);

            if (!isMimeExists)
            {
                bool isMimeSaved = await _mimeFileService.SaveMimeMessageAsync(mailCopy.FileId, mimeMessage, accountId).ConfigureAwait(false);

                if (!isMimeSaved)
                {
                    _logger.Warning("Failed to save mime file for {MailCopyId}.", mailCopy.Id);
                }
            }

            // Save contact information.
            await _contactService.SaveAddressInformationAsync(mimeMessage).ConfigureAwait(false);

            // Create mail copy in the database.
            // Update if exists.

            var existingCopyItem = await Connection.Table<MailCopy>()
                                                    .FirstOrDefaultAsync(a => a.Id == mailCopy.Id && a.FolderId == assignedFolder.Id);

            if (existingCopyItem != null)
            {
                mailCopy.UniqueId = existingCopyItem.UniqueId;

                await UpdateMailAsync(mailCopy).ConfigureAwait(false);

                return false;
            }
            else
            {
                await InsertMailAsync(mailCopy).ConfigureAwait(false);

                return true;
            }
        }

        public async Task<MimeMessage> CreateDraftMimeMessageAsync(Guid accountId, DraftCreationOptions draftCreationOptions)
        {
            // This unique id is stored in mime headers for Wino to identify remote message with local copy.
            // Same unique id will be used for the local copy as well.
            // Synchronizer will map this unique id to the local draft copy after synchronization.

            var messageUniqueId = Guid.NewGuid();

            var message = new MimeMessage()
            {
                Headers = { { Constants.WinoLocalDraftHeader, messageUniqueId.ToString() } }
            };

            var builder = new BodyBuilder();

            var account = await _accountService.GetAccountAsync(accountId).ConfigureAwait(false);

            if (account == null)
            {
                _logger.Warning("Can't create draft mime message because account {AccountId} does not exist.", accountId);

                return null;
            }

            var reason = draftCreationOptions.Reason;
            var referenceMessage = draftCreationOptions.ReferenceMimeMessage;

            // For API synchronizers we should get this from contacts.
            if (account.ServerInformation == null)
            {
                var fromContact = await _contactService.GetAddressInformationByAddressAsync(account.Address).ConfigureAwait(false)
                ?? new AddressInformation() { Name = account.Address, Address = account.Address };

                message.From.Add(new MailboxAddress(fromContact.Name, fromContact.Address));
            }
            else
            {
                // For IMAP synchronizer, we have already Display Name in the settings.
                message.From.Add(new MailboxAddress(account.ServerInformation.DisplayName, account.ServerInformation.Address));
            }

            // Manage "To"
            if (reason == DraftCreationReason.Reply || reason == DraftCreationReason.ReplyAll)
            {
                // Reply to the sender of the message

                if (referenceMessage.ReplyTo.Count > 0)
                    message.To.AddRange(referenceMessage.ReplyTo);
                else if (referenceMessage.From.Count > 0)
                    message.To.AddRange(referenceMessage.From);
                else if (referenceMessage.Sender != null)
                    message.To.Add(referenceMessage.Sender);

                if (reason == DraftCreationReason.ReplyAll)
                {
                    // Include all of the other original recipients
                    message.To.AddRange(referenceMessage.To);

                    // Find self and remove
                    var self = message.To.FirstOrDefault(a => a is MailboxAddress mailboxAddress && mailboxAddress.Address == account.Address);

                    if (self != null)
                        message.To.Remove(self);

                    message.Cc.AddRange(referenceMessage.Cc);
                }

                // Manage "ThreadId-ConversationId"
                if (!string.IsNullOrEmpty(referenceMessage.MessageId))
                {
                    message.InReplyTo = referenceMessage.MessageId;

                    foreach (var id in referenceMessage.References)
                        message.References.Add(id);

                    message.References.Add(referenceMessage.MessageId);
                }

                message.Headers.Add("Thread-Topic", referenceMessage.Subject);
            }

            var previewer = new HtmlTextPreviewer();

            if (reason == DraftCreationReason.Forward)
            {
                var visitor = _mimeFileService.CreateHTMLPreviewVisitor(referenceMessage, string.Empty);
                visitor.Visit(referenceMessage);

                builder.HtmlBody = visitor.HtmlBody;
            }
            else
            {
                // Add signature if any.
                var accountSignature = await _signatureService.GetAccountSignatureAsync(account.Id);

                if (accountSignature != null)
                {
                    // Leave some space for new mail content.

                    builder.HtmlBody = @$"<html><br><br>{accountSignature.HtmlBody}</html>";
                }
            }

            // Manage Subject
            if (reason == DraftCreationReason.Forward && !referenceMessage.Subject.StartsWith("FW: ", StringComparison.OrdinalIgnoreCase))
                message.Subject = $"FW: {referenceMessage.Subject}";
            else if ((reason == DraftCreationReason.Reply || reason == DraftCreationReason.ReplyAll) &&
                !referenceMessage.Subject.StartsWith("RE: ", StringComparison.OrdinalIgnoreCase))
                message.Subject = $"RE: {referenceMessage.Subject}";
            else if (referenceMessage != null)
                message.Subject = referenceMessage.Subject;

            // Only include attachments if forwarding.
            if (reason == DraftCreationReason.Forward && (referenceMessage?.Attachments?.Any() ?? false))
            {
                foreach (var attachment in referenceMessage.Attachments)
                {
                    builder.Attachments.Add(attachment);
                }
            }

            if (!string.IsNullOrEmpty(builder.HtmlBody))
            {
                builder.TextBody = HtmlAgilityPackExtensions.GetPreviewText(builder.HtmlBody);
            }

            message.Body = builder.ToMessageBody();

            // Apply mail-to protocol parameters if exists.

            if (draftCreationOptions.MailtoParameters != null)
            {
                if (draftCreationOptions.TryGetMailtoValue(DraftCreationOptions.MailtoSubjectParameterKey, out string subjectParameter))
                    message.Subject = subjectParameter;

                if (draftCreationOptions.TryGetMailtoValue(DraftCreationOptions.MailtoBodyParameterKey, out string bodyParameter))
                {
                    builder.TextBody = bodyParameter;
                    builder.HtmlBody = bodyParameter;

                    message.Body = builder.ToMessageBody();
                }

                InternetAddressList ExtractRecipients(string parameterValue)
                {
                    var list = new InternetAddressList();

                    var splittedRecipients = parameterValue.Split(',');

                    foreach (var recipient in splittedRecipients)
                        list.Add(new MailboxAddress(recipient, recipient));

                    return list;

                }

                if (draftCreationOptions.TryGetMailtoValue(DraftCreationOptions.MailtoToParameterKey, out string toParameter))
                    message.To.AddRange(ExtractRecipients(toParameter));

                if (draftCreationOptions.TryGetMailtoValue(DraftCreationOptions.MailtoCCParameterKey, out string ccParameter))
                    message.Cc.AddRange(ExtractRecipients(ccParameter));

                if (draftCreationOptions.TryGetMailtoValue(DraftCreationOptions.MailtoBCCParameterKey, out string bccParameter))
                    message.Bcc.AddRange(ExtractRecipients(bccParameter));
            }
            else
            {
                // Update TextBody from existing HtmlBody if exists.
            }

            return message;
        }

        public async Task<bool> MapLocalDraftAsync(Guid accountId, Guid localDraftCopyUniqueId, string newMailCopyId, string newDraftId, string newThreadId)
        {
            var query = new Query("MailCopy")
                            .Join("MailItemFolder", "MailCopy.FolderId", "MailItemFolder.Id")
                            .Where("MailCopy.UniqueId", localDraftCopyUniqueId)
                            .Where("MailItemFolder.MailAccountId", accountId)
                            .SelectRaw("MailCopy.*")
                            .GetRawQuery();

            var localDraftCopy = await Connection.FindWithQueryAsync<MailCopy>(query);

            if (localDraftCopy == null)
            {
                _logger.Warning("Draft mapping failed because local draft copy with unique id {LocalDraftCopyUniqueId} does not exist.", localDraftCopyUniqueId);

                return false;
            }

            var oldLocalDraftId = localDraftCopy.Id;

            await LoadAssignedPropertiesAsync(localDraftCopy).ConfigureAwait(false);

            bool isIdChanging = localDraftCopy.Id != newMailCopyId;

            localDraftCopy.Id = newMailCopyId;
            localDraftCopy.DraftId = newDraftId;
            localDraftCopy.ThreadId = newThreadId;

            await UpdateMailAsync(localDraftCopy).ConfigureAwait(false);

            ReportUIChange(new DraftMapped(oldLocalDraftId, newDraftId));

            return true;
        }

        public Task MapLocalDraftAsync(string mailCopyId, string newDraftId, string newThreadId)
        {
            return UpdateAllMailCopiesAsync(mailCopyId, (item) =>
            {
                if (item.ThreadId != newThreadId || item.DraftId != newDraftId)
                {
                    var oldDraftId = item.DraftId;

                    item.DraftId = newDraftId;
                    item.ThreadId = newThreadId;

                    ReportUIChange(new DraftMapped(oldDraftId, newDraftId));

                    return true;
                }

                return false;
            });
        }

        public Task<List<MailCopy>> GetDownloadedUnreadMailsAsync(Guid accountId, IEnumerable<string> downloadedMailCopyIds)
        {
            var rawQuery = new Query("MailCopy")
                            .Join("MailItemFolder", "MailCopy.FolderId", "MailItemFolder.Id")
                            .WhereIn("MailCopy.Id", downloadedMailCopyIds)
                            .Where("MailCopy.IsRead", false)
                            .Where("MailItemFolder.MailAccountId", accountId)
                            .Where("MailItemFolder.SpecialFolderType", SpecialFolderType.Inbox)
                            .SelectRaw("MailCopy.*")
                            .GetRawQuery();

            return Connection.QueryAsync<MailCopy>(rawQuery);
        }

        public Task<MailAccount> GetMailAccountByUniqueIdAsync(Guid uniqueMailId)
        {
            var query = new Query("MailCopy")
                            .Join("MailItemFolder", "MailCopy.FolderId", "MailItemFolder.Id")
                            .Join("MailAccount", "MailItemFolder.MailAccountId", "MailAccount.Id")
                            .Where("MailCopy.UniqueId", uniqueMailId)
                            .SelectRaw("MailAccount.*")
                            .GetRawQuery();

            return Connection.FindWithQueryAsync<MailAccount>(query);
        }


    }
}
