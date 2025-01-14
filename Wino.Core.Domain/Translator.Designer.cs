﻿
namespace Wino.Core.Domain
{
	public class Translator
	{
		private static global::Wino.Core.Domain.Translations.WinoTranslationDictionary _dictionary;

		public static global::Wino.Core.Domain.Translations.WinoTranslationDictionary Resources
		{
			get
			{
				if (_dictionary == null)
				{
					_dictionary = new global::Wino.Core.Domain.Translations.WinoTranslationDictionary();
				}

				return _dictionary;
			}
		}
	
        /// <summary>
		/// all done
		/// </summary>
		public static string AccountCreationDialog_Completed => Resources.GetTranslatedString(@"AccountCreationDialog_Completed");	
	
        /// <summary>
		/// initializing
		/// </summary>
		public static string AccountCreationDialog_Initializing => Resources.GetTranslatedString(@"AccountCreationDialog_Initializing");	
	
        /// <summary>
		/// We are getting folder information at the moment.
		/// </summary>
		public static string AccountCreationDialog_PreparingFolders => Resources.GetTranslatedString(@"AccountCreationDialog_PreparingFolders");	
	
        /// <summary>
		/// Account information is being saved.
		/// </summary>
		public static string AccountCreationDialog_SigninIn => Resources.GetTranslatedString(@"AccountCreationDialog_SigninIn");	
	
        /// <summary>
		/// Account Name
		/// </summary>
		public static string AccountEditDialog_Message => Resources.GetTranslatedString(@"AccountEditDialog_Message");	
	
        /// <summary>
		/// Edit Account
		/// </summary>
		public static string AccountEditDialog_Title => Resources.GetTranslatedString(@"AccountEditDialog_Title");	
	
        /// <summary>
		/// Pick an account
		/// </summary>
		public static string AccountPickerDialog_Title => Resources.GetTranslatedString(@"AccountPickerDialog_Title");	
	
        /// <summary>
		/// Add
		/// </summary>
		public static string AddHyperlink => Resources.GetTranslatedString(@"AddHyperlink");	
	
        /// <summary>
		/// Searching for mail settings...
		/// </summary>
		public static string AutoDiscoveryProgressMessage => Resources.GetTranslatedString(@"AutoDiscoveryProgressMessage");	
	
        /// <summary>
		/// Advanced Configuration
		/// </summary>
		public static string BasicIMAPSetupDialog_AdvancedConfiguration => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_AdvancedConfiguration");	
	
        /// <summary>
		/// Your credentials will only be stored locally on your computer.
		/// </summary>
		public static string BasicIMAPSetupDialog_CredentialLocalMessage => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_CredentialLocalMessage");	
	
        /// <summary>
		/// Some accounts require additional steps to sign in
		/// </summary>
		public static string BasicIMAPSetupDialog_Description => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_Description");	
	
        /// <summary>
		/// Display Name
		/// </summary>
		public static string BasicIMAPSetupDialog_DisplayName => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_DisplayName");	
	
        /// <summary>
		/// eg. John Doe
		/// </summary>
		public static string BasicIMAPSetupDialog_DisplayNamePlaceholder => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_DisplayNamePlaceholder");	
	
        /// <summary>
		/// Learn more
		/// </summary>
		public static string BasicIMAPSetupDialog_LearnMore => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_LearnMore");	
	
        /// <summary>
		/// E-Mail Address
		/// </summary>
		public static string BasicIMAPSetupDialog_MailAddress => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_MailAddress");	
	
        /// <summary>
		/// johndoe@fabrikam.com
		/// </summary>
		public static string BasicIMAPSetupDialog_MailAddressPlaceholder => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_MailAddressPlaceholder");	
	
        /// <summary>
		/// Password
		/// </summary>
		public static string BasicIMAPSetupDialog_Password => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_Password");	
	
        /// <summary>
		/// IMAP Account
		/// </summary>
		public static string BasicIMAPSetupDialog_Title => Resources.GetTranslatedString(@"BasicIMAPSetupDialog_Title");	
	
        /// <summary>
		/// Add Account
		/// </summary>
		public static string Buttons_AddAccount => Resources.GetTranslatedString(@"Buttons_AddAccount");	
	
        /// <summary>
		/// Apply Theme
		/// </summary>
		public static string Buttons_ApplyTheme => Resources.GetTranslatedString(@"Buttons_ApplyTheme");	
	
        /// <summary>
		/// Browse
		/// </summary>
		public static string Buttons_Browse => Resources.GetTranslatedString(@"Buttons_Browse");	
	
        /// <summary>
		/// Cancel
		/// </summary>
		public static string Buttons_Cancel => Resources.GetTranslatedString(@"Buttons_Cancel");	
	
        /// <summary>
		/// Close
		/// </summary>
		public static string Buttons_Close => Resources.GetTranslatedString(@"Buttons_Close");	
	
        /// <summary>
		/// Create
		/// </summary>
		public static string Buttons_Create => Resources.GetTranslatedString(@"Buttons_Create");	
	
        /// <summary>
		/// Create Account
		/// </summary>
		public static string Buttons_CreateAccount => Resources.GetTranslatedString(@"Buttons_CreateAccount");	
	
        /// <summary>
		/// Delete
		/// </summary>
		public static string Buttons_Delete => Resources.GetTranslatedString(@"Buttons_Delete");	
	
        /// <summary>
		/// Discard
		/// </summary>
		public static string Buttons_Discard => Resources.GetTranslatedString(@"Buttons_Discard");	
	
        /// <summary>
		/// Enable
		/// </summary>
		public static string Buttons_EnableImageRendering => Resources.GetTranslatedString(@"Buttons_EnableImageRendering");	
	
        /// <summary>
		/// No
		/// </summary>
		public static string Buttons_No => Resources.GetTranslatedString(@"Buttons_No");	
	
        /// <summary>
		/// Open
		/// </summary>
		public static string Buttons_Open => Resources.GetTranslatedString(@"Buttons_Open");	
	
        /// <summary>
		/// Purchase
		/// </summary>
		public static string Buttons_Purchase => Resources.GetTranslatedString(@"Buttons_Purchase");	
	
        /// <summary>
		/// Rate Wino
		/// </summary>
		public static string Buttons_RateWino => Resources.GetTranslatedString(@"Buttons_RateWino");	
	
        /// <summary>
		/// Save
		/// </summary>
		public static string Buttons_Save => Resources.GetTranslatedString(@"Buttons_Save");	
	
        /// <summary>
		/// Save Configuration
		/// </summary>
		public static string Buttons_SaveConfiguration => Resources.GetTranslatedString(@"Buttons_SaveConfiguration");	
	
        /// <summary>
		/// Share
		/// </summary>
		public static string Buttons_Share => Resources.GetTranslatedString(@"Buttons_Share");	
	
        /// <summary>
		/// Sign In
		/// </summary>
		public static string Buttons_SignIn => Resources.GetTranslatedString(@"Buttons_SignIn");	
	
        /// <summary>
		/// Yes
		/// </summary>
		public static string Buttons_Yes => Resources.GetTranslatedString(@"Buttons_Yes");	
	
        /// <summary>
		/// Center
		/// </summary>
		public static string Center => Resources.GetTranslatedString(@"Center");	
	
        /// <summary>
		/// Coming soon...
		/// </summary>
		public static string ComingSoon => Resources.GetTranslatedString(@"ComingSoon");	
	
        /// <summary>
		/// From: 
		/// </summary>
		public static string ComposerFrom => Resources.GetTranslatedString(@"ComposerFrom");	
	
        /// <summary>
		/// Subject: 
		/// </summary>
		public static string ComposerSubject => Resources.GetTranslatedString(@"ComposerSubject");	
	
        /// <summary>
		/// To: 
		/// </summary>
		public static string ComposerTo => Resources.GetTranslatedString(@"ComposerTo");	
	
        /// <summary>
		/// {0} copied to clipboard.
		/// </summary>
		public static string ClipboardTextCopied_Message => Resources.GetTranslatedString(@"ClipboardTextCopied_Message");	
	
        /// <summary>
		/// Copied
		/// </summary>
		public static string ClipboardTextCopied_Title => Resources.GetTranslatedString(@"ClipboardTextCopied_Title");	
	
        /// <summary>
		/// Failed to copy {0} to clipboard.
		/// </summary>
		public static string ClipboardTextCopyFailed_Message => Resources.GetTranslatedString(@"ClipboardTextCopyFailed_Message");	
	
        /// <summary>
		/// click enter to input addresses
		/// </summary>
		public static string ComposerToPlaceholder => Resources.GetTranslatedString(@"ComposerToPlaceholder");	
	
        /// <summary>
		/// Set custom accent color if you wish. Not selecting a color will use your Windows accent color.
		/// </summary>
		public static string CustomThemeBuilder_AccentColorDescription => Resources.GetTranslatedString(@"CustomThemeBuilder_AccentColorDescription");	
	
        /// <summary>
		/// Accent color
		/// </summary>
		public static string CustomThemeBuilder_AccentColorTitle => Resources.GetTranslatedString(@"CustomThemeBuilder_AccentColorTitle");	
	
        /// <summary>
		/// Pick
		/// </summary>
		public static string CustomThemeBuilder_PickColor => Resources.GetTranslatedString(@"CustomThemeBuilder_PickColor");	
	
        /// <summary>
		/// Unique name for your custom theme.
		/// </summary>
		public static string CustomThemeBuilder_ThemeNameDescription => Resources.GetTranslatedString(@"CustomThemeBuilder_ThemeNameDescription");	
	
        /// <summary>
		/// Theme name
		/// </summary>
		public static string CustomThemeBuilder_ThemeNameTitle => Resources.GetTranslatedString(@"CustomThemeBuilder_ThemeNameTitle");	
	
        /// <summary>
		/// Custom Theme Builder
		/// </summary>
		public static string CustomThemeBuilder_Title => Resources.GetTranslatedString(@"CustomThemeBuilder_Title");	
	
        /// <summary>
		/// Set a custom wallpaper for Wino
		/// </summary>
		public static string CustomThemeBuilder_WallpaperDescription => Resources.GetTranslatedString(@"CustomThemeBuilder_WallpaperDescription");	
	
        /// <summary>
		/// Set custom wallpaper
		/// </summary>
		public static string CustomThemeBuilder_WallpaperTitle => Resources.GetTranslatedString(@"CustomThemeBuilder_WallpaperTitle");	
	
        /// <summary>
		/// You have reached the account creation limit. Would you like to purchase 'Unlimited Account' add-on to continue?
		/// </summary>
		public static string DialogMessage_AccountLimitMessage => Resources.GetTranslatedString(@"DialogMessage_AccountLimitMessage");	
	
        /// <summary>
		/// Account Limit Reached
		/// </summary>
		public static string DialogMessage_AccountLimitTitle => Resources.GetTranslatedString(@"DialogMessage_AccountLimitTitle");	
	
        /// <summary>
		/// Do you want to permanently delete all the mails in this folder?
		/// </summary>
		public static string DialogMessage_CleanupFolderMessage => Resources.GetTranslatedString(@"DialogMessage_CleanupFolderMessage");	
	
        /// <summary>
		/// Cleanup Folder
		/// </summary>
		public static string DialogMessage_CleanupFolderTitle => Resources.GetTranslatedString(@"DialogMessage_CleanupFolderTitle");	
	
        /// <summary>
		/// Message has no recipient.
		/// </summary>
		public static string DialogMessage_ComposerMissingRecipientMessage => Resources.GetTranslatedString(@"DialogMessage_ComposerMissingRecipientMessage");	
	
        /// <summary>
		/// Validation Failed
		/// </summary>
		public static string DialogMessage_ComposerValidationFailedTitle => Resources.GetTranslatedString(@"DialogMessage_ComposerValidationFailedTitle");	
	
        /// <summary>
		/// Give this new link a name. Accounts will be merged under this name.
		/// </summary>
		public static string DialogMessage_CreateLinkedAccountMessage => Resources.GetTranslatedString(@"DialogMessage_CreateLinkedAccountMessage");	
	
        /// <summary>
		/// Account Link Name
		/// </summary>
		public static string DialogMessage_CreateLinkedAccountTitle => Resources.GetTranslatedString(@"DialogMessage_CreateLinkedAccountTitle");	
	
        /// <summary>
		/// Delete {0}?
		/// </summary>
		public static string DialogMessage_DeleteAccountConfirmationMessage => Resources.GetTranslatedString(@"DialogMessage_DeleteAccountConfirmationMessage");	
	
        /// <summary>
		/// All data associated with this account will be deleted from disk permanently.
		/// </summary>
		public static string DialogMessage_DeleteAccountConfirmationTitle => Resources.GetTranslatedString(@"DialogMessage_DeleteAccountConfirmationTitle");	
	
        /// <summary>
		/// This draft will be discarded. Do you want to continue?
		/// </summary>
		public static string DialogMessage_DiscardDraftConfirmationMessage => Resources.GetTranslatedString(@"DialogMessage_DiscardDraftConfirmationMessage");	
	
        /// <summary>
		/// Discard Draft
		/// </summary>
		public static string DialogMessage_DiscardDraftConfirmationTitle => Resources.GetTranslatedString(@"DialogMessage_DiscardDraftConfirmationTitle");	
	
        /// <summary>
		/// Permanent Delete
		/// </summary>
		public static string DialogMessage_HardDeleteConfirmationMessage => Resources.GetTranslatedString(@"DialogMessage_HardDeleteConfirmationMessage");	
	
        /// <summary>
		/// Message(s) will be permanently deleted. Do you want to continue?
		/// </summary>
		public static string DialogMessage_HardDeleteConfirmationTitle => Resources.GetTranslatedString(@"DialogMessage_HardDeleteConfirmationTitle");	
	
        /// <summary>
		/// You don't have any accounts to create message from.
		/// </summary>
		public static string DialogMessage_NoAccountsForCreateMailMessage => Resources.GetTranslatedString(@"DialogMessage_NoAccountsForCreateMailMessage");	
	
        /// <summary>
		/// Account Missing
		/// </summary>
		public static string DialogMessage_NoAccountsForCreateMailTitle => Resources.GetTranslatedString(@"DialogMessage_NoAccountsForCreateMailTitle");	
	
        /// <summary>
		/// Enter new name for linked account
		/// </summary>
		public static string DialogMessage_RenameLinkedAccountsMessage => Resources.GetTranslatedString(@"DialogMessage_RenameLinkedAccountsMessage");	
	
        /// <summary>
		/// Rename Linked Account
		/// </summary>
		public static string DialogMessage_RenameLinkedAccountsTitle => Resources.GetTranslatedString(@"DialogMessage_RenameLinkedAccountsTitle");	
	
        /// <summary>
		/// This operation will not delete your accounts but only break the link for shared folder connections. Do you want to continue?
		/// </summary>
		public static string DialogMessage_UnlinkAccountsConfirmationMessage => Resources.GetTranslatedString(@"DialogMessage_UnlinkAccountsConfirmationMessage");	
	
        /// <summary>
		/// Unlink Accounts
		/// </summary>
		public static string DialogMessage_UnlinkAccountsConfirmationTitle => Resources.GetTranslatedString(@"DialogMessage_UnlinkAccountsConfirmationTitle");	
	
        /// <summary>
		/// Missin Subject
		/// </summary>
		public static string DialogMessage_EmptySubjectConfirmation => Resources.GetTranslatedString(@"DialogMessage_EmptySubjectConfirmation");	
	
        /// <summary>
		/// Message has no subject. Do you want to continue?
		/// </summary>
		public static string DialogMessage_EmptySubjectConfirmationMessage => Resources.GetTranslatedString(@"DialogMessage_EmptySubjectConfirmationMessage");	
	
        /// <summary>
		/// Don't ask again
		/// </summary>
		public static string Dialog_DontAskAgain => Resources.GetTranslatedString(@"Dialog_DontAskAgain");	
	
        /// <summary>
		/// Wino doesn't have it's own Discord server, but special 'wino-mail' channel is hosted at 'Developer Sanctuary' server. To get the updates about Wino please join Developer Sanctuary server and follow 'wino-mail' channel under 'Community Projects'  You will be directed to server URL since Discord doesn't support channel invites.
		/// </summary>
		public static string DiscordChannelDisclaimerMessage => Resources.GetTranslatedString(@"DiscordChannelDisclaimerMessage");	
	
        /// <summary>
		/// Important Discord Information
		/// </summary>
		public static string DiscordChannelDisclaimerTitle => Resources.GetTranslatedString(@"DiscordChannelDisclaimerTitle");	
	
        /// <summary>
		/// Draft
		/// </summary>
		public static string Draft => Resources.GetTranslatedString(@"Draft");	
	
        /// <summary>
		/// Draw
		/// </summary>
		public static string EditorToolbarOption_Draw => Resources.GetTranslatedString(@"EditorToolbarOption_Draw");	
	
        /// <summary>
		/// Format
		/// </summary>
		public static string EditorToolbarOption_Format => Resources.GetTranslatedString(@"EditorToolbarOption_Format");	
	
        /// <summary>
		/// Insert
		/// </summary>
		public static string EditorToolbarOption_Insert => Resources.GetTranslatedString(@"EditorToolbarOption_Insert");	
	
        /// <summary>
		/// None
		/// </summary>
		public static string EditorToolbarOption_None => Resources.GetTranslatedString(@"EditorToolbarOption_None");	
	
        /// <summary>
		/// Options
		/// </summary>
		public static string EditorToolbarOption_Options => Resources.GetTranslatedString(@"EditorToolbarOption_Options");	
	
        /// <summary>
		/// Dark mode
		/// </summary>
		public static string ElementTheme_Dark => Resources.GetTranslatedString(@"ElementTheme_Dark");	
	
        /// <summary>
		/// Use system setting
		/// </summary>
		public static string ElementTheme_Default => Resources.GetTranslatedString(@"ElementTheme_Default");	
	
        /// <summary>
		/// Light mode
		/// </summary>
		public static string ElementTheme_Light => Resources.GetTranslatedString(@"ElementTheme_Light");	
	
        /// <summary>
		/// Emoji
		/// </summary>
		public static string Emoji => Resources.GetTranslatedString(@"Emoji");	
	
        /// <summary>
		/// IMAP Client Pool failed.
		/// </summary>
		public static string Exception_ImapClientPoolFailed => Resources.GetTranslatedString(@"Exception_ImapClientPoolFailed");	
	
        /// <summary>
		/// Authentication canceled
		/// </summary>
		public static string Exception_AuthenticationCanceled => Resources.GetTranslatedString(@"Exception_AuthenticationCanceled");	
	
        /// <summary>
		/// This theme already exists.
		/// </summary>
		public static string Exception_CustomThemeExists => Resources.GetTranslatedString(@"Exception_CustomThemeExists");	
	
        /// <summary>
		/// You must provide a name.
		/// </summary>
		public static string Exception_CustomThemeMissingName => Resources.GetTranslatedString(@"Exception_CustomThemeMissingName");	
	
        /// <summary>
		/// You must provide a custom background image.
		/// </summary>
		public static string Exception_CustomThemeMissingWallpaper => Resources.GetTranslatedString(@"Exception_CustomThemeMissingWallpaper");	
	
        /// <summary>
		/// Failed to synchronize folders
		/// </summary>
		public static string Exception_FailedToSynchronizeFolders => Resources.GetTranslatedString(@"Exception_FailedToSynchronizeFolders");	
	
        /// <summary>
		/// Callback uri is null on activation.
		/// </summary>
		public static string Exception_GoogleAuthCallbackNull => Resources.GetTranslatedString(@"Exception_GoogleAuthCallbackNull");	
	
        /// <summary>
		/// Corrupted authorization response.
		/// </summary>
		public static string Exception_GoogleAuthCorruptedCode => Resources.GetTranslatedString(@"Exception_GoogleAuthCorruptedCode");	
	
        /// <summary>
		/// OAuth authorization error: {0}
		/// </summary>
		public static string Exception_GoogleAuthError => Resources.GetTranslatedString(@"Exception_GoogleAuthError");	
	
        /// <summary>
		/// Received request with invalid state ({0})
		/// </summary>
		public static string Exception_GoogleAuthInvalidResponse => Resources.GetTranslatedString(@"Exception_GoogleAuthInvalidResponse");	
	
        /// <summary>
		/// Authorization code exchange failed.
		/// </summary>
		public static string Exception_GoogleAuthorizationCodeExchangeFailed => Resources.GetTranslatedString(@"Exception_GoogleAuthorizationCodeExchangeFailed");	
	
        /// <summary>
		/// System folder configuration is not valid. Check configuration and try again.
		/// </summary>
		public static string Exception_InvalidSystemFolderConfiguration => Resources.GetTranslatedString(@"Exception_InvalidSystemFolderConfiguration");	
	
        /// <summary>
		/// Assigned account is null
		/// </summary>
		public static string Exception_NullAssignedAccount => Resources.GetTranslatedString(@"Exception_NullAssignedAccount");	
	
        /// <summary>
		/// Assigned folder is null
		/// </summary>
		public static string Exception_NullAssignedFolder => Resources.GetTranslatedString(@"Exception_NullAssignedFolder");	
	
        /// <summary>
		/// Response handling failed with error HTTP code {0}
		/// </summary>
		public static string Exception_SynchronizerFailureHTTP => Resources.GetTranslatedString(@"Exception_SynchronizerFailureHTTP");	
	
        /// <summary>
		/// Token generation failed
		/// </summary>
		public static string Exception_TokenGenerationFailed => Resources.GetTranslatedString(@"Exception_TokenGenerationFailed");	
	
        /// <summary>
		/// Failed to get token information.
		/// </summary>
		public static string Exception_TokenInfoRetrivalFailed => Resources.GetTranslatedString(@"Exception_TokenInfoRetrivalFailed");	
	
        /// <summary>
		/// Unknown error occurred during authentication
		/// </summary>
		public static string Exception_UnknowErrorDuringAuthentication => Resources.GetTranslatedString(@"Exception_UnknowErrorDuringAuthentication");	
	
        /// <summary>
		/// Action {0} is not implemented in request processor
		/// </summary>
		public static string Exception_UnsupportedAction => Resources.GetTranslatedString(@"Exception_UnsupportedAction");	
	
        /// <summary>
		/// This provider is not supported.
		/// </summary>
		public static string Exception_UnsupportedProvider => Resources.GetTranslatedString(@"Exception_UnsupportedProvider");	
	
        /// <summary>
		/// This operation is not supported for {0}
		/// </summary>
		public static string Exception_UnsupportedSynchronizerOperation => Resources.GetTranslatedString(@"Exception_UnsupportedSynchronizerOperation");	
	
        /// <summary>
		/// User canceled system folder config dialog.
		/// </summary>
		public static string Exception_UserCancelSystemFolderSetupDialog => Resources.GetTranslatedString(@"Exception_UserCancelSystemFolderSetupDialog");	
	
        /// <summary>
		/// Couldn't setup account folders.
		/// </summary>
		public static string Exception_InboxNotAvailable => Resources.GetTranslatedString(@"Exception_InboxNotAvailable");	
	
        /// <summary>
		/// Files
		/// </summary>
		public static string Files => Resources.GetTranslatedString(@"Files");	
	
        /// <summary>
		/// All
		/// </summary>
		public static string FilteringOption_All => Resources.GetTranslatedString(@"FilteringOption_All");	
	
        /// <summary>
		/// Flagged
		/// </summary>
		public static string FilteringOption_Flagged => Resources.GetTranslatedString(@"FilteringOption_Flagged");	
	
        /// <summary>
		/// Unread
		/// </summary>
		public static string FilteringOption_Unread => Resources.GetTranslatedString(@"FilteringOption_Unread");	
	
        /// <summary>
		/// Focused
		/// </summary>
		public static string Focused => Resources.GetTranslatedString(@"Focused");	
	
        /// <summary>
		/// Create sub folder
		/// </summary>
		public static string FolderOperation_CreateSubFolder => Resources.GetTranslatedString(@"FolderOperation_CreateSubFolder");	
	
        /// <summary>
		/// Delete
		/// </summary>
		public static string FolderOperation_Delete => Resources.GetTranslatedString(@"FolderOperation_Delete");	
	
        /// <summary>
		/// Don't sync this folder
		/// </summary>
		public static string FolderOperation_DontSync => Resources.GetTranslatedString(@"FolderOperation_DontSync");	
	
        /// <summary>
		/// Empty this folder
		/// </summary>
		public static string FolderOperation_Empty => Resources.GetTranslatedString(@"FolderOperation_Empty");	
	
        /// <summary>
		/// Mark all as read
		/// </summary>
		public static string FolderOperation_MarkAllAsRead => Resources.GetTranslatedString(@"FolderOperation_MarkAllAsRead");	
	
        /// <summary>
		/// Move
		/// </summary>
		public static string FolderOperation_Move => Resources.GetTranslatedString(@"FolderOperation_Move");	
	
        /// <summary>
		/// Move to {0}
		/// </summary>
		public static string DragMoveToFolderCaption => Resources.GetTranslatedString(@"DragMoveToFolderCaption");	
	
        /// <summary>
		/// None
		/// </summary>
		public static string FolderOperation_None => Resources.GetTranslatedString(@"FolderOperation_None");	
	
        /// <summary>
		/// Pin
		/// </summary>
		public static string FolderOperation_Pin => Resources.GetTranslatedString(@"FolderOperation_Pin");	
	
        /// <summary>
		/// Rename
		/// </summary>
		public static string FolderOperation_Rename => Resources.GetTranslatedString(@"FolderOperation_Rename");	
	
        /// <summary>
		/// Unpin
		/// </summary>
		public static string FolderOperation_Unpin => Resources.GetTranslatedString(@"FolderOperation_Unpin");	
	
        /// <summary>
		/// Archive
		/// </summary>
		public static string HoverActionOption_Archive => Resources.GetTranslatedString(@"HoverActionOption_Archive");	
	
        /// <summary>
		/// Delete
		/// </summary>
		public static string HoverActionOption_Delete => Resources.GetTranslatedString(@"HoverActionOption_Delete");	
	
        /// <summary>
		/// Move to Junk
		/// </summary>
		public static string HoverActionOption_MoveJunk => Resources.GetTranslatedString(@"HoverActionOption_MoveJunk");	
	
        /// <summary>
		/// Flag / Unflag
		/// </summary>
		public static string HoverActionOption_ToggleFlag => Resources.GetTranslatedString(@"HoverActionOption_ToggleFlag");	
	
        /// <summary>
		/// Read / Unread
		/// </summary>
		public static string HoverActionOption_ToggleRead => Resources.GetTranslatedString(@"HoverActionOption_ToggleRead");	
	
        /// <summary>
		/// Inbox
		/// </summary>
		public static string MergedAccountCommonFolderInbox => Resources.GetTranslatedString(@"MergedAccountCommonFolderInbox");	
	
        /// <summary>
		/// Sent
		/// </summary>
		public static string MergedAccountCommonFolderSent => Resources.GetTranslatedString(@"MergedAccountCommonFolderSent");	
	
        /// <summary>
		/// Draft
		/// </summary>
		public static string MergedAccountCommonFolderDraft => Resources.GetTranslatedString(@"MergedAccountCommonFolderDraft");	
	
        /// <summary>
		/// Junk
		/// </summary>
		public static string MergedAccountCommonFolderJunk => Resources.GetTranslatedString(@"MergedAccountCommonFolderJunk");	
	
        /// <summary>
		/// Deleted
		/// </summary>
		public static string MergedAccountCommonFolderTrash => Resources.GetTranslatedString(@"MergedAccountCommonFolderTrash");	
	
        /// <summary>
		/// Archive
		/// </summary>
		public static string MergedAccountCommonFolderArchive => Resources.GetTranslatedString(@"MergedAccountCommonFolderArchive");	
	
        /// <summary>
		/// Account type
		/// </summary>
		public static string IMAPSetupDialog_AccountType => Resources.GetTranslatedString(@"IMAPSetupDialog_AccountType");	
	
        /// <summary>
		/// Display Name
		/// </summary>
		public static string IMAPSetupDialog_DisplayName => Resources.GetTranslatedString(@"IMAPSetupDialog_DisplayName");	
	
        /// <summary>
		/// eg. John Doe
		/// </summary>
		public static string IMAPSetupDialog_DisplayNamePlaceholder => Resources.GetTranslatedString(@"IMAPSetupDialog_DisplayNamePlaceholder");	
	
        /// <summary>
		/// Incoming mail server
		/// </summary>
		public static string IMAPSetupDialog_IncomingMailServer => Resources.GetTranslatedString(@"IMAPSetupDialog_IncomingMailServer");	
	
        /// <summary>
		/// Port
		/// </summary>
		public static string IMAPSetupDialog_IncomingMailServerPort => Resources.GetTranslatedString(@"IMAPSetupDialog_IncomingMailServerPort");	
	
        /// <summary>
		/// Email address
		/// </summary>
		public static string IMAPSetupDialog_MailAddress => Resources.GetTranslatedString(@"IMAPSetupDialog_MailAddress");	
	
        /// <summary>
		/// someone@example.com
		/// </summary>
		public static string IMAPSetupDialog_MailAddressPlaceholder => Resources.GetTranslatedString(@"IMAPSetupDialog_MailAddressPlaceholder");	
	
        /// <summary>
		/// Outgoing (SMTP) mail server
		/// </summary>
		public static string IMAPSetupDialog_OutgoingMailServer => Resources.GetTranslatedString(@"IMAPSetupDialog_OutgoingMailServer");	
	
        /// <summary>
		/// Outgoing server password
		/// </summary>
		public static string IMAPSetupDialog_OutgoingMailServerPassword => Resources.GetTranslatedString(@"IMAPSetupDialog_OutgoingMailServerPassword");	
	
        /// <summary>
		/// Port
		/// </summary>
		public static string IMAPSetupDialog_OutgoingMailServerPort => Resources.GetTranslatedString(@"IMAPSetupDialog_OutgoingMailServerPort");	
	
        /// <summary>
		/// Outgoing server requires authentication
		/// </summary>
		public static string IMAPSetupDialog_OutgoingMailServerRequireAuthentication => Resources.GetTranslatedString(@"IMAPSetupDialog_OutgoingMailServerRequireAuthentication");	
	
        /// <summary>
		/// Outgoing server user name
		/// </summary>
		public static string IMAPSetupDialog_OutgoingMailServerUsername => Resources.GetTranslatedString(@"IMAPSetupDialog_OutgoingMailServerUsername");	
	
        /// <summary>
		/// Password
		/// </summary>
		public static string IMAPSetupDialog_Password => Resources.GetTranslatedString(@"IMAPSetupDialog_Password");	
	
        /// <summary>
		/// Require SSL for incoming email
		/// </summary>
		public static string IMAPSetupDialog_RequireSSLForIncomingMail => Resources.GetTranslatedString(@"IMAPSetupDialog_RequireSSLForIncomingMail");	
	
        /// <summary>
		/// Require SSL for outgoing email
		/// </summary>
		public static string IMAPSetupDialog_RequireSSLForOutgoingMail => Resources.GetTranslatedString(@"IMAPSetupDialog_RequireSSLForOutgoingMail");	
	
        /// <summary>
		/// Advanced IMAP Configuration
		/// </summary>
		public static string IMAPSetupDialog_Title => Resources.GetTranslatedString(@"IMAPSetupDialog_Title");	
	
        /// <summary>
		/// Use the same username and password for sending email
		/// </summary>
		public static string IMAPSetupDialog_UseSameConfig => Resources.GetTranslatedString(@"IMAPSetupDialog_UseSameConfig");	
	
        /// <summary>
		/// Username
		/// </summary>
		public static string IMAPSetupDialog_Username => Resources.GetTranslatedString(@"IMAPSetupDialog_Username");	
	
        /// <summary>
		/// johndoe, johndoe@fabrikam.com, domain/johndoe
		/// </summary>
		public static string IMAPSetupDialog_UsernamePlaceholder => Resources.GetTranslatedString(@"IMAPSetupDialog_UsernamePlaceholder");	
	
        /// <summary>
		/// Image rendering is disabled for this message.
		/// </summary>
		public static string ImageRenderingDisabled => Resources.GetTranslatedString(@"ImageRenderingDisabled");	
	
        /// <summary>
		/// Enable
		/// </summary>
		public static string InfoBarAction_Enable => Resources.GetTranslatedString(@"InfoBarAction_Enable");	
	
        /// <summary>
		/// This folder is disabled for synchronization.
		/// </summary>
		public static string InfoBarMessage_SynchronizationDisabledFolder => Resources.GetTranslatedString(@"InfoBarMessage_SynchronizationDisabledFolder");	
	
        /// <summary>
		/// Disabled Folder
		/// </summary>
		public static string InfoBarTitle_SynchronizationDisabledFolder => Resources.GetTranslatedString(@"InfoBarTitle_SynchronizationDisabledFolder");	
	
        /// <summary>
		/// Error
		/// </summary>
		public static string GeneralTitle_Error => Resources.GetTranslatedString(@"GeneralTitle_Error");	
	
        /// <summary>
		/// Warning
		/// </summary>
		public static string GeneralTitle_Warning => Resources.GetTranslatedString(@"GeneralTitle_Warning");	
	
        /// <summary>
		/// Information
		/// </summary>
		public static string GeneralTitle_Info => Resources.GetTranslatedString(@"GeneralTitle_Info");	
	
        /// <summary>
		/// {0} is created
		/// </summary>
		public static string Info_AccountCreatedMessage => Resources.GetTranslatedString(@"Info_AccountCreatedMessage");	
	
        /// <summary>
		/// Account Creation
		/// </summary>
		public static string Info_AccountCreatedTitle => Resources.GetTranslatedString(@"Info_AccountCreatedTitle");	
	
        /// <summary>
		/// Account Creation Failed
		/// </summary>
		public static string Info_AccountCreationFailedTitle => Resources.GetTranslatedString(@"Info_AccountCreationFailedTitle");	
	
        /// <summary>
		/// {0} is successfuly deleted.
		/// </summary>
		public static string Info_AccountDeletedMessage => Resources.GetTranslatedString(@"Info_AccountDeletedMessage");	
	
        /// <summary>
		/// Account Deleted
		/// </summary>
		public static string Info_AccountDeletedTitle => Resources.GetTranslatedString(@"Info_AccountDeletedTitle");	
	
        /// <summary>
		/// Failed
		/// </summary>
		public static string Info_AccountIssueFixFailedTitle => Resources.GetTranslatedString(@"Info_AccountIssueFixFailedTitle");	
	
        /// <summary>
		/// Fixed all account issues.
		/// </summary>
		public static string Info_AccountIssueFixSuccessMessage => Resources.GetTranslatedString(@"Info_AccountIssueFixSuccessMessage");	
	
        /// <summary>
		/// Success
		/// </summary>
		public static string Info_AccountIssueFixSuccessTitle => Resources.GetTranslatedString(@"Info_AccountIssueFixSuccessTitle");	
	
        /// <summary>
		/// Can't open this attachment.
		/// </summary>
		public static string Info_AttachmentOpenFailedMessage => Resources.GetTranslatedString(@"Info_AttachmentOpenFailedMessage");	
	
        /// <summary>
		/// Failed
		/// </summary>
		public static string Info_AttachmentOpenFailedTitle => Resources.GetTranslatedString(@"Info_AttachmentOpenFailedTitle");	
	
        /// <summary>
		/// Can't save this attachment.
		/// </summary>
		public static string Info_AttachmentSaveFailedMessage => Resources.GetTranslatedString(@"Info_AttachmentSaveFailedMessage");	
	
        /// <summary>
		/// Failed
		/// </summary>
		public static string Info_AttachmentSaveFailedTitle => Resources.GetTranslatedString(@"Info_AttachmentSaveFailedTitle");	
	
        /// <summary>
		/// Attachment is saved.
		/// </summary>
		public static string Info_AttachmentSaveSuccessMessage => Resources.GetTranslatedString(@"Info_AttachmentSaveSuccessMessage");	
	
        /// <summary>
		/// Attachment Saved
		/// </summary>
		public static string Info_AttachmentSaveSuccessTitle => Resources.GetTranslatedString(@"Info_AttachmentSaveSuccessTitle");	
	
        /// <summary>
		/// Background execution for the app is denied. This may affect background synchronization and live notifications.
		/// </summary>
		public static string Info_BackgroundExecutionDeniedMessage => Resources.GetTranslatedString(@"Info_BackgroundExecutionDeniedMessage");	
	
        /// <summary>
		/// Denied Background Execution
		/// </summary>
		public static string Info_BackgroundExecutionDeniedTitle => Resources.GetTranslatedString(@"Info_BackgroundExecutionDeniedTitle");	
	
        /// <summary>
		/// Unknown exception occurred when registering background synchronizer.
		/// </summary>
		public static string Info_BackgroundExecutionUnknownErrorMessage => Resources.GetTranslatedString(@"Info_BackgroundExecutionUnknownErrorMessage");	
	
        /// <summary>
		/// Background Execution Failure
		/// </summary>
		public static string Info_BackgroundExecutionUnknownErrorTitle => Resources.GetTranslatedString(@"Info_BackgroundExecutionUnknownErrorTitle");	
	
        /// <summary>
		/// Couldn't locate the MIME file. Synchronizing may help.
		/// </summary>
		public static string Info_ComposerMissingMIMEMessage => Resources.GetTranslatedString(@"Info_ComposerMissingMIMEMessage");	
	
        /// <summary>
		/// Failed
		/// </summary>
		public static string Info_ComposerMissingMIMETitle => Resources.GetTranslatedString(@"Info_ComposerMissingMIMETitle");	
	
        /// <summary>
		/// This contact is already in the recipient list.
		/// </summary>
		public static string Info_ContactExistsMessage => Resources.GetTranslatedString(@"Info_ContactExistsMessage");	
	
        /// <summary>
		/// Contact Exists
		/// </summary>
		public static string Info_ContactExistsTitle => Resources.GetTranslatedString(@"Info_ContactExistsTitle");	
	
        /// <summary>
		/// Draft folder is missing for this account. Please check your account settings.
		/// </summary>
		public static string Info_DraftFolderMissingMessage => Resources.GetTranslatedString(@"Info_DraftFolderMissingMessage");	
	
        /// <summary>
		/// Missing Draft Folder
		/// </summary>
		public static string Info_DraftFolderMissingTitle => Resources.GetTranslatedString(@"Info_DraftFolderMissingTitle");	
	
        /// <summary>
		/// Failed to launch file
		/// </summary>
		public static string Info_FileLaunchFailedTitle => Resources.GetTranslatedString(@"Info_FileLaunchFailedTitle");	
	
        /// <summary>
		/// '{0}' is not a valid e-mail address.
		/// </summary>
		public static string Info_InvalidAddressMessage => Resources.GetTranslatedString(@"Info_InvalidAddressMessage");	
	
        /// <summary>
		/// Invalid Address
		/// </summary>
		public static string Info_InvalidAddressTitle => Resources.GetTranslatedString(@"Info_InvalidAddressTitle");	
	
        /// <summary>
		/// You can't move selected mails to this folder.
		/// </summary>
		public static string Info_InvalidMoveTargetMessage => Resources.GetTranslatedString(@"Info_InvalidMoveTargetMessage");	
	
        /// <summary>
		/// Invalid Move Target
		/// </summary>
		public static string Info_InvalidMoveTargetTitle => Resources.GetTranslatedString(@"Info_InvalidMoveTargetTitle");	
	
        /// <summary>
		/// There are no logs to share.
		/// </summary>
		public static string Info_LogsNotFoundMessage => Resources.GetTranslatedString(@"Info_LogsNotFoundMessage");	
	
        /// <summary>
		/// Logs Not Found
		/// </summary>
		public static string Info_LogsNotFoundTitle => Resources.GetTranslatedString(@"Info_LogsNotFoundTitle");	
	
        /// <summary>
		/// {0} is saved to selected folder.
		/// </summary>
		public static string Info_LogsSavedMessage => Resources.GetTranslatedString(@"Info_LogsSavedMessage");	
	
        /// <summary>
		/// Saved
		/// </summary>
		public static string Info_LogsSavedTitle => Resources.GetTranslatedString(@"Info_LogsSavedTitle");	
	
        /// <summary>
		/// This mail is corrupted or can't be opened. {0}
		/// </summary>
		public static string Info_MailRenderingFailedMessage => Resources.GetTranslatedString(@"Info_MailRenderingFailedMessage");	
	
        /// <summary>
		/// Render Failed
		/// </summary>
		public static string Info_MailRenderingFailedTitle => Resources.GetTranslatedString(@"Info_MailRenderingFailedTitle");	
	
        /// <summary>
		/// This message is corrupted.
		/// </summary>
		public static string Info_MessageCorruptedMessage => Resources.GetTranslatedString(@"Info_MessageCorruptedMessage");	
	
        /// <summary>
		/// Error
		/// </summary>
		public static string Info_MessageCorruptedTitle => Resources.GetTranslatedString(@"Info_MessageCorruptedTitle");	
	
        /// <summary>
		/// {0} doesn't exist for this account.
		/// </summary>
		public static string Info_MissingFolderMessage => Resources.GetTranslatedString(@"Info_MissingFolderMessage");	
	
        /// <summary>
		/// Missing Folder
		/// </summary>
		public static string Info_MissingFolderTitle => Resources.GetTranslatedString(@"Info_MissingFolderTitle");	
	
        /// <summary>
		/// Success
		/// </summary>
		public static string Info_PDFSaveSuccessTitle => Resources.GetTranslatedString(@"Info_PDFSaveSuccessTitle");	
	
        /// <summary>
		/// Failed to save PDF file
		/// </summary>
		public static string Info_PDFSaveFailedTitle => Resources.GetTranslatedString(@"Info_PDFSaveFailedTitle");	
	
        /// <summary>
		/// PDF file is saved to {0}
		/// </summary>
		public static string Info_PDFSaveSuccessMessage => Resources.GetTranslatedString(@"Info_PDFSaveSuccessMessage");	
	
        /// <summary>
		/// Looks like this product has already been purchased before.
		/// </summary>
		public static string Info_PurchaseExistsMessage => Resources.GetTranslatedString(@"Info_PurchaseExistsMessage");	
	
        /// <summary>
		/// Existing Product
		/// </summary>
		public static string Info_PurchaseExistsTitle => Resources.GetTranslatedString(@"Info_PurchaseExistsTitle");	
	
        /// <summary>
		/// Thank You
		/// </summary>
		public static string Info_PurchaseThankYouMessage => Resources.GetTranslatedString(@"Info_PurchaseThankYouMessage");	
	
        /// <summary>
		/// Purchase successful
		/// </summary>
		public static string Info_PurchaseThankYouTitle => Resources.GetTranslatedString(@"Info_PurchaseThankYouTitle");	
	
        /// <summary>
		/// Failed to Create Requests
		/// </summary>
		public static string Info_RequestCreationFailedTitle => Resources.GetTranslatedString(@"Info_RequestCreationFailedTitle");	
	
        /// <summary>
		/// There was a network issue with your review.
		/// </summary>
		public static string Info_ReviewNetworkErrorMessage => Resources.GetTranslatedString(@"Info_ReviewNetworkErrorMessage");	
	
        /// <summary>
		/// Network Issue
		/// </summary>
		public static string Info_ReviewNetworkErrorTitle => Resources.GetTranslatedString(@"Info_ReviewNetworkErrorTitle");	
	
        /// <summary>
		/// All feedbacks are appreciated. Thank you for the review!
		/// </summary>
		public static string Info_ReviewNewMessage => Resources.GetTranslatedString(@"Info_ReviewNewMessage");	
	
        /// <summary>
		/// Thank you
		/// </summary>
		public static string Info_ReviewSuccessTitle => Resources.GetTranslatedString(@"Info_ReviewSuccessTitle");	
	
        /// <summary>
		/// There was an unknown issue with your review. ({0})
		/// </summary>
		public static string Info_ReviewUnknownErrorMessage => Resources.GetTranslatedString(@"Info_ReviewUnknownErrorMessage");	
	
        /// <summary>
		/// Unknown Error
		/// </summary>
		public static string Info_ReviewUnknownErrorTitle => Resources.GetTranslatedString(@"Info_ReviewUnknownErrorTitle");	
	
        /// <summary>
		/// Thank you for the updated review.
		/// </summary>
		public static string Info_ReviewUpdatedMessage => Resources.GetTranslatedString(@"Info_ReviewUpdatedMessage");	
	
        /// <summary>
		/// Disabled signature for this account
		/// </summary>
		public static string Info_SignatureDisabledMessage => Resources.GetTranslatedString(@"Info_SignatureDisabledMessage");	
	
        /// <summary>
		/// Success
		/// </summary>
		public static string Info_SignatureDisabledTitle => Resources.GetTranslatedString(@"Info_SignatureDisabledTitle");	
	
        /// <summary>
		/// New signature is saved
		/// </summary>
		public static string Info_SignatureSavedMessage => Resources.GetTranslatedString(@"Info_SignatureSavedMessage");	
	
        /// <summary>
		/// Success
		/// </summary>
		public static string Info_SignatureSavedTitle => Resources.GetTranslatedString(@"Info_SignatureSavedTitle");	
	
        /// <summary>
		/// Canceled
		/// </summary>
		public static string Info_SyncCanceledMessage => Resources.GetTranslatedString(@"Info_SyncCanceledMessage");	
	
        /// <summary>
		/// Synchronization
		/// </summary>
		public static string Info_SyncCanceledTitle => Resources.GetTranslatedString(@"Info_SyncCanceledTitle");	
	
        /// <summary>
		/// Synchronization Failed
		/// </summary>
		public static string Info_SyncFailedTitle => Resources.GetTranslatedString(@"Info_SyncFailedTitle");	
	
        /// <summary>
		/// This functionality is not implemented yet.
		/// </summary>
		public static string Info_UnsupportedFunctionalityDescription => Resources.GetTranslatedString(@"Info_UnsupportedFunctionalityDescription");	
	
        /// <summary>
		/// Unsupported
		/// </summary>
		public static string Info_UnsupportedFunctionalityTitle => Resources.GetTranslatedString(@"Info_UnsupportedFunctionalityTitle");	
	
        /// <summary>
		/// Invalid Unsubscribe Uri
		/// </summary>
		public static string Info_UnsubscribeLinkInvalidTitle => Resources.GetTranslatedString(@"Info_UnsubscribeLinkInvalidTitle");	
	
        /// <summary>
		/// This unsubscribe link is invalid. Failed to unsubscribe from the list.
		/// </summary>
		public static string Info_UnsubscribeLinkInvalidMessage => Resources.GetTranslatedString(@"Info_UnsubscribeLinkInvalidMessage");	
	
        /// <summary>
		/// Authentication method
		/// </summary>
		public static string ImapAdvancedSetupDialog_AuthenticationMethod => Resources.GetTranslatedString(@"ImapAdvancedSetupDialog_AuthenticationMethod");	
	
        /// <summary>
		/// Connection security
		/// </summary>
		public static string ImapAdvancedSetupDialog_ConnectionSecurity => Resources.GetTranslatedString(@"ImapAdvancedSetupDialog_ConnectionSecurity");	
	
        /// <summary>
		/// Auto
		/// </summary>
		public static string ImapAuthenticationMethod_Auto => Resources.GetTranslatedString(@"ImapAuthenticationMethod_Auto");	
	
        /// <summary>
		/// CRAM-MD5
		/// </summary>
		public static string ImapAuthenticationMethod_CramMD5 => Resources.GetTranslatedString(@"ImapAuthenticationMethod_CramMD5");	
	
        /// <summary>
		/// DIGEST-MD5
		/// </summary>
		public static string ImapAuthenticationMethod_DigestMD5 => Resources.GetTranslatedString(@"ImapAuthenticationMethod_DigestMD5");	
	
        /// <summary>
		/// No authentication
		/// </summary>
		public static string ImapAuthenticationMethod_None => Resources.GetTranslatedString(@"ImapAuthenticationMethod_None");	
	
        /// <summary>
		/// Normal password
		/// </summary>
		public static string ImapAuthenticationMethod_Plain => Resources.GetTranslatedString(@"ImapAuthenticationMethod_Plain");	
	
        /// <summary>
		/// Encrypted password
		/// </summary>
		public static string ImapAuthenticationMethod_EncryptedPassword => Resources.GetTranslatedString(@"ImapAuthenticationMethod_EncryptedPassword");	
	
        /// <summary>
		/// NTLM
		/// </summary>
		public static string ImapAuthenticationMethod_Ntlm => Resources.GetTranslatedString(@"ImapAuthenticationMethod_Ntlm");	
	
        /// <summary>
		/// None
		/// </summary>
		public static string ImapConnectionSecurity_None => Resources.GetTranslatedString(@"ImapConnectionSecurity_None");	
	
        /// <summary>
		/// SSL/TLS
		/// </summary>
		public static string ImapConnectionSecurity_SslTls => Resources.GetTranslatedString(@"ImapConnectionSecurity_SslTls");	
	
        /// <summary>
		/// STARTTLS
		/// </summary>
		public static string ImapConnectionSecurity_StartTls => Resources.GetTranslatedString(@"ImapConnectionSecurity_StartTls");	
	
        /// <summary>
		/// Auto
		/// </summary>
		public static string ImapConnectionSecurity_Auto => Resources.GetTranslatedString(@"ImapConnectionSecurity_Auto");	
	
        /// <summary>
		/// Justify
		/// </summary>
		public static string Justify => Resources.GetTranslatedString(@"Justify");	
	
        /// <summary>
		/// Left
		/// </summary>
		public static string Left => Resources.GetTranslatedString(@"Left");	
	
        /// <summary>
		/// Link
		/// </summary>
		public static string Link => Resources.GetTranslatedString(@"Link");	
	
        /// <summary>
		/// you must have at least 2 accounts to create link link will be removed on save
		/// </summary>
		public static string LinkedAccountsCreatePolicyMessage => Resources.GetTranslatedString(@"LinkedAccountsCreatePolicyMessage");	
	
        /// <summary>
		/// Linked Accounts
		/// </summary>
		public static string LinkedAccountsTitle => Resources.GetTranslatedString(@"LinkedAccountsTitle");	
	
        /// <summary>
		/// Always Move to Focused
		/// </summary>
		public static string MailOperation_AlwaysMoveFocused => Resources.GetTranslatedString(@"MailOperation_AlwaysMoveFocused");	
	
        /// <summary>
		/// Always Move to Other
		/// </summary>
		public static string MailOperation_AlwaysMoveOther => Resources.GetTranslatedString(@"MailOperation_AlwaysMoveOther");	
	
        /// <summary>
		/// Archive
		/// </summary>
		public static string MailOperation_Archive => Resources.GetTranslatedString(@"MailOperation_Archive");	
	
        /// <summary>
		/// Clear flag
		/// </summary>
		public static string MailOperation_ClearFlag => Resources.GetTranslatedString(@"MailOperation_ClearFlag");	
	
        /// <summary>
		/// Dark
		/// </summary>
		public static string MailOperation_DarkEditor => Resources.GetTranslatedString(@"MailOperation_DarkEditor");	
	
        /// <summary>
		/// Delete
		/// </summary>
		public static string MailOperation_Delete => Resources.GetTranslatedString(@"MailOperation_Delete");	
	
        /// <summary>
		/// Export to PDF
		/// </summary>
		public static string MailOperation_ExportPDF => Resources.GetTranslatedString(@"MailOperation_ExportPDF");	
	
        /// <summary>
		/// Find
		/// </summary>
		public static string MailOperation_Find => Resources.GetTranslatedString(@"MailOperation_Find");	
	
        /// <summary>
		/// Forward
		/// </summary>
		public static string MailOperation_Forward => Resources.GetTranslatedString(@"MailOperation_Forward");	
	
        /// <summary>
		/// Ignore
		/// </summary>
		public static string MailOperation_Ignore => Resources.GetTranslatedString(@"MailOperation_Ignore");	
	
        /// <summary>
		/// Light
		/// </summary>
		public static string MailOperation_LightEditor => Resources.GetTranslatedString(@"MailOperation_LightEditor");	
	
        /// <summary>
		/// Mark as junk
		/// </summary>
		public static string MailOperation_MarkAsJunk => Resources.GetTranslatedString(@"MailOperation_MarkAsJunk");	
	
        /// <summary>
		/// Mark as read
		/// </summary>
		public static string MailOperation_MarkAsRead => Resources.GetTranslatedString(@"MailOperation_MarkAsRead");	
	
        /// <summary>
		/// Mark as unread
		/// </summary>
		public static string MailOperation_MarkAsUnread => Resources.GetTranslatedString(@"MailOperation_MarkAsUnread");	
	
        /// <summary>
		/// Mark as Not Junk
		/// </summary>
		public static string MailOperation_MarkNotJunk => Resources.GetTranslatedString(@"MailOperation_MarkNotJunk");	
	
        /// <summary>
		/// Move
		/// </summary>
		public static string MailOperation_Move => Resources.GetTranslatedString(@"MailOperation_Move");	
	
        /// <summary>
		/// Move to Focused
		/// </summary>
		public static string MailOperation_MoveFocused => Resources.GetTranslatedString(@"MailOperation_MoveFocused");	
	
        /// <summary>
		/// Move to Junk
		/// </summary>
		public static string MailOperation_MoveJunk => Resources.GetTranslatedString(@"MailOperation_MoveJunk");	
	
        /// <summary>
		/// Move to Other
		/// </summary>
		public static string MailOperation_MoveOther => Resources.GetTranslatedString(@"MailOperation_MoveOther");	
	
        /// <summary>
		/// Navigate
		/// </summary>
		public static string MailOperation_Navigate => Resources.GetTranslatedString(@"MailOperation_Navigate");	
	
        /// <summary>
		/// Print
		/// </summary>
		public static string MailOperation_Print => Resources.GetTranslatedString(@"MailOperation_Print");	
	
        /// <summary>
		/// Reply
		/// </summary>
		public static string MailOperation_Reply => Resources.GetTranslatedString(@"MailOperation_Reply");	
	
        /// <summary>
		/// Reply all
		/// </summary>
		public static string MailOperation_ReplyAll => Resources.GetTranslatedString(@"MailOperation_ReplyAll");	
	
        /// <summary>
		/// Save As
		/// </summary>
		public static string MailOperation_SaveAs => Resources.GetTranslatedString(@"MailOperation_SaveAs");	
	
        /// <summary>
		/// Set flag
		/// </summary>
		public static string MailOperation_SetFlag => Resources.GetTranslatedString(@"MailOperation_SetFlag");	
	
        /// <summary>
		/// Unarchive
		/// </summary>
		public static string MailOperation_Unarchive => Resources.GetTranslatedString(@"MailOperation_Unarchive");	
	
        /// <summary>
		/// Zoom
		/// </summary>
		public static string MailOperation_Zoom => Resources.GetTranslatedString(@"MailOperation_Zoom");	
	
        /// <summary>
		/// {0} item(s) selected
		/// </summary>
		public static string MailsSelected => Resources.GetTranslatedString(@"MailsSelected");	
	
        /// <summary>
		/// Mark as flagged/unflagged
		/// </summary>
		public static string MarkFlagUnflag => Resources.GetTranslatedString(@"MarkFlagUnflag");	
	
        /// <summary>
		/// Mark as read/unread
		/// </summary>
		public static string MarkReadUnread => Resources.GetTranslatedString(@"MarkReadUnread");	
	
        /// <summary>
		/// Manage Accounts
		/// </summary>
		public static string MenuManageAccounts => Resources.GetTranslatedString(@"MenuManageAccounts");	
	
        /// <summary>
		/// New Mail
		/// </summary>
		public static string MenuNewMail => Resources.GetTranslatedString(@"MenuNewMail");	
	
        /// <summary>
		///  accounts
		/// </summary>
		public static string MenuMergedAccountItemAccountsSuffix => Resources.GetTranslatedString(@"MenuMergedAccountItemAccountsSuffix");	
	
        /// <summary>
		/// Rate Wino
		/// </summary>
		public static string MenuRate => Resources.GetTranslatedString(@"MenuRate");	
	
        /// <summary>
		/// Settings
		/// </summary>
		public static string MenuSettings => Resources.GetTranslatedString(@"MenuSettings");	
	
        /// <summary>
		/// Available Accounts
		/// </summary>
		public static string MergedAccountsAvailableAccountsTitle => Resources.GetTranslatedString(@"MergedAccountsAvailableAccountsTitle");	
	
        /// <summary>
		/// More
		/// </summary>
		public static string More => Resources.GetTranslatedString(@"More");	
	
        /// <summary>
		/// {0} is not a valid folder for this mail.
		/// </summary>
		public static string MoveMailDialog_InvalidFolderMessage => Resources.GetTranslatedString(@"MoveMailDialog_InvalidFolderMessage");	
	
        /// <summary>
		/// Pick a folder
		/// </summary>
		public static string MoveMailDialog_Title => Resources.GetTranslatedString(@"MoveMailDialog_Title");	
	
        /// <summary>
		/// Account Name
		/// </summary>
		public static string NewAccountDialog_AccountName => Resources.GetTranslatedString(@"NewAccountDialog_AccountName");	
	
        /// <summary>
		/// Personal
		/// </summary>
		public static string NewAccountDialog_AccountNameDefaultValue => Resources.GetTranslatedString(@"NewAccountDialog_AccountNameDefaultValue");	
	
        /// <summary>
		/// eg. Personal Mail
		/// </summary>
		public static string NewAccountDialog_AccountNamePlaceholder => Resources.GetTranslatedString(@"NewAccountDialog_AccountNamePlaceholder");	
	
        /// <summary>
		/// Add New Account
		/// </summary>
		public static string NewAccountDialog_Title => Resources.GetTranslatedString(@"NewAccountDialog_Title");	
	
        /// <summary>
		/// no message selected
		/// </summary>
		public static string NoMailSelected => Resources.GetTranslatedString(@"NoMailSelected");	
	
        /// <summary>
		/// no messages match your search criteria.
		/// </summary>
		public static string NoMessageCrieteria => Resources.GetTranslatedString(@"NoMessageCrieteria");	
	
        /// <summary>
		/// this folder is empty.
		/// </summary>
		public static string NoMessageEmptyFolder => Resources.GetTranslatedString(@"NoMessageEmptyFolder");	
	
        /// <summary>
		/// You have {0} new mails
		/// </summary>
		public static string Notifications_MultipleNotificationsMessage => Resources.GetTranslatedString(@"Notifications_MultipleNotificationsMessage");	
	
        /// <summary>
		/// New Mails
		/// </summary>
		public static string Notifications_MultipleNotificationsTitle => Resources.GetTranslatedString(@"Notifications_MultipleNotificationsTitle");	
	
        /// <summary>
		/// Checkout new version {0}
		/// </summary>
		public static string Notifications_WinoUpdatedMessage => Resources.GetTranslatedString(@"Notifications_WinoUpdatedMessage");	
	
        /// <summary>
		/// Wino Mail has been updated.
		/// </summary>
		public static string Notifications_WinoUpdatedTitle => Resources.GetTranslatedString(@"Notifications_WinoUpdatedTitle");	
	
        /// <summary>
		/// Other
		/// </summary>
		public static string Other => Resources.GetTranslatedString(@"Other");	
	
        /// <summary>
		/// Default
		/// </summary>
		public static string PaneLengthOption_Default => Resources.GetTranslatedString(@"PaneLengthOption_Default");	
	
        /// <summary>
		/// Extra Large
		/// </summary>
		public static string PaneLengthOption_ExtraLarge => Resources.GetTranslatedString(@"PaneLengthOption_ExtraLarge");	
	
        /// <summary>
		/// Large
		/// </summary>
		public static string PaneLengthOption_Large => Resources.GetTranslatedString(@"PaneLengthOption_Large");	
	
        /// <summary>
		/// Medium
		/// </summary>
		public static string PaneLengthOption_Medium => Resources.GetTranslatedString(@"PaneLengthOption_Medium");	
	
        /// <summary>
		/// Micro
		/// </summary>
		public static string PaneLengthOption_Micro => Resources.GetTranslatedString(@"PaneLengthOption_Micro");	
	
        /// <summary>
		/// Small
		/// </summary>
		public static string PaneLengthOption_Small => Resources.GetTranslatedString(@"PaneLengthOption_Small");	
	
        /// <summary>
		/// Photos
		/// </summary>
		public static string Photos => Resources.GetTranslatedString(@"Photos");	
	
        /// <summary>
		/// Preparing folders
		/// </summary>
		public static string PreparingFoldersMessage => Resources.GetTranslatedString(@"PreparingFoldersMessage");	
	
        /// <summary>
		/// Google Account
		/// </summary>
		public static string ProviderDetail_Gmail_Description => Resources.GetTranslatedString(@"ProviderDetail_Gmail_Description");	
	
        /// <summary>
		/// Custom IMAP/SMTP server
		/// </summary>
		public static string ProviderDetail_IMAP_Description => Resources.GetTranslatedString(@"ProviderDetail_IMAP_Description");	
	
        /// <summary>
		/// IMAP Server
		/// </summary>
		public static string ProviderDetail_IMAP_Title => Resources.GetTranslatedString(@"ProviderDetail_IMAP_Title");	
	
        /// <summary>
		/// Results
		/// </summary>
		public static string Results => Resources.GetTranslatedString(@"Results");	
	
        /// <summary>
		/// Right
		/// </summary>
		public static string Right => Resources.GetTranslatedString(@"Right");	
	
        /// <summary>
		/// up to date
		/// </summary>
		public static string SynchronizationFolderReport_Success => Resources.GetTranslatedString(@"SynchronizationFolderReport_Success");	
	
        /// <summary>
		/// synchronization is failed
		/// </summary>
		public static string SynchronizationFolderReport_Failed => Resources.GetTranslatedString(@"SynchronizationFolderReport_Failed");	
	
        /// <summary>
		/// search
		/// </summary>
		public static string SearchBarPlaceholder => Resources.GetTranslatedString(@"SearchBarPlaceholder");	
	
        /// <summary>
		/// searching in
		/// </summary>
		public static string SearchingIn => Resources.GetTranslatedString(@"SearchingIn");	
	
        /// <summary>
		/// Go to issue tracker GitHub repository.
		/// </summary>
		public static string SettingsAboutGithub_Description => Resources.GetTranslatedString(@"SettingsAboutGithub_Description");	
	
        /// <summary>
		/// GitHub
		/// </summary>
		public static string SettingsAboutGithub_Title => Resources.GetTranslatedString(@"SettingsAboutGithub_Title");	
	
        /// <summary>
		/// Append messages to Sent folder
		/// </summary>
		public static string SettingsAccountManagementAppendMessage_Title => Resources.GetTranslatedString(@"SettingsAccountManagementAppendMessage_Title");	
	
        /// <summary>
		/// Create a copy of the message in Sent folder after the draft is sent. Enable this if you don't see your mails after you sent them in Sent folder.
		/// </summary>
		public static string SettingsAccountManagementAppendMessage_Description => Resources.GetTranslatedString(@"SettingsAccountManagementAppendMessage_Description");	
	
        /// <summary>
		/// Edit Linked Inbox
		/// </summary>
		public static string SettingsEditLinkedInbox_Title => Resources.GetTranslatedString(@"SettingsEditLinkedInbox_Title");	
	
        /// <summary>
		/// Add / remove accounts, rename or break the link between accounts.
		/// </summary>
		public static string SettingsEditLinkedInbox_Description => Resources.GetTranslatedString(@"SettingsEditLinkedInbox_Description");	
	
        /// <summary>
		/// Version 
		/// </summary>
		public static string SettingsAboutVersion => Resources.GetTranslatedString(@"SettingsAboutVersion");	
	
        /// <summary>
		/// Lightweight mail client for Windows device families.
		/// </summary>
		public static string SettingsAboutWinoDescription => Resources.GetTranslatedString(@"SettingsAboutWinoDescription");	
	
        /// <summary>
		/// Learn more about Wino.
		/// </summary>
		public static string SettingsAbout_Description => Resources.GetTranslatedString(@"SettingsAbout_Description");	
	
        /// <summary>
		/// About
		/// </summary>
		public static string SettingsAbout_Title => Resources.GetTranslatedString(@"SettingsAbout_Title");	
	
        /// <summary>
		/// Change application's accent color
		/// </summary>
		public static string SettingsAccentColor_Description => Resources.GetTranslatedString(@"SettingsAccentColor_Description");	
	
        /// <summary>
		/// Accent Color
		/// </summary>
		public static string SettingsAccentColor_Title => Resources.GetTranslatedString(@"SettingsAccentColor_Title");	
	
        /// <summary>
		/// Use my Windows accent color
		/// </summary>
		public static string SettingsAccentColor_UseWindowsAccentColor => Resources.GetTranslatedString(@"SettingsAccentColor_UseWindowsAccentColor");	
	
        /// <summary>
		/// Change the name of the account.
		/// </summary>
		public static string SettingsAccountName_Description => Resources.GetTranslatedString(@"SettingsAccountName_Description");	
	
        /// <summary>
		/// Account Name
		/// </summary>
		public static string SettingsAccountName_Title => Resources.GetTranslatedString(@"SettingsAccountName_Title");	
	
        /// <summary>
		/// Personalize Wino with different custom application themes for your like.
		/// </summary>
		public static string SettingsApplicationTheme_Description => Resources.GetTranslatedString(@"SettingsApplicationTheme_Description");	
	
        /// <summary>
		/// Application Theme
		/// </summary>
		public static string SettingsApplicationTheme_Title => Resources.GetTranslatedString(@"SettingsApplicationTheme_Title");	
	
        /// <summary>
		/// Select a theme from Wino's own collection for your taste or apply your own themes.
		/// </summary>
		public static string SettingsAvailableThemes_Description => Resources.GetTranslatedString(@"SettingsAvailableThemes_Description");	
	
        /// <summary>
		/// Available Themes
		/// </summary>
		public static string SettingsAvailableThemes_Title => Resources.GetTranslatedString(@"SettingsAvailableThemes_Title");	
	
        /// <summary>
		/// Auto select next item
		/// </summary>
		public static string SettingsAutoSelectNextItem_Title => Resources.GetTranslatedString(@"SettingsAutoSelectNextItem_Title");	
	
        /// <summary>
		/// Select the next item after you delete or move a mail.
		/// </summary>
		public static string SettingsAutoSelectNextItem_Description => Resources.GetTranslatedString(@"SettingsAutoSelectNextItem_Description");	
	
        /// <summary>
		/// Create your own custom theme with custom wallpaper and accent color.
		/// </summary>
		public static string SettingsCustomTheme_Description => Resources.GetTranslatedString(@"SettingsCustomTheme_Description");	
	
        /// <summary>
		/// Custom Theme
		/// </summary>
		public static string SettingsCustomTheme_Title => Resources.GetTranslatedString(@"SettingsCustomTheme_Title");	
	
        /// <summary>
		/// Configure System Folders
		/// </summary>
		public static string SettingsConfigureSpecialFolders_Title => Resources.GetTranslatedString(@"SettingsConfigureSpecialFolders_Title");	
	
        /// <summary>
		/// Set folders with special functions. Folders such as Archive, Inbox, and Drafts are essential for Wino to function properly.
		/// </summary>
		public static string SettingsConfigureSpecialFolders_Description => Resources.GetTranslatedString(@"SettingsConfigureSpecialFolders_Description");	
	
        /// <summary>
		/// Configure
		/// </summary>
		public static string SettingConfigureSpecialFolders_Button => Resources.GetTranslatedString(@"SettingConfigureSpecialFolders_Button");	
	
        /// <summary>
		/// Failed to setup system folders
		/// </summary>
		public static string Error_FailedToSetupSystemFolders_Title => Resources.GetTranslatedString(@"Error_FailedToSetupSystemFolders_Title");	
	
        /// <summary>
		/// Delete all e-mails and credentials associated with this account.
		/// </summary>
		public static string SettingsDeleteAccount_Description => Resources.GetTranslatedString(@"SettingsDeleteAccount_Description");	
	
        /// <summary>
		/// Delete this account
		/// </summary>
		public static string SettingsDeleteAccount_Title => Resources.GetTranslatedString(@"SettingsDeleteAccount_Title");	
	
        /// <summary>
		/// Should Wino ask you for comfirmation every time you try to permanently delete a mail using Shift + Del keys?
		/// </summary>
		public static string SettingsDeleteProtection_Description => Resources.GetTranslatedString(@"SettingsDeleteProtection_Description");	
	
        /// <summary>
		/// Permanent Delete Protection
		/// </summary>
		public static string SettingsDeleteProtection_Title => Resources.GetTranslatedString(@"SettingsDeleteProtection_Title");	
	
        /// <summary>
		/// For developers
		/// </summary>
		public static string SettingsDiagnostics_Description => Resources.GetTranslatedString(@"SettingsDiagnostics_Description");	
	
        /// <summary>
		/// Diagnostics
		/// </summary>
		public static string SettingsDiagnostics_Title => Resources.GetTranslatedString(@"SettingsDiagnostics_Title");	
	
        /// <summary>
		/// Get regular development updates, join roadmap discussions and provide feedback.
		/// </summary>
		public static string SettingsDiscord_Description => Resources.GetTranslatedString(@"SettingsDiscord_Description");	
	
        /// <summary>
		/// Discord Channel
		/// </summary>
		public static string SettingsDiscord_Title => Resources.GetTranslatedString(@"SettingsDiscord_Title");	
	
        /// <summary>
		/// Element theme selection is disabled when application theme is selected other than Default.
		/// </summary>
		public static string SettingsElementThemeSelectionDisabled => Resources.GetTranslatedString(@"SettingsElementThemeSelectionDisabled");	
	
        /// <summary>
		/// Select a Windows theme for Wino
		/// </summary>
		public static string SettingsElementTheme_Description => Resources.GetTranslatedString(@"SettingsElementTheme_Description");	
	
        /// <summary>
		/// Element Theme
		/// </summary>
		public static string SettingsElementTheme_Title => Resources.GetTranslatedString(@"SettingsElementTheme_Title");	
	
        /// <summary>
		/// Enable hover actions
		/// </summary>
		public static string SettingsEnableHoverActions_Title => Resources.GetTranslatedString(@"SettingsEnableHoverActions_Title");	
	
        /// <summary>
		/// Enable this to provide details about IMAP connectivity issuses you had during IMAP server setup.
		/// </summary>
		public static string SettingsEnableIMAPLogs_Description => Resources.GetTranslatedString(@"SettingsEnableIMAPLogs_Description");	
	
        /// <summary>
		/// Enable IMAP Protocol Logs
		/// </summary>
		public static string SettingsEnableIMAPLogs_Title => Resources.GetTranslatedString(@"SettingsEnableIMAPLogs_Title");	
	
        /// <summary>
		/// I might need logs for crashes to diagnose issues you have opened in GitHub. None of the logs will expose your credentials or sensetive information to public.
		/// </summary>
		public static string SettingsEnableLogs_Description => Resources.GetTranslatedString(@"SettingsEnableLogs_Description");	
	
        /// <summary>
		/// Enable Logs
		/// </summary>
		public static string SettingsEnableLogs_Title => Resources.GetTranslatedString(@"SettingsEnableLogs_Title");	
	
        /// <summary>
		/// Enable Signature
		/// </summary>
		public static string SettingsEnableSignature => Resources.GetTranslatedString(@"SettingsEnableSignature");	
	
        /// <summary>
		/// Set whether Wino should expand this account's folders on startup.
		/// </summary>
		public static string SettingsExpandOnStartup_Description => Resources.GetTranslatedString(@"SettingsExpandOnStartup_Description");	
	
        /// <summary>
		/// Expand Menu on Startup
		/// </summary>
		public static string SettingsExpandOnStartup_Title => Resources.GetTranslatedString(@"SettingsExpandOnStartup_Title");	
	
        /// <summary>
		/// Manage external content settings when rendering mails.
		/// </summary>
		public static string SettingsExternalContent_Description => Resources.GetTranslatedString(@"SettingsExternalContent_Description");	
	
        /// <summary>
		/// External Content
		/// </summary>
		public static string SettingsExternalContent_Title => Resources.GetTranslatedString(@"SettingsExternalContent_Title");	
	
        /// <summary>
		/// Set whether Inbox should be split into two as Focused - Other.
		/// </summary>
		public static string SettingsFocusedInbox_Description => Resources.GetTranslatedString(@"SettingsFocusedInbox_Description");	
	
        /// <summary>
		/// Focused Inbox
		/// </summary>
		public static string SettingsFocusedInbox_Title => Resources.GetTranslatedString(@"SettingsFocusedInbox_Title");	
	
        /// <summary>
		/// Enable or disable specific folders for synchronization.
		/// </summary>
		public static string SettingsFolderSync_Description => Resources.GetTranslatedString(@"SettingsFolderSync_Description");	
	
        /// <summary>
		/// Folder Synchronization
		/// </summary>
		public static string SettingsFolderSync_Title => Resources.GetTranslatedString(@"SettingsFolderSync_Title");	
	
        /// <summary>
		/// Folder Configuration
		/// </summary>
		public static string SettingsFolderOptions_Title => Resources.GetTranslatedString(@"SettingsFolderOptions_Title");	
	
        /// <summary>
		/// Change individual folder settings like enable/disable sync or show/hide unread badge.
		/// </summary>
		public static string SettingsFolderOptions_Description => Resources.GetTranslatedString(@"SettingsFolderOptions_Description");	
	
        /// <summary>
		/// Center Action
		/// </summary>
		public static string SettingsHoverActionCenter => Resources.GetTranslatedString(@"SettingsHoverActionCenter");	
	
        /// <summary>
		/// Left Action
		/// </summary>
		public static string SettingsHoverActionLeft => Resources.GetTranslatedString(@"SettingsHoverActionLeft");	
	
        /// <summary>
		/// Right Action
		/// </summary>
		public static string SettingsHoverActionRight => Resources.GetTranslatedString(@"SettingsHoverActionRight");	
	
        /// <summary>
		/// Select 3 actions to show up when you hover over the mails with cursor.
		/// </summary>
		public static string SettingsHoverActions_Description => Resources.GetTranslatedString(@"SettingsHoverActions_Description");	
	
        /// <summary>
		/// Hover Actions
		/// </summary>
		public static string SettingsHoverActions_Title => Resources.GetTranslatedString(@"SettingsHoverActions_Title");	
	
        /// <summary>
		/// Change display language for Wino.
		/// </summary>
		public static string SettingsLanguage_Description => Resources.GetTranslatedString(@"SettingsLanguage_Description");	
	
        /// <summary>
		/// Display Language
		/// </summary>
		public static string SettingsLanguage_Title => Resources.GetTranslatedString(@"SettingsLanguage_Title");	
	
        /// <summary>
		/// Language & Time
		/// </summary>
		public static string SettingsLanguageTime_Title => Resources.GetTranslatedString(@"SettingsLanguageTime_Title");	
	
        /// <summary>
		/// Wino display language, preferred time format.
		/// </summary>
		public static string SettingsLanguageTime_Description => Resources.GetTranslatedString(@"SettingsLanguageTime_Description");	
	
        /// <summary>
		/// Categories
		/// </summary>
		public static string CategoriesFolderNameOverride => Resources.GetTranslatedString(@"CategoriesFolderNameOverride");	
	
        /// <summary>
		/// More
		/// </summary>
		public static string MoreFolderNameOverride => Resources.GetTranslatedString(@"MoreFolderNameOverride");	
	
        /// <summary>
		/// Settings
		/// </summary>
		public static string SettingsOptions_Title => Resources.GetTranslatedString(@"SettingsOptions_Title");	
	
        /// <summary>
		/// Merge multiple accounts into one. See mails from one Inbox together.
		/// </summary>
		public static string SettingsLinkAccounts_Description => Resources.GetTranslatedString(@"SettingsLinkAccounts_Description");	
	
        /// <summary>
		/// Create Linked Accounts
		/// </summary>
		public static string SettingsLinkAccounts_Title => Resources.GetTranslatedString(@"SettingsLinkAccounts_Title");	
	
        /// <summary>
		/// Modify the current link with the new accounts.
		/// </summary>
		public static string SettingsLinkedAccountsSave_Description => Resources.GetTranslatedString(@"SettingsLinkedAccountsSave_Description");	
	
        /// <summary>
		/// Save Changes
		/// </summary>
		public static string SettingsLinkedAccountsSave_Title => Resources.GetTranslatedString(@"SettingsLinkedAccountsSave_Title");	
	
        /// <summary>
		/// Load images automatically
		/// </summary>
		public static string SettingsLoadImages_Title => Resources.GetTranslatedString(@"SettingsLoadImages_Title");	
	
        /// <summary>
		/// Load styles automatically
		/// </summary>
		public static string SettingsLoadStyles_Title => Resources.GetTranslatedString(@"SettingsLoadStyles_Title");	
	
        /// <summary>
		/// Adjust the spacing for listing mails.
		/// </summary>
		public static string SettingsMailSpacing_Description => Resources.GetTranslatedString(@"SettingsMailSpacing_Description");	
	
        /// <summary>
		/// Mail Spacing
		/// </summary>
		public static string SettingsMailSpacing_Title => Resources.GetTranslatedString(@"SettingsMailSpacing_Title");	
	
        /// <summary>
		/// Create Nested Folders
		/// </summary>
		public static string SettingsFolderMenuStyle_Title => Resources.GetTranslatedString(@"SettingsFolderMenuStyle_Title");	
	
        /// <summary>
		/// Change whether account folders should be nested inside an account menu item or not. Toggle this off if you like the old menu system in Windows Mail
		/// </summary>
		public static string SettingsFolderMenuStyle_Description => Resources.GetTranslatedString(@"SettingsFolderMenuStyle_Description");	
	
        /// <summary>
		/// Notifications, signatures, synchronization and other settings per account.
		/// </summary>
		public static string SettingsManageAccountSettings_Description => Resources.GetTranslatedString(@"SettingsManageAccountSettings_Description");	
	
        /// <summary>
		/// Manage Account Settings
		/// </summary>
		public static string SettingsManageAccountSettings_Title => Resources.GetTranslatedString(@"SettingsManageAccountSettings_Title");	
	
        /// <summary>
		/// Move items to add new link or remove existing link.
		/// </summary>
		public static string SettingsManageLink_Description => Resources.GetTranslatedString(@"SettingsManageLink_Description");	
	
        /// <summary>
		/// Manage Link
		/// </summary>
		public static string SettingsManageLink_Title => Resources.GetTranslatedString(@"SettingsManageLink_Title");	
	
        /// <summary>
		/// Change what should happen to the selected item.
		/// </summary>
		public static string SettingsMarkAsRead_Description => Resources.GetTranslatedString(@"SettingsMarkAsRead_Description");	
	
        /// <summary>
		/// Don't automatically mark item as read
		/// </summary>
		public static string SettingsMarkAsRead_DontChange => Resources.GetTranslatedString(@"SettingsMarkAsRead_DontChange");	
	
        /// <summary>
		/// Seconds to wait: 
		/// </summary>
		public static string SettingsMarkAsRead_SecondsToWait => Resources.GetTranslatedString(@"SettingsMarkAsRead_SecondsToWait");	
	
        /// <summary>
		/// When viewed in the reading pane
		/// </summary>
		public static string SettingsMarkAsRead_Timer => Resources.GetTranslatedString(@"SettingsMarkAsRead_Timer");	
	
        /// <summary>
		/// Mark item as read
		/// </summary>
		public static string SettingsMarkAsRead_Title => Resources.GetTranslatedString(@"SettingsMarkAsRead_Title");	
	
        /// <summary>
		/// When selected
		/// </summary>
		public static string SettingsMarkAsRead_WhenSelected => Resources.GetTranslatedString(@"SettingsMarkAsRead_WhenSelected");	
	
        /// <summary>
		/// Change how your messages should be organized in mail list.
		/// </summary>
		public static string SettingsMessageList_Description => Resources.GetTranslatedString(@"SettingsMessageList_Description");	
	
        /// <summary>
		/// Message List
		/// </summary>
		public static string SettingsMessageList_Title => Resources.GetTranslatedString(@"SettingsMessageList_Title");	
	
        /// <summary>
		/// You didn't setup any accounts yet.
		/// </summary>
		public static string SettingsNoAccountSetupMessage => Resources.GetTranslatedString(@"SettingsNoAccountSetupMessage");	
	
        /// <summary>
		/// Turn on or off notifications for this account.
		/// </summary>
		public static string SettingsNotifications_Description => Resources.GetTranslatedString(@"SettingsNotifications_Description");	
	
        /// <summary>
		/// Notifications
		/// </summary>
		public static string SettingsNotifications_Title => Resources.GetTranslatedString(@"SettingsNotifications_Title");	
	
        /// <summary>
		/// Change the width of the mail list.
		/// </summary>
		public static string SettingsPaneLength_Description => Resources.GetTranslatedString(@"SettingsPaneLength_Description");	
	
        /// <summary>
		/// Mail List Pane Length
		/// </summary>
		public static string SettingsPaneLength_Title => Resources.GetTranslatedString(@"SettingsPaneLength_Title");	
	
        /// <summary>
		/// Show much more love ❤️ All donations are appreciated.
		/// </summary>
		public static string SettingsPaypal_Description => Resources.GetTranslatedString(@"SettingsPaypal_Description");	
	
        /// <summary>
		/// Donate via PayPal
		/// </summary>
		public static string SettingsPaypal_Title => Resources.GetTranslatedString(@"SettingsPaypal_Title");	
	
        /// <summary>
		/// Compact Mode
		/// </summary>
		public static string SettingsPersonalizationMailDisplayCompactMode => Resources.GetTranslatedString(@"SettingsPersonalizationMailDisplayCompactMode");	
	
        /// <summary>
		/// Medium Mode
		/// </summary>
		public static string SettingsPersonalizationMailDisplayMediumMode => Resources.GetTranslatedString(@"SettingsPersonalizationMailDisplayMediumMode");	
	
        /// <summary>
		/// Spacious Mode
		/// </summary>
		public static string SettingsPersonalizationMailDisplaySpaciousMode => Resources.GetTranslatedString(@"SettingsPersonalizationMailDisplaySpaciousMode");	
	
        /// <summary>
		/// Change appearance of Wino as you like.
		/// </summary>
		public static string SettingsPersonalization_Description => Resources.GetTranslatedString(@"SettingsPersonalization_Description");	
	
        /// <summary>
		/// Personalization
		/// </summary>
		public static string SettingsPersonalization_Title => Resources.GetTranslatedString(@"SettingsPersonalization_Title");	
	
        /// <summary>
		/// Review privacy policy.
		/// </summary>
		public static string SettingsPrivacyPolicy_Description => Resources.GetTranslatedString(@"SettingsPrivacyPolicy_Description");	
	
        /// <summary>
		/// Privacy Policy
		/// </summary>
		public static string SettingsPrivacyPolicy_Title => Resources.GetTranslatedString(@"SettingsPrivacyPolicy_Title");	
	
        /// <summary>
		/// Mail rendering options.
		/// </summary>
		public static string SettingsReadingPane_Description => Resources.GetTranslatedString(@"SettingsReadingPane_Description");	
	
        /// <summary>
		/// Reading Pane
		/// </summary>
		public static string SettingsReadingPane_Title => Resources.GetTranslatedString(@"SettingsReadingPane_Title");	
	
        /// <summary>
		/// Default Reader Font
		/// </summary>
		public static string SettingsReaderFont_Title => Resources.GetTranslatedString(@"SettingsReaderFont_Title");	
	
        /// <summary>
		/// Change the default font family and font size for reading mails.
		/// </summary>
		public static string SettingsReaderFontFamily_Description => Resources.GetTranslatedString(@"SettingsReaderFontFamily_Description");	
	
        /// <summary>
		/// Font Family
		/// </summary>
		public static string SettingsFontFamily_Title => Resources.GetTranslatedString(@"SettingsFontFamily_Title");	
	
        /// <summary>
		/// Font Size
		/// </summary>
		public static string SettingsFontSize_Title => Resources.GetTranslatedString(@"SettingsFontSize_Title");	
	
        /// <summary>
		/// Preview
		/// </summary>
		public static string SettingsFontPreview_Title => Resources.GetTranslatedString(@"SettingsFontPreview_Title");	
	
        /// <summary>
		/// Default Composer Font
		/// </summary>
		public static string SettingsComposerFont_Title => Resources.GetTranslatedString(@"SettingsComposerFont_Title");	
	
        /// <summary>
		/// Change the default font family and font size for composing mails.
		/// </summary>
		public static string SettingsComposerFontFamily_Description => Resources.GetTranslatedString(@"SettingsComposerFontFamily_Description");	
	
        /// <summary>
		/// Change the display name of the linked accounts.
		/// </summary>
		public static string SettingsRenameMergeAccount_Description => Resources.GetTranslatedString(@"SettingsRenameMergeAccount_Description");	
	
        /// <summary>
		/// Rename
		/// </summary>
		public static string SettingsRenameMergeAccount_Title => Resources.GetTranslatedString(@"SettingsRenameMergeAccount_Title");	
	
        /// <summary>
		/// This will allow you to click on the headers in messages list and go to specific date
		/// </summary>
		public static string SettingsSemanticZoom_Description => Resources.GetTranslatedString(@"SettingsSemanticZoom_Description");	
	
        /// <summary>
		/// Semantic Zoom for Date Headers
		/// </summary>
		public static string SettingsSemanticZoom_Title => Resources.GetTranslatedString(@"SettingsSemanticZoom_Title");	
	
        /// <summary>
		/// Hide/show thepreview text.
		/// </summary>
		public static string SettingsShowPreviewText_Description => Resources.GetTranslatedString(@"SettingsShowPreviewText_Description");	
	
        /// <summary>
		/// Show Preview Text
		/// </summary>
		public static string SettingsShowPreviewText_Title => Resources.GetTranslatedString(@"SettingsShowPreviewText_Title");	
	
        /// <summary>
		/// Hide/show the thumbnail sender pictures.
		/// </summary>
		public static string SettingsShowSenderPictures_Description => Resources.GetTranslatedString(@"SettingsShowSenderPictures_Description");	
	
        /// <summary>
		/// Show Sender Avatars
		/// </summary>
		public static string SettingsShowSenderPictures_Title => Resources.GetTranslatedString(@"SettingsShowSenderPictures_Title");	
	
        /// <summary>
		/// Display Clock Format in 24 Hours
		/// </summary>
		public static string SettingsPrefer24HourClock_Title => Resources.GetTranslatedString(@"SettingsPrefer24HourClock_Title");	
	
        /// <summary>
		/// Mail recieve times will be displayed in 24 hour format instead of 12 (AM/PM)
		/// </summary>
		public static string SettingsPrefer24HourClock_Description => Resources.GetTranslatedString(@"SettingsPrefer24HourClock_Description");	
	
        /// <summary>
		/// Edit or remove account signature
		/// </summary>
		public static string SettingsSignature_Description => Resources.GetTranslatedString(@"SettingsSignature_Description");	
	
        /// <summary>
		/// Signature
		/// </summary>
		public static string SettingsSignature_Title => Resources.GetTranslatedString(@"SettingsSignature_Title");	
	
        /// <summary>
		/// Primary account item to load Inbox at startup.
		/// </summary>
		public static string SettingsStartupItem_Description => Resources.GetTranslatedString(@"SettingsStartupItem_Description");	
	
        /// <summary>
		/// Startup Item
		/// </summary>
		public static string SettingsStartupItem_Title => Resources.GetTranslatedString(@"SettingsStartupItem_Title");	
	
        /// <summary>
		/// Show some love ❤️
		/// </summary>
		public static string SettingsStore_Description => Resources.GetTranslatedString(@"SettingsStore_Description");	
	
        /// <summary>
		/// Rate in Store
		/// </summary>
		public static string SettingsStore_Title => Resources.GetTranslatedString(@"SettingsStore_Title");	
	
        /// <summary>
		/// Organize messages into conversation threads.
		/// </summary>
		public static string SettingsThreads_Description => Resources.GetTranslatedString(@"SettingsThreads_Description");	
	
        /// <summary>
		/// Conversation Threading
		/// </summary>
		public static string SettingsThreads_Title => Resources.GetTranslatedString(@"SettingsThreads_Title");	
	
        /// <summary>
		/// Remove the link between accounts. This will not delete your accounts.
		/// </summary>
		public static string SettingsUnlinkAccounts_Description => Resources.GetTranslatedString(@"SettingsUnlinkAccounts_Description");	
	
        /// <summary>
		/// Unlink Accounts
		/// </summary>
		public static string SettingsUnlinkAccounts_Title => Resources.GetTranslatedString(@"SettingsUnlinkAccounts_Title");	
	
        /// <summary>
		/// by date
		/// </summary>
		public static string SortingOption_Date => Resources.GetTranslatedString(@"SortingOption_Date");	
	
        /// <summary>
		/// by name
		/// </summary>
		public static string SortingOption_Name => Resources.GetTranslatedString(@"SortingOption_Name");	
	
        /// <summary>
		/// All feedbacks are appreciated and they will make much Wino better in the future. Would you like to rate Wino in Microsoft Store?
		/// </summary>
		public static string StoreRatingDialog_MessageFirstLine => Resources.GetTranslatedString(@"StoreRatingDialog_MessageFirstLine");	
	
        /// <summary>
		/// Would you like to rate Wino Mail in Microsoft Store?
		/// </summary>
		public static string StoreRatingDialog_MessageSecondLine => Resources.GetTranslatedString(@"StoreRatingDialog_MessageSecondLine");	
	
        /// <summary>
		/// Enjoying Wino?
		/// </summary>
		public static string StoreRatingDialog_Title => Resources.GetTranslatedString(@"StoreRatingDialog_Title");	
	
        /// <summary>
		/// Archived messages will be moved to here.
		/// </summary>
		public static string SystemFolderConfigDialog_ArchiveFolderDescription => Resources.GetTranslatedString(@"SystemFolderConfigDialog_ArchiveFolderDescription");	
	
        /// <summary>
		/// Archive Folder
		/// </summary>
		public static string SystemFolderConfigDialog_ArchiveFolderHeader => Resources.GetTranslatedString(@"SystemFolderConfigDialog_ArchiveFolderHeader");	
	
        /// <summary>
		/// Deleted messages will be moved to here.
		/// </summary>
		public static string SystemFolderConfigDialog_DeletedFolderDescription => Resources.GetTranslatedString(@"SystemFolderConfigDialog_DeletedFolderDescription");	
	
        /// <summary>
		/// Deleted Folder
		/// </summary>
		public static string SystemFolderConfigDialog_DeletedFolderHeader => Resources.GetTranslatedString(@"SystemFolderConfigDialog_DeletedFolderHeader");	
	
        /// <summary>
		/// New mails/replies will be crafted in here.
		/// </summary>
		public static string SystemFolderConfigDialog_DraftFolderDescription => Resources.GetTranslatedString(@"SystemFolderConfigDialog_DraftFolderDescription");	
	
        /// <summary>
		/// Draft Folder
		/// </summary>
		public static string SystemFolderConfigDialog_DraftFolderHeader => Resources.GetTranslatedString(@"SystemFolderConfigDialog_DraftFolderHeader");	
	
        /// <summary>
		/// All spam/junk mails will be here.
		/// </summary>
		public static string SystemFolderConfigDialog_JunkFolderDescription => Resources.GetTranslatedString(@"SystemFolderConfigDialog_JunkFolderDescription");	
	
        /// <summary>
		/// Junk/Spam Folder
		/// </summary>
		public static string SystemFolderConfigDialog_JunkFolderHeader => Resources.GetTranslatedString(@"SystemFolderConfigDialog_JunkFolderHeader");	
	
        /// <summary>
		/// This IMAP server doesn't support SPECIAL-USE extension hence Wino couldn't setup the system folders properly.
		/// </summary>
		public static string SystemFolderConfigDialog_MessageFirstLine => Resources.GetTranslatedString(@"SystemFolderConfigDialog_MessageFirstLine");	
	
        /// <summary>
		/// Please select the appropriate folders for specific functionalities.
		/// </summary>
		public static string SystemFolderConfigDialog_MessageSecondLine => Resources.GetTranslatedString(@"SystemFolderConfigDialog_MessageSecondLine");	
	
        /// <summary>
		/// Folder that sent messages will be stored.
		/// </summary>
		public static string SystemFolderConfigDialog_SentFolderDescription => Resources.GetTranslatedString(@"SystemFolderConfigDialog_SentFolderDescription");	
	
        /// <summary>
		/// Sent Folder
		/// </summary>
		public static string SystemFolderConfigDialog_SentFolderHeader => Resources.GetTranslatedString(@"SystemFolderConfigDialog_SentFolderHeader");	
	
        /// <summary>
		/// Configure System Folders
		/// </summary>
		public static string SystemFolderConfigDialog_Title => Resources.GetTranslatedString(@"SystemFolderConfigDialog_Title");	
	
        /// <summary>
		/// You can't assign Inbox folder to any other system folder.
		/// </summary>
		public static string SystemFolderConfigDialogValidation_InboxSelected => Resources.GetTranslatedString(@"SystemFolderConfigDialogValidation_InboxSelected");	
	
        /// <summary>
		/// Some of the system folders are used more than once in the configuration.
		/// </summary>
		public static string SystemFolderConfigDialogValidation_DuplicateSystemFolders => Resources.GetTranslatedString(@"SystemFolderConfigDialogValidation_DuplicateSystemFolders");	
	
        /// <summary>
		/// System Folders Setup
		/// </summary>
		public static string SystemFolderConfigSetupSuccess_Title => Resources.GetTranslatedString(@"SystemFolderConfigSetupSuccess_Title");	
	
        /// <summary>
		/// System folders are successfully configured.
		/// </summary>
		public static string SystemFolderConfigSetupSuccess_Message => Resources.GetTranslatedString(@"SystemFolderConfigSetupSuccess_Message");	
	
        /// <summary>
		/// Testing server connection...
		/// </summary>
		public static string TestingImapConnectionMessage => Resources.GetTranslatedString(@"TestingImapConnectionMessage");	
	
        /// <summary>
		/// Today
		/// </summary>
		public static string Today => Resources.GetTranslatedString(@"Today");	
	
        /// <summary>
		/// unknown address
		/// </summary>
		public static string UnknownAddress => Resources.GetTranslatedString(@"UnknownAddress");	
	
        /// <summary>
		/// Unknown Date
		/// </summary>
		public static string UnknownDateHeader => Resources.GetTranslatedString(@"UnknownDateHeader");	
	
        /// <summary>
		/// unknown Mail Group Address
		/// </summary>
		public static string UnknownGroupAddress => Resources.GetTranslatedString(@"UnknownGroupAddress");	
	
        /// <summary>
		/// Unknown Sender
		/// </summary>
		public static string UnknownSender => Resources.GetTranslatedString(@"UnknownSender");	
	
        /// <summary>
		/// Unsubscribe
		/// </summary>
		public static string Unsubscribe => Resources.GetTranslatedString(@"Unsubscribe");	
	
        /// <summary>
		/// View Details
		/// </summary>
		public static string ViewContactDetails => Resources.GetTranslatedString(@"ViewContactDetails");	
	
        /// <summary>
		/// Wino offers 3 accounts to start with for free. If you need more than 3 accounts, please upgrade
		/// </summary>
		public static string WinoUpgradeDescription => Resources.GetTranslatedString(@"WinoUpgradeDescription");	
	
        /// <summary>
		/// Upgrade to Unlimited Accounts
		/// </summary>
		public static string WinoUpgradeMessage => Resources.GetTranslatedString(@"WinoUpgradeMessage");	
	
        /// <summary>
		/// {0} out of {1} free accounts used.
		/// </summary>
		public static string WinoUpgradeRemainingAccountsMessage => Resources.GetTranslatedString(@"WinoUpgradeRemainingAccountsMessage");	
	
        /// <summary>
		/// Yesterday
		/// </summary>
		public static string Yesterday => Resources.GetTranslatedString(@"Yesterday");	
	}
}
