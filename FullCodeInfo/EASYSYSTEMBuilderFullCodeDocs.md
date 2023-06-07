<a name='assembly'></a>
# GlobalNET

## Contents

- [AccessRoleListPage](#T-GlobalNET-Pages-AccessRoleListPage 'GlobalNET.Pages.AccessRoleListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-AccessRoleListPage-InitializeComponent 'GlobalNET.Pages.AccessRoleListPage.InitializeComponent')
- [AddressListPage](#T-GlobalNET-Pages-AddressListPage 'GlobalNET.Pages.AddressListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-AddressListPage-InitializeComponent 'GlobalNET.Pages.AddressListPage.InitializeComponent')
- [ApiUrls](#T-GlobalNET-Api-ApiUrls 'GlobalNET.Api.ApiUrls')
- [App](#T-GlobalNET-App 'GlobalNET.App')
  - [#ctor()](#M-GlobalNET-App-#ctor 'GlobalNET.App.#ctor')
  - [SystemRuntimeData](#F-GlobalNET-App-SystemRuntimeData 'GlobalNET.App.SystemRuntimeData')
  - [TiltReceiptDoc](#F-GlobalNET-App-TiltReceiptDoc 'GlobalNET.App.TiltReceiptDoc')
  - [AppQuitRequest(silent)](#M-GlobalNET-App-AppQuitRequest-System-Boolean- 'GlobalNET.App.AppQuitRequest(System.Boolean)')
  - [AppRestart()](#M-GlobalNET-App-AppRestart 'GlobalNET.App.AppRestart')
  - [ApplicationLogging(ex,customMessage)](#M-GlobalNET-App-ApplicationLogging-System-Exception,System-String- 'GlobalNET.App.ApplicationLogging(System.Exception,System.String)')
  - [ApplicationQuit(sender,e)](#M-GlobalNET-App-ApplicationQuit 'GlobalNET.App.ApplicationQuit')
  - [CurrentDomain_FirstChanceException(sender,e)](#M-GlobalNET-App-CurrentDomain_FirstChanceException-System-Object,System-Runtime-ExceptionServices-FirstChanceExceptionEventArgs- 'GlobalNET.App.CurrentDomain_FirstChanceException(System.Object,System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-App-InitializeComponent 'GlobalNET.App.InitializeComponent')
  - [Main()](#M-GlobalNET-App-Main 'GlobalNET.App.Main')
  - [OnStartup(e)](#M-GlobalNET-App-OnStartup-System-Windows-StartupEventArgs- 'GlobalNET.App.OnStartup(System.Windows.StartupEventArgs)')
  - [RootAppKeyDownController(sender,e)](#M-GlobalNET-App-RootAppKeyDownController-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.App.RootAppKeyDownController(System.Object,System.Windows.Input.KeyEventArgs)')
- [AppVersion](#T-GlobalNET-Classes-AppVersion 'GlobalNET.Classes.AppVersion')
- [AttachmentListPage](#T-GlobalNET-Pages-AttachmentListPage 'GlobalNET.Pages.AttachmentListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-AttachmentListPage-InitializeComponent 'GlobalNET.Pages.AttachmentListPage.InitializeComponent')
- [Authentification](#T-GlobalNET-GlobalClasses-Authentification 'GlobalNET.GlobalClasses.Authentification')
- [BranchListPage](#T-GlobalNET-Pages-BranchListPage 'GlobalNET.Pages.BranchListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-BranchListPage-InitializeComponent 'GlobalNET.Pages.BranchListPage.InitializeComponent')
- [CalendarPage](#T-GlobalNET-Pages-CalendarPage 'GlobalNET.Pages.CalendarPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-CalendarPage-InitializeComponent 'GlobalNET.Pages.CalendarPage.InitializeComponent')
- [ClientSettingsPage](#T-GlobalNET-Pages-ClientSettingsPage 'GlobalNET.Pages.ClientSettingsPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ClientSettingsPage-InitializeComponent 'GlobalNET.Pages.ClientSettingsPage.InitializeComponent')
- [Config](#T-GlobalNET-Classes-Config 'GlobalNET.Classes.Config')
- [CrashReporterSettings](#T-GlobalNET-SystemConfiguration-CrashReporterSettings 'GlobalNET.SystemConfiguration.CrashReporterSettings')
  - [_ReportCrash](#F-GlobalNET-SystemConfiguration-CrashReporterSettings-_ReportCrash 'GlobalNET.SystemConfiguration.CrashReporterSettings._ReportCrash')
- [CreditNoteListPage](#T-GlobalNET-Pages-CreditNoteListPage 'GlobalNET.Pages.CreditNoteListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-CreditNoteListPage-InitializeComponent 'GlobalNET.Pages.CreditNoteListPage.InitializeComponent')
- [CurrencyListPage](#T-GlobalNET-Pages-CurrencyListPage 'GlobalNET.Pages.CurrencyListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-CurrencyListPage-InitializeComponent 'GlobalNET.Pages.CurrencyListPage.InitializeComponent')
- [DBOperations](#T-GlobalNET-GlobalOperations-DBOperations 'GlobalNET.GlobalOperations.DBOperations')
  - [DBTranslation(systemName,notCreateNew,comaList,lang)](#M-GlobalNET-GlobalOperations-DBOperations-DBTranslation-System-String,System-Boolean,System-Boolean,System-String- 'GlobalNET.GlobalOperations.DBOperations.DBTranslation(System.String,System.Boolean,System.Boolean,System.String)')
  - [LoadOrRefreshUserData()](#M-GlobalNET-GlobalOperations-DBOperations-LoadOrRefreshUserData 'GlobalNET.GlobalOperations.DBOperations.LoadOrRefreshUserData')
  - [LoadStartupDBData()](#M-GlobalNET-GlobalOperations-DBOperations-LoadStartupDBData 'GlobalNET.GlobalOperations.DBOperations.LoadStartupDBData')
  - [SaveSystemFailMessage(message)](#M-GlobalNET-GlobalOperations-DBOperations-SaveSystemFailMessage-System-String,System-String- 'GlobalNET.GlobalOperations.DBOperations.SaveSystemFailMessage(System.String,System.String)')
  - [SetNonUserDataOnSuccessStartUp()](#M-GlobalNET-GlobalOperations-DBOperations-SetNonUserDataOnSuccessStartUp 'GlobalNET.GlobalOperations.DBOperations.SetNonUserDataOnSuccessStartUp')
- [DBResultMessage](#T-GlobalNET-Api-DBResultMessage 'GlobalNET.Api.DBResultMessage')
- [DataOperations](#T-GlobalNET-GlobalOperations-DataOperations 'GlobalNET.GlobalOperations.DataOperations')
  - [GetTranslatedApiList(listOnly,omitApiList)](#M-GlobalNET-GlobalOperations-DataOperations-GetTranslatedApiList-System-Boolean,System-Collections-Generic-List{System-String}- 'GlobalNET.GlobalOperations.DataOperations.GetTranslatedApiList(System.Boolean,System.Collections.Generic.List{System.String})')
  - [NullSetInExtensionFields\`\`1()](#M-GlobalNET-GlobalOperations-DataOperations-NullSetInExtensionFields``1-``0@- 'GlobalNET.GlobalOperations.DataOperations.NullSetInExtensionFields``1(``0@)')
  - [ParameterCheck(parameterName)](#M-GlobalNET-GlobalOperations-DataOperations-ParameterCheck-System-String- 'GlobalNET.GlobalOperations.DataOperations.ParameterCheck(System.String)')
- [DataViewSupport](#T-GlobalNET-Classes-DataViewSupport 'GlobalNET.Classes.DataViewSupport')
- [DocumentAdviceListPage](#T-GlobalNET-Pages-DocumentAdviceListPage 'GlobalNET.Pages.DocumentAdviceListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-DocumentAdviceListPage-InitializeComponent 'GlobalNET.Pages.DocumentAdviceListPage.InitializeComponent')
- [DocumentItemList](#T-GlobalNET-GlobalClasses-DocumentItemList 'GlobalNET.GlobalClasses.DocumentItemList')
- [DocumentTypeListPage](#T-GlobalNET-Pages-DocumentTypeListPage 'GlobalNET.Pages.DocumentTypeListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-DocumentTypeListPage-InitializeComponent 'GlobalNET.Pages.DocumentTypeListPage.InitializeComponent')
- [DocumentationPage](#T-GlobalNET-Pages-DocumentationPage 'GlobalNET.Pages.DocumentationPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-DocumentationPage-InitializeComponent 'GlobalNET.Pages.DocumentationPage.InitializeComponent')
- [ExchangeRateListPage](#T-GlobalNET-Pages-ExchangeRateListPage 'GlobalNET.Pages.ExchangeRateListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ExchangeRateListPage-InitializeComponent 'GlobalNET.Pages.ExchangeRateListPage.InitializeComponent')
- [FileOperations](#T-GlobalNET-GlobalOperations-FileOperations 'GlobalNET.GlobalOperations.FileOperations')
  - [CopyFiles(sourcePath,destinationPath)](#M-GlobalNET-GlobalOperations-FileOperations-CopyFiles-System-String,System-String- 'GlobalNET.GlobalOperations.FileOperations.CopyFiles(System.String,System.String)')
  - [CreateFile(file)](#M-GlobalNET-GlobalOperations-FileOperations-CreateFile-System-String- 'GlobalNET.GlobalOperations.FileOperations.CreateFile(System.String)')
  - [FileDetectEncoding(FileName)](#M-GlobalNET-GlobalOperations-FileOperations-FileDetectEncoding-System-String- 'GlobalNET.GlobalOperations.FileOperations.FileDetectEncoding(System.String)')
  - [LoadSettings()](#M-GlobalNET-GlobalOperations-FileOperations-LoadSettings 'GlobalNET.GlobalOperations.FileOperations.LoadSettings')
  - [SaveSettings()](#M-GlobalNET-GlobalOperations-FileOperations-SaveSettings 'GlobalNET.GlobalOperations.FileOperations.SaveSettings')
  - [VncServerIniFile(path)](#M-GlobalNET-GlobalOperations-FileOperations-VncServerIniFile-System-String- 'GlobalNET.GlobalOperations.FileOperations.VncServerIniFile(System.String)')
- [GeneratedInternalTypeHelper](#T-XamlGeneratedNamespace-GeneratedInternalTypeHelper 'XamlGeneratedNamespace.GeneratedInternalTypeHelper')
  - [AddEventHandler()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.AddEventHandler(System.Reflection.EventInfo,System.Object,System.Delegate)')
  - [CreateDelegate()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateDelegate(System.Type,System.Object,System.String)')
  - [CreateInstance()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateInstance(System.Type,System.Globalization.CultureInfo)')
  - [GetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.GetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Globalization.CultureInfo)')
  - [SetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.SetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Object,System.Globalization.CultureInfo)')
- [GlobalRuntimeMonitor](#T-GlobalNET-GlobalClasses-GlobalRuntimeMonitor 'GlobalNET.GlobalClasses.GlobalRuntimeMonitor')
- [GraphsPage](#T-GlobalNET-Pages-GraphsPage 'GlobalNET.Pages.GraphsPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-GraphsPage-InitializeComponent 'GlobalNET.Pages.GraphsPage.InitializeComponent')
- [GroupListPage](#T-GlobalNET-Pages-GroupListPage 'GlobalNET.Pages.GroupListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-GroupListPage-InitializeComponent 'GlobalNET.Pages.GroupListPage.InitializeComponent')
- [HardwareOperations](#T-GlobalNET-GlobalOperations-HardwareOperations 'GlobalNET.GlobalOperations.HardwareOperations')
  - [ApplicationKeyboardMaping(sender,e)](#M-GlobalNET-GlobalOperations-HardwareOperations-ApplicationKeyboardMaping-System-Windows-Input-KeyEventArgs- 'GlobalNET.GlobalOperations.HardwareOperations.ApplicationKeyboardMaping(System.Windows.Input.KeyEventArgs)')
- [IconMaker](#T-GlobalNET-GlobalGenerators-IconMaker 'GlobalNET.GlobalGenerators.IconMaker')
  - [Icon(color,iconPath)](#M-GlobalNET-GlobalGenerators-IconMaker-Icon-System-Windows-Media-Color,System-String- 'GlobalNET.GlobalGenerators.IconMaker.Icon(System.Windows.Media.Color,System.String)')
- [IgnoredExceptionListPage](#T-GlobalNET-Pages-IgnoredExceptionListPage 'GlobalNET.Pages.IgnoredExceptionListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-IgnoredExceptionListPage-InitializeComponent 'GlobalNET.Pages.IgnoredExceptionListPage.InitializeComponent')
- [ImageGalleryListPage](#T-GlobalNET-Pages-ImageGalleryListPage 'GlobalNET.Pages.ImageGalleryListPage')
  - [ClearGallery()](#M-GlobalNET-Pages-ImageGalleryListPage-ClearGallery 'GlobalNET.Pages.ImageGalleryListPage.ClearGallery')
  - [GrayscaleClick(sender,e)](#M-GlobalNET-Pages-ImageGalleryListPage-GrayscaleClick-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.ImageGalleryListPage.GrayscaleClick(System.Object,System.Windows.RoutedEventArgs)')
  - [ImageChangesCancelClick(sender,e)](#M-GlobalNET-Pages-ImageGalleryListPage-ImageChangesCancelClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.ImageGalleryListPage.ImageChangesCancelClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-Pages-ImageGalleryListPage-InitializeComponent 'GlobalNET.Pages.ImageGalleryListPage.InitializeComponent')
  - [LoadFromServer()](#M-GlobalNET-Pages-ImageGalleryListPage-LoadFromServer-System-Int32- 'GlobalNET.Pages.ImageGalleryListPage.LoadFromServer(System.Int32)')
  - [RefreshViewPhoto(selectedPhotoId)](#M-GlobalNET-Pages-ImageGalleryListPage-RefreshViewPhoto-System-Nullable{System-Int32}- 'GlobalNET.Pages.ImageGalleryListPage.RefreshViewPhoto(System.Nullable{System.Int32})')
  - [SaveImageToServer(onlyThis)](#M-GlobalNET-Pages-ImageGalleryListPage-SaveImageToServer-System-Nullable{System-Int32}- 'GlobalNET.Pages.ImageGalleryListPage.SaveImageToServer(System.Nullable{System.Int32})')
- [IncomingInvoiceListPage](#T-GlobalNET-Pages-IncomingInvoiceListPage 'GlobalNET.Pages.IncomingInvoiceListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-IncomingInvoiceListPage-InitializeComponent 'GlobalNET.Pages.IncomingInvoiceListPage.InitializeComponent')
- [IncomingOrderListPage](#T-GlobalNET-Pages-IncomingOrderListPage 'GlobalNET.Pages.IncomingOrderListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-IncomingOrderListPage-InitializeComponent 'GlobalNET.Pages.IncomingOrderListPage.InitializeComponent')
- [ItemListPage](#T-GlobalNET-Pages-ItemListPage 'GlobalNET.Pages.ItemListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ItemListPage-InitializeComponent 'GlobalNET.Pages.ItemListPage.InitializeComponent')
- [Language](#T-GlobalNET-Classes-Language 'GlobalNET.Classes.Language')
- [LanguageListPage](#T-GlobalNET-Pages-LanguageListPage 'GlobalNET.Pages.LanguageListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LanguageListPage-InitializeComponent 'GlobalNET.Pages.LanguageListPage.InitializeComponent')
- [LicenseActivationFailListPage](#T-GlobalNET-Pages-LicenseActivationFailListPage 'GlobalNET.Pages.LicenseActivationFailListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LicenseActivationFailListPage-InitializeComponent 'GlobalNET.Pages.LicenseActivationFailListPage.InitializeComponent')
- [LicenseAlgorithmListPage](#T-GlobalNET-Pages-LicenseAlgorithmListPage 'GlobalNET.Pages.LicenseAlgorithmListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LicenseAlgorithmListPage-InitializeComponent 'GlobalNET.Pages.LicenseAlgorithmListPage.InitializeComponent')
- [LoginHistoryListPage](#T-GlobalNET-Pages-LoginHistoryListPage 'GlobalNET.Pages.LoginHistoryListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LoginHistoryListPage-InitializeComponent 'GlobalNET.Pages.LoginHistoryListPage.InitializeComponent')
- [MainWindow](#T-GlobalNET-MainWindow 'GlobalNET.MainWindow')
  - [#ctor()](#M-GlobalNET-MainWindow-#ctor 'GlobalNET.MainWindow.#ctor')
  - [_hackyIsFirstWindow](#F-GlobalNET-MainWindow-_hackyIsFirstWindow 'GlobalNET.MainWindow._hackyIsFirstWindow')
  - [DataGridSelected](#P-GlobalNET-MainWindow-DataGridSelected 'GlobalNET.MainWindow.DataGridSelected')
  - [DataGridSelectedIdListIndicator](#P-GlobalNET-MainWindow-DataGridSelectedIdListIndicator 'GlobalNET.MainWindow.DataGridSelectedIdListIndicator')
  - [DgRefresh](#P-GlobalNET-MainWindow-DgRefresh 'GlobalNET.MainWindow.DgRefresh')
  - [DownloadShow](#P-GlobalNET-MainWindow-DownloadShow 'GlobalNET.MainWindow.DownloadShow')
  - [DownloadStatus](#P-GlobalNET-MainWindow-DownloadStatus 'GlobalNET.MainWindow.DownloadStatus')
  - [OperationRunning](#P-GlobalNET-MainWindow-OperationRunning 'GlobalNET.MainWindow.OperationRunning')
  - [ProgressRing](#P-GlobalNET-MainWindow-ProgressRing 'GlobalNET.MainWindow.ProgressRing')
  - [RunReleaseMode](#P-GlobalNET-MainWindow-RunReleaseMode 'GlobalNET.MainWindow.RunReleaseMode')
  - [ServerLoggerSource](#P-GlobalNET-MainWindow-ServerLoggerSource 'GlobalNET.MainWindow.ServerLoggerSource')
  - [ServiceRunning](#P-GlobalNET-MainWindow-ServiceRunning 'GlobalNET.MainWindow.ServiceRunning')
  - [ServiceStatus](#P-GlobalNET-MainWindow-ServiceStatus 'GlobalNET.MainWindow.ServiceStatus')
  - [ShowSystemLogger](#P-GlobalNET-MainWindow-ShowSystemLogger 'GlobalNET.MainWindow.ShowSystemLogger')
  - [SystemLogger](#P-GlobalNET-MainWindow-SystemLogger 'GlobalNET.MainWindow.SystemLogger')
  - [UserLogged](#P-GlobalNET-MainWindow-UserLogged 'GlobalNET.MainWindow.UserLogged')
  - [VncRunning](#P-GlobalNET-MainWindow-VncRunning 'GlobalNET.MainWindow.VncRunning')
  - [AddOrRemoveTab(headerName,tabPage,tagText)](#M-GlobalNET-MainWindow-AddOrRemoveTab-System-String,System-Object,System-String- 'GlobalNET.MainWindow.AddOrRemoveTab(System.String,System.Object,System.String)')
  - [BtnKeyboardClick(sender,e)](#M-GlobalNET-MainWindow-BtnKeyboardClick-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.BtnKeyboardClick(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnShowLoggerClick(sender,e)](#M-GlobalNET-MainWindow-BtnShowLoggerClick-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.BtnShowLoggerClick(System.Object,System.Windows.RoutedEventArgs)')
  - [Btn_LaunchHelp_Click(sender,e)](#M-GlobalNET-MainWindow-Btn_LaunchHelp_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Btn_LaunchHelp_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Btn_LaunchMetroTheme_Click(sender,e)](#M-GlobalNET-MainWindow-Btn_LaunchMetroTheme_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Btn_LaunchMetroTheme_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Btn_about_click(sender,e)](#M-GlobalNET-MainWindow-Btn_about_click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Btn_about_click(System.Object,System.Windows.RoutedEventArgs)')
  - [CbFilterDropDownClosed(sender,e)](#M-GlobalNET-MainWindow-CbFilterDropDownClosed-System-Object,System-EventArgs- 'GlobalNET.MainWindow.CbFilterDropDownClosed(System.Object,System.EventArgs)')
  - [CbPrintReportsSelected(sender,e)](#M-GlobalNET-MainWindow-CbPrintReportsSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.MainWindow.CbPrintReportsSelected(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [FilterField_SelectionChanged(sender,e)](#M-GlobalNET-MainWindow-FilterField_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.MainWindow.FilterField_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-MainWindow-InitializeComponent 'GlobalNET.MainWindow.InitializeComponent')
  - [MainGrid_IsDraggingChanged(sender,e)](#M-GlobalNET-MainWindow-MainGrid_IsDraggingChanged-System-Object,System-Windows-RoutedPropertyChangedEventArgs{System-Boolean}- 'GlobalNET.MainWindow.MainGrid_IsDraggingChanged(System.Object,System.Windows.RoutedPropertyChangedEventArgs{System.Boolean})')
  - [MainWindow_Closing(sender,e)](#M-GlobalNET-MainWindow-MainWindow_Closing-System-Object,System-ComponentModel-CancelEventArgs- 'GlobalNET.MainWindow.MainWindow_Closing(System.Object,System.ComponentModel.CancelEventArgs)')
  - [MainWindow_KeyDown(sender,e)](#M-GlobalNET-MainWindow-MainWindow_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.MainWindow.MainWindow_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [MainWindow_Loaded(sender,e)](#M-GlobalNET-MainWindow-MainWindow_Loaded-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.MainWindow_Loaded(System.Object,System.Windows.RoutedEventArgs)')
  - [MainWindow_MouseLeave()](#M-GlobalNET-MainWindow-MainWindow_MouseLeave-System-Object,System-Windows-Input-MouseEventArgs- 'GlobalNET.MainWindow.MainWindow_MouseLeave(System.Object,System.Windows.Input.MouseEventArgs)')
  - [MenuSortOnStart()](#M-GlobalNET-MainWindow-MenuSortOnStart 'GlobalNET.MainWindow.MenuSortOnStart')
  - [Menu_action_Click(sender,e)](#M-GlobalNET-MainWindow-Menu_action_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Menu_action_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Mi_filter_Click(sender,e)](#M-GlobalNET-MainWindow-Mi_filter_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Mi_filter_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Mi_logout_Click(sender,e)](#M-GlobalNET-MainWindow-Mi_logout_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Mi_logout_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [RemoveFilterItem_Click(sender,e)](#M-GlobalNET-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.RemoveFilterItem_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [SetServiceStop()](#M-GlobalNET-MainWindow-SetServiceStop 'GlobalNET.MainWindow.SetServiceStop')
  - [ShowLoginDialog()](#M-GlobalNET-MainWindow-ShowLoginDialog 'GlobalNET.MainWindow.ShowLoginDialog')
  - [ShowMessage(error,message,confirm)](#M-GlobalNET-MainWindow-ShowMessage-System-Boolean,System-String,System-Boolean- 'GlobalNET.MainWindow.ShowMessage(System.Boolean,System.String,System.Boolean)')
  - [StringToFilter(filterBox,advancedFilter)](#M-GlobalNET-MainWindow-StringToFilter-System-Windows-Controls-ComboBox,System-String- 'GlobalNET.MainWindow.StringToFilter(System.Windows.Controls.ComboBox,System.String)')
  - [SystemLoggerSourceChanged_Click(sender,e)](#M-GlobalNET-MainWindow-SystemLoggerSourceChanged_Click-System-Object,System-EventArgs- 'GlobalNET.MainWindow.SystemLoggerSourceChanged_Click(System.Object,System.EventArgs)')
  - [SystemTimerController(sender,e)](#M-GlobalNET-MainWindow-SystemTimerController-System-Object,System-Timers-ElapsedEventArgs- 'GlobalNET.MainWindow.SystemTimerController(System.Object,System.Timers.ElapsedEventArgs)')
  - [TabPanelOnSelectionChange(sender,e)](#M-GlobalNET-MainWindow-TabPanelOnSelectionChange-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.MainWindow.TabPanelOnSelectionChange(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [TiltOpenForm(translateHeader)](#M-GlobalNET-MainWindow-TiltOpenForm-System-String- 'GlobalNET.MainWindow.TiltOpenForm(System.String)')
- [MathTypeOperations](#T-GlobalNET-GlobalOperations-MathTypeOperations 'GlobalNET.GlobalOperations.MathTypeOperations')
  - [CheckTypeValue()](#M-GlobalNET-GlobalOperations-MathTypeOperations-CheckTypeValue-System-String,System-String- 'GlobalNET.GlobalOperations.MathTypeOperations.CheckTypeValue(System.String,System.String)')
- [MaturityListPage](#T-GlobalNET-Pages-MaturityListPage 'GlobalNET.Pages.MaturityListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-MaturityListPage-InitializeComponent 'GlobalNET.Pages.MaturityListPage.InitializeComponent')
- [MediaOperations](#T-GlobalNET-GlobalOperations-MediaOperations 'GlobalNET.GlobalOperations.MediaOperations')
  - [ArrayToImage(array)](#M-GlobalNET-GlobalOperations-MediaOperations-ArrayToImage-System-Byte[]- 'GlobalNET.GlobalOperations.MediaOperations.ArrayToImage(System.Byte[])')
  - [GetImageImmediatelly(path)](#M-GlobalNET-GlobalOperations-MediaOperations-GetImageImmediatelly-System-String- 'GlobalNET.GlobalOperations.MediaOperations.GetImageImmediatelly(System.String)')
- [MottoListPage](#T-GlobalNET-Pages-MottoListPage 'GlobalNET.Pages.MottoListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-MottoListPage-InitializeComponent 'GlobalNET.Pages.MottoListPage.InitializeComponent')
- [MyCustomLifeSpanHandler](#T-GlobalNET-Pages-DocumentationPage-MyCustomLifeSpanHandler 'GlobalNET.Pages.DocumentationPage.MyCustomLifeSpanHandler')
- [MyCustomLifeSpanHandler](#T-GlobalNET-Pages-TemplateWebViewPage-MyCustomLifeSpanHandler 'GlobalNET.Pages.TemplateWebViewPage.MyCustomLifeSpanHandler')
  - [OnBeforePopup(chromiumWebBrowser,browser,frame,targetUrl,targetFrameName,targetDisposition,userGesture,popupFeatures,windowInfo,browserSettings,noJavascriptAccess,newBrowser)](#M-GlobalNET-Pages-DocumentationPage-MyCustomLifeSpanHandler-OnBeforePopup-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-IFrame,System-String,System-String,CefSharp-WindowOpenDisposition,System-Boolean,CefSharp-IPopupFeatures,CefSharp-IWindowInfo,CefSharp-IBrowserSettings,System-Boolean@,CefSharp-IWebBrowser@- 'GlobalNET.Pages.DocumentationPage.MyCustomLifeSpanHandler.OnBeforePopup(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.IFrame,System.String,System.String,CefSharp.WindowOpenDisposition,System.Boolean,CefSharp.IPopupFeatures,CefSharp.IWindowInfo,CefSharp.IBrowserSettings,System.Boolean@,CefSharp.IWebBrowser@)')
  - [OnBeforePopup(chromiumWebBrowser,browser,frame,targetUrl,targetFrameName,targetDisposition,userGesture,popupFeatures,windowInfo,browserSettings,noJavascriptAccess,newBrowser)](#M-GlobalNET-Pages-TemplateWebViewPage-MyCustomLifeSpanHandler-OnBeforePopup-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-IFrame,System-String,System-String,CefSharp-WindowOpenDisposition,System-Boolean,CefSharp-IPopupFeatures,CefSharp-IWindowInfo,CefSharp-IBrowserSettings,System-Boolean@,CefSharp-IWebBrowser@- 'GlobalNET.Pages.TemplateWebViewPage.MyCustomLifeSpanHandler.OnBeforePopup(CefSharp.IWebBrowser,CefSharp.IBrowser,CefSharp.IFrame,System.String,System.String,CefSharp.WindowOpenDisposition,System.Boolean,CefSharp.IPopupFeatures,CefSharp.IWindowInfo,CefSharp.IBrowserSettings,System.Boolean@,CefSharp.IWebBrowser@)')
- [NotesListPage](#T-GlobalNET-Pages-NotesListPage 'GlobalNET.Pages.NotesListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-NotesListPage-InitializeComponent 'GlobalNET.Pages.NotesListPage.InitializeComponent')
- [OfferListPage](#T-GlobalNET-Pages-OfferListPage 'GlobalNET.Pages.OfferListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OfferListPage-InitializeComponent 'GlobalNET.Pages.OfferListPage.InitializeComponent')
- [OperationListPage](#T-GlobalNET-Pages-OperationListPage 'GlobalNET.Pages.OperationListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OperationListPage-InitializeComponent 'GlobalNET.Pages.OperationListPage.InitializeComponent')
- [OutgoingInvoiceListPage](#T-GlobalNET-Pages-OutgoingInvoiceListPage 'GlobalNET.Pages.OutgoingInvoiceListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OutgoingInvoiceListPage-InitializeComponent 'GlobalNET.Pages.OutgoingInvoiceListPage.InitializeComponent')
- [OutgoingOrderListPage](#T-GlobalNET-Pages-OutgoingOrderListPage 'GlobalNET.Pages.OutgoingOrderListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OutgoingOrderListPage-InitializeComponent 'GlobalNET.Pages.OutgoingOrderListPage.InitializeComponent')
- [ParameterListPage](#T-GlobalNET-Pages-ParameterListPage 'GlobalNET.Pages.ParameterListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ParameterListPage-InitializeComponent 'GlobalNET.Pages.ParameterListPage.InitializeComponent')
- [PartListPage](#T-GlobalNET-Pages-PartListPage 'GlobalNET.Pages.PartListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-PartListPage-InitializeComponent 'GlobalNET.Pages.PartListPage.InitializeComponent')
- [PaymentMethodListPage](#T-GlobalNET-Pages-PaymentMethodListPage 'GlobalNET.Pages.PaymentMethodListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-PaymentMethodListPage-InitializeComponent 'GlobalNET.Pages.PaymentMethodListPage.InitializeComponent')
- [PaymentStatusListPage](#T-GlobalNET-Pages-PaymentStatusListPage 'GlobalNET.Pages.PaymentStatusListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-PaymentStatusListPage-InitializeComponent 'GlobalNET.Pages.PaymentStatusListPage.InitializeComponent')
- [PersonListPage](#T-GlobalNET-Pages-PersonListPage 'GlobalNET.Pages.PersonListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-PersonListPage-InitializeComponent 'GlobalNET.Pages.PersonListPage.InitializeComponent')
- [ReceiptListPage](#T-GlobalNET-Pages-ReceiptListPage 'GlobalNET.Pages.ReceiptListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ReceiptListPage-InitializeComponent 'GlobalNET.Pages.ReceiptListPage.InitializeComponent')
- [ReportListPage](#T-GlobalNET-Pages-ReportListPage 'GlobalNET.Pages.ReportListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ReportListPage-InitializeComponent 'GlobalNET.Pages.ReportListPage.InitializeComponent')
- [ReportQueueListPage](#T-GlobalNET-Pages-ReportQueueListPage 'GlobalNET.Pages.ReportQueueListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ReportQueueListPage-InitializeComponent 'GlobalNET.Pages.ReportQueueListPage.InitializeComponent')
- [ReportSelection](#T-GlobalNET-Classes-ReportSelection 'GlobalNET.Classes.ReportSelection')
- [Resources](#T-GlobalNET-Properties-Resources 'GlobalNET.Properties.Resources')
  - [Culture](#P-GlobalNET-Properties-Resources-Culture 'GlobalNET.Properties.Resources.Culture')
  - [ResourceManager](#P-GlobalNET-Properties-Resources-ResourceManager 'GlobalNET.Properties.Resources.ResourceManager')
  - [no_photo](#P-GlobalNET-Properties-Resources-no_photo 'GlobalNET.Properties.Resources.no_photo')
- [ScreenSaverPage](#T-GlobalNET-Pages-ScreenSaverPage 'GlobalNET.Pages.ScreenSaverPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ScreenSaverPage-InitializeComponent 'GlobalNET.Pages.ScreenSaverPage.InitializeComponent')
- [ServerSettingKeys](#T-GlobalNET-Classes-ServerSettingKeys 'GlobalNET.Classes.ServerSettingKeys')
- [ServerSettingPage](#T-GlobalNET-Pages-ServerSettingPage 'GlobalNET.Pages.ServerSettingPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ServerSettingPage-InitializeComponent 'GlobalNET.Pages.ServerSettingPage.InitializeComponent')
- [SupportPage](#T-GlobalNET-Pages-SupportPage 'GlobalNET.Pages.SupportPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-SupportPage-InitializeComponent 'GlobalNET.Pages.SupportPage.InitializeComponent')
- [SvgIconListPage](#T-GlobalNET-Pages-SvgIconListPage 'GlobalNET.Pages.SvgIconListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-SvgIconListPage-InitializeComponent 'GlobalNET.Pages.SvgIconListPage.InitializeComponent')
- [SystemFailListPage](#T-GlobalNET-Pages-SystemFailListPage 'GlobalNET.Pages.SystemFailListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-SystemFailListPage-InitializeComponent 'GlobalNET.Pages.SystemFailListPage.InitializeComponent')
- [SystemLoggerHelper](#T-GlobalNET-SystemHelper-SystemLoggerHelper 'GlobalNET.SystemHelper.SystemLoggerHelper')
  - [DisposeSystemLoggerWebSocketMonitor()](#M-GlobalNET-SystemHelper-SystemLoggerHelper-DisposeSystemLoggerWebSocketMonitor 'GlobalNET.SystemHelper.SystemLoggerHelper.DisposeSystemLoggerWebSocketMonitor')
  - [SystemLoggerWebSocketMonitorOnOff()](#M-GlobalNET-SystemHelper-SystemLoggerHelper-SystemLoggerWebSocketMonitorOnOff 'GlobalNET.SystemHelper.SystemLoggerHelper.SystemLoggerWebSocketMonitorOnOff')
- [SystemLoggerWebSocketClass](#T-GlobalNET-SystemHelper-SystemLoggerWebSocketClass 'GlobalNET.SystemHelper.SystemLoggerWebSocketClass')
- [SystemOperations](#T-GlobalNET-GlobalOperations-SystemOperations 'GlobalNET.GlobalOperations.SystemOperations')
  - [FilterToString(filterBox)](#M-GlobalNET-GlobalOperations-SystemOperations-FilterToString-System-Windows-Controls-ComboBox- 'GlobalNET.GlobalOperations.SystemOperations.FilterToString(System.Windows.Controls.ComboBox)')
  - [GetExceptionMessages(exception,msgCount)](#M-GlobalNET-GlobalOperations-SystemOperations-GetExceptionMessages-System-Exception,System-Int32- 'GlobalNET.GlobalOperations.SystemOperations.GetExceptionMessages(System.Exception,System.Int32)')
  - [GetExceptionMessagesAll(exception,msgCount)](#M-GlobalNET-GlobalOperations-SystemOperations-GetExceptionMessagesAll-System-Exception,System-Int32- 'GlobalNET.GlobalOperations.SystemOperations.GetExceptionMessagesAll(System.Exception,System.Int32)')
  - [IncreaseFileVersionBuild()](#M-GlobalNET-GlobalOperations-SystemOperations-IncreaseFileVersionBuild 'GlobalNET.GlobalOperations.SystemOperations.IncreaseFileVersionBuild')
  - [RandomString(length)](#M-GlobalNET-GlobalOperations-SystemOperations-RandomString-System-Int32- 'GlobalNET.GlobalOperations.SystemOperations.RandomString(System.Int32)')
  - [RemoveAppNamespaceFromString(stringForRemoveNamespace)](#M-GlobalNET-GlobalOperations-SystemOperations-RemoveAppNamespaceFromString-System-String- 'GlobalNET.GlobalOperations.SystemOperations.RemoveAppNamespaceFromString(System.String)')
  - [SendMailWithMailTo(address,subject,body,attach)](#M-GlobalNET-GlobalOperations-SystemOperations-SendMailWithMailTo-System-String,System-String,System-String,System-String- 'GlobalNET.GlobalOperations.SystemOperations.SendMailWithMailTo(System.String,System.String,System.String,System.String)')
  - [SendMailWithServerSetting(message)](#M-GlobalNET-GlobalOperations-SystemOperations-SendMailWithServerSetting-System-String- 'GlobalNET.GlobalOperations.SystemOperations.SendMailWithServerSetting(System.String)')
  - [SetLanguageDictionary(Resources,languageDefault)](#M-GlobalNET-GlobalOperations-SystemOperations-SetLanguageDictionary-System-Windows-ResourceDictionary,System-String- 'GlobalNET.GlobalOperations.SystemOperations.SetLanguageDictionary(System.Windows.ResourceDictionary,System.String)')
  - [StartExternalProccess(fullFilePath,startupPath,arguments)](#M-GlobalNET-GlobalOperations-SystemOperations-StartExternalProccess-System-String,System-String,System-String,System-String- 'GlobalNET.GlobalOperations.SystemOperations.StartExternalProccess(System.String,System.String,System.String,System.String)')
- [SystemStatuses](#T-GlobalNET-GlobalClasses-SystemStatuses 'GlobalNET.GlobalClasses.SystemStatuses')
- [SystemWindowDataModel](#T-GlobalNET-SystemStructure-SystemWindowDataModel 'GlobalNET.SystemStructure.SystemWindowDataModel')
  - [#ctor()](#M-GlobalNET-SystemStructure-SystemWindowDataModel-#ctor 'GlobalNET.SystemStructure.SystemWindowDataModel.#ctor')
- [TemplateClassListPage](#T-GlobalNET-Pages-TemplateClassListPage 'GlobalNET.Pages.TemplateClassListPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateClassListPage-#ctor 'GlobalNET.Pages.TemplateClassListPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateClassListPage-dataViewSupport 'GlobalNET.Pages.TemplateClassListPage.dataViewSupport')
  - [DeleteRecord()](#M-GlobalNET-Pages-TemplateClassListPage-DeleteRecord 'GlobalNET.Pages.TemplateClassListPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateClassListPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateClassListPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateClassListPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateClassListPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-GlobalNET-Pages-TemplateClassListPage-EditRecord-System-Boolean- 'GlobalNET.Pages.TemplateClassListPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateClassListPage-Filter-System-String- 'GlobalNET.Pages.TemplateClassListPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateClassListPage-InitializeComponent 'GlobalNET.Pages.TemplateClassListPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateClassListPage-LoadDataList 'GlobalNET.Pages.TemplateClassListPage.LoadDataList')
  - [NewRecord()](#M-GlobalNET-Pages-TemplateClassListPage-NewRecord 'GlobalNET.Pages.TemplateClassListPage.NewRecord')
- [TemplateClassListViewPage](#T-GlobalNET-Pages-TemplateClassListViewPage 'GlobalNET.Pages.TemplateClassListViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateClassListViewPage-#ctor 'GlobalNET.Pages.TemplateClassListViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateClassListViewPage-dataViewSupport 'GlobalNET.Pages.TemplateClassListViewPage.dataViewSupport')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateClassListViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateClassListViewPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateClassListViewPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateClassListViewPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateClassListViewPage-Filter-System-String- 'GlobalNET.Pages.TemplateClassListViewPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateClassListViewPage-InitializeComponent 'GlobalNET.Pages.TemplateClassListViewPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateClassListViewPage-LoadDataList 'GlobalNET.Pages.TemplateClassListViewPage.LoadDataList')
- [TemplateClassListWithSubPage](#T-GlobalNET-Pages-TemplateClassListWithSubPage 'GlobalNET.Pages.TemplateClassListWithSubPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-#ctor 'GlobalNET.Pages.TemplateClassListWithSubPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateClassListWithSubPage-dataViewSupport 'GlobalNET.Pages.TemplateClassListWithSubPage.dataViewSupport')
  - [ClearItemsFields()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-ClearItemsFields 'GlobalNET.Pages.TemplateClassListWithSubPage.ClearItemsFields')
  - [Customer_KeyDown(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.Customer_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [DeleteRecord()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-DeleteRecord 'GlobalNET.Pages.TemplateClassListWithSubPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-EditRecord-System-Boolean- 'GlobalNET.Pages.TemplateClassListWithSubPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-Filter-System-String- 'GlobalNET.Pages.TemplateClassListWithSubPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-InitializeComponent 'GlobalNET.Pages.TemplateClassListWithSubPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-LoadDataList 'GlobalNET.Pages.TemplateClassListWithSubPage.LoadDataList')
  - [NewRecord()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-NewRecord 'GlobalNET.Pages.TemplateClassListWithSubPage.NewRecord')
  - [NotesChanged(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.NotesChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [PartNumberGotFocus(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.PartNumberGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [PartNumber_KeyDown(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.PartNumber_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectCustomer_Enter(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.SelectCustomer_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectGotFocus(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.SelectGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [SelectPartNumber_Enter(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubPage.SelectPartNumber_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SetCustomer(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-SetCustomer 'GlobalNET.Pages.TemplateClassListWithSubPage.SetCustomer')
  - [SetPartNumber(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubPage-SetPartNumber 'GlobalNET.Pages.TemplateClassListWithSubPage.SetPartNumber')
  - [SetSubListsNonActiveOnNewItem()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean- 'GlobalNET.Pages.TemplateClassListWithSubPage.SetSubListsNonActiveOnNewItem(System.Boolean)')
  - [UpdateCustomerSearchResults()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-UpdateCustomerSearchResults 'GlobalNET.Pages.TemplateClassListWithSubPage.UpdateCustomerSearchResults')
  - [UpdatePartNumberSearchResults()](#M-GlobalNET-Pages-TemplateClassListWithSubPage-UpdatePartNumberSearchResults 'GlobalNET.Pages.TemplateClassListWithSubPage.UpdatePartNumberSearchResults')
- [TemplateClassListWithSubViewPage](#T-GlobalNET-Pages-TemplateClassListWithSubViewPage 'GlobalNET.Pages.TemplateClassListWithSubViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-#ctor 'GlobalNET.Pages.TemplateClassListWithSubViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateClassListWithSubViewPage-dataViewSupport 'GlobalNET.Pages.TemplateClassListWithSubViewPage.dataViewSupport')
  - [DeleteRecord()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DeleteRecord 'GlobalNET.Pages.TemplateClassListWithSubViewPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateClassListWithSubViewPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateClassListWithSubViewPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateClassListWithSubViewPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-EditRecord-System-Boolean- 'GlobalNET.Pages.TemplateClassListWithSubViewPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-Filter-System-String- 'GlobalNET.Pages.TemplateClassListWithSubViewPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-InitializeComponent 'GlobalNET.Pages.TemplateClassListWithSubViewPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-LoadDataList 'GlobalNET.Pages.TemplateClassListWithSubViewPage.LoadDataList')
  - [LoadSubDataList()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-LoadSubDataList 'GlobalNET.Pages.TemplateClassListWithSubViewPage.LoadSubDataList')
  - [NewRecord()](#M-GlobalNET-Pages-TemplateClassListWithSubViewPage-NewRecord 'GlobalNET.Pages.TemplateClassListWithSubViewPage.NewRecord')
- [TemplateDocumentViewPage](#T-GlobalNET-Pages-TemplateDocumentViewPage 'GlobalNET.Pages.TemplateDocumentViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateDocumentViewPage-#ctor 'GlobalNET.Pages.TemplateDocumentViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateDocumentViewPage-dataViewSupport 'GlobalNET.Pages.TemplateDocumentViewPage.dataViewSupport')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateDocumentViewPage-InitializeComponent 'GlobalNET.Pages.TemplateDocumentViewPage.InitializeComponent')
- [TemplateSTLPage](#T-GlobalNET-Pages-TemplateSTLPage 'GlobalNET.Pages.TemplateSTLPage')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateSTLPage-dataViewSupport 'GlobalNET.Pages.TemplateSTLPage.dataViewSupport')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateSTLPage-InitializeComponent 'GlobalNET.Pages.TemplateSTLPage.InitializeComponent')
- [TemplateSettingsPage](#T-GlobalNET-Pages-TemplateSettingsPage 'GlobalNET.Pages.TemplateSettingsPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateSettingsPage-#ctor 'GlobalNET.Pages.TemplateSettingsPage.#ctor')
  - [Languages](#F-GlobalNET-Pages-TemplateSettingsPage-Languages 'GlobalNET.Pages.TemplateSettingsPage.Languages')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateSettingsPage-dataViewSupport 'GlobalNET.Pages.TemplateSettingsPage.dataViewSupport')
  - [BtnApiTest_Click(sender,e)](#M-GlobalNET-Pages-TemplateSettingsPage-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.TemplateSettingsPage.BtnApiTest_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateSettingsPage-InitializeComponent 'GlobalNET.Pages.TemplateSettingsPage.InitializeComponent')
- [TemplateVideoPage](#T-GlobalNET-Pages-TemplateVideoPage 'GlobalNET.Pages.TemplateVideoPage')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateVideoPage-dataViewSupport 'GlobalNET.Pages.TemplateVideoPage.dataViewSupport')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateVideoPage-InitializeComponent 'GlobalNET.Pages.TemplateVideoPage.InitializeComponent')
- [TemplateWebViewPage](#T-GlobalNET-Pages-TemplateWebViewPage 'GlobalNET.Pages.TemplateWebViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateWebViewPage-#ctor 'GlobalNET.Pages.TemplateWebViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateWebViewPage-dataViewSupport 'GlobalNET.Pages.TemplateWebViewPage.dataViewSupport')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateWebViewPage-InitializeComponent 'GlobalNET.Pages.TemplateWebViewPage.InitializeComponent')
- [TerminalPage](#T-GlobalNET-Pages-TerminalPage 'GlobalNET.Pages.TerminalPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-TerminalPage-InitializeComponent 'GlobalNET.Pages.TerminalPage.InitializeComponent')
- [TiltTargets](#T-GlobalNET-GlobalClasses-TiltTargets 'GlobalNET.GlobalClasses.TiltTargets')
- [ToolPanelDefinitionListPage](#T-GlobalNET-Pages-ToolPanelDefinitionListPage 'GlobalNET.Pages.ToolPanelDefinitionListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ToolPanelDefinitionListPage-InitializeComponent 'GlobalNET.Pages.ToolPanelDefinitionListPage.InitializeComponent')
- [ToolPanelListPage](#T-GlobalNET-Pages-ToolPanelListPage 'GlobalNET.Pages.ToolPanelListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ToolPanelListPage-InitializeComponent 'GlobalNET.Pages.ToolPanelListPage.InitializeComponent')
- [TranslatedApiList](#T-GlobalNET-GlobalClasses-TranslatedApiList 'GlobalNET.GlobalClasses.TranslatedApiList')
- [UnitListPage](#T-GlobalNET-Pages-UnitListPage 'GlobalNET.Pages.UnitListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-UnitListPage-InitializeComponent 'GlobalNET.Pages.UnitListPage.InitializeComponent')
- [UpdateVariant](#T-GlobalNET-GlobalClasses-UpdateVariant 'GlobalNET.GlobalClasses.UpdateVariant')
- [UsedLicenseListPage](#T-GlobalNET-Pages-UsedLicenseListPage 'GlobalNET.Pages.UsedLicenseListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-UsedLicenseListPage-InitializeComponent 'GlobalNET.Pages.UsedLicenseListPage.InitializeComponent')
- [UserData](#T-GlobalNET-GlobalClasses-UserData 'GlobalNET.GlobalClasses.UserData')
- [UserListPage](#T-GlobalNET-Pages-UserListPage 'GlobalNET.Pages.UserListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-UserListPage-InitializeComponent 'GlobalNET.Pages.UserListPage.InitializeComponent')
- [UserRoleListPage](#T-GlobalNET-Pages-UserRoleListPage 'GlobalNET.Pages.UserRoleListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-UserRoleListPage-InitializeComponent 'GlobalNET.Pages.UserRoleListPage.InitializeComponent')
- [VatListPage](#T-GlobalNET-Pages-VatListPage 'GlobalNET.Pages.VatListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-VatListPage-InitializeComponent 'GlobalNET.Pages.VatListPage.InitializeComponent')
- [WarehouseListPage](#T-GlobalNET-Pages-WarehouseListPage 'GlobalNET.Pages.WarehouseListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-WarehouseListPage-InitializeComponent 'GlobalNET.Pages.WarehouseListPage.InitializeComponent')
- [WelcomePage](#T-GlobalNET-Pages-WelcomePage 'GlobalNET.Pages.WelcomePage')
  - [InitializeComponent()](#M-GlobalNET-Pages-WelcomePage-InitializeComponent 'GlobalNET.Pages.WelcomePage.InitializeComponent')
- [WorkListPage](#T-GlobalNET-Pages-WorkListPage 'GlobalNET.Pages.WorkListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-WorkListPage-InitializeComponent 'GlobalNET.Pages.WorkListPage.InitializeComponent')

<a name='T-GlobalNET-Pages-AccessRoleListPage'></a>
## AccessRoleListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

AccessRoleListPage

<a name='M-GlobalNET-Pages-AccessRoleListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-AddressListPage'></a>
## AddressListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

AddressListPage

<a name='M-GlobalNET-Pages-AddressListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Api-ApiUrls'></a>
## ApiUrls `type`

##### Namespace

GlobalNET.Api

##### Summary

ALL standard View AND Form API Call must end with "List" - These will automatic added for reports Definitions

<a name='T-GlobalNET-App'></a>
## App `type`

##### Namespace

GlobalNET

##### Summary

App

<a name='M-GlobalNET-App-#ctor'></a>
### #ctor() `constructor`

##### Summary

Application Global Exceptions Controls Definitions

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-App-SystemRuntimeData'></a>
### SystemRuntimeData `constants`

##### Summary

Global Application Startup Settings
Central Parameters / Languages / User / Configure
TODO must centalize to Globall APP class

<a name='F-GlobalNET-App-TiltReceiptDoc'></a>
### TiltReceiptDoc `constants`

##### Summary

Tilt Document types definitions

<a name='M-GlobalNET-App-AppQuitRequest-System-Boolean-'></a>
### AppQuitRequest(silent) `method`

##### Summary

System or Quit

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| silent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-GlobalNET-App-AppRestart'></a>
### AppRestart() `method`

##### Summary

System Restart Controller

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-App-ApplicationLogging-System-Exception,System-String-'></a>
### ApplicationLogging(ex,customMessage) `method`

##### Summary

Full Application System logging
Running If is AppSystemTimer is Enabled for disable other processes exceptions
Full Application logging to file if enabled and to DB for solving by Developers
Supported Custom Message
Here Is Filling Local System Logger for Developers
Logging to Database Are All non Developer working

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| customMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-App-ApplicationQuit'></a>
### ApplicationQuit(sender,e) `method`

##### Summary

MainWindow Closing Handler for Cleaning TempData, disable AddOns / Tool and Third Party Software
Closing Third Party processes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [M:GlobalNET.App.ApplicationQuit](#T-M-GlobalNET-App-ApplicationQuit 'M:GlobalNET.App.ApplicationQuit') |  |

<a name='M-GlobalNET-App-CurrentDomain_FirstChanceException-System-Object,System-Runtime-ExceptionServices-FirstChanceExceptionEventArgs-'></a>
### CurrentDomain_FirstChanceException(sender,e) `method`

##### Summary

FullSystem Logging
Every Exception types are monitored for
maximize correct running
all processes, System addOns, systems, communications, threads, network
All detail of application system add all used possibilities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs 'System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs') |  |

<a name='M-GlobalNET-App-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-App-Main'></a>
### Main() `method`

##### Summary

Application Entry Point.

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-App-OnStartup-System-Windows-StartupEventArgs-'></a>
### OnStartup(e) `method`

##### Summary

Connected Starting Video

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.StartupEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.StartupEventArgs 'System.Windows.StartupEventArgs') |  |

<a name='M-GlobalNET-App-RootAppKeyDownController-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### RootAppKeyDownController(sender,e) `method`

##### Summary

Keyboard Pointer to Central Keyboard Reaction Definitions

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='T-GlobalNET-Classes-AppVersion'></a>
## AppVersion `type`

##### Namespace

GlobalNET.Classes

##### Summary

Program version Class

<a name='T-GlobalNET-Pages-AttachmentListPage'></a>
## AttachmentListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

AttachmentListPage

<a name='M-GlobalNET-Pages-AttachmentListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-Authentification'></a>
## Authentification `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Class for User Authentication information

<a name='T-GlobalNET-Pages-BranchListPage'></a>
## BranchListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

BranchListPage

<a name='M-GlobalNET-Pages-BranchListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-CalendarPage'></a>
## CalendarPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

CalendarPage

<a name='M-GlobalNET-Pages-CalendarPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ClientSettingsPage'></a>
## ClientSettingsPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ClientSettingsPage

<a name='M-GlobalNET-Pages-ClientSettingsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Classes-Config'></a>
## Config `type`

##### Namespace

GlobalNET.Classes

##### Summary

Client configuration Definition

<a name='T-GlobalNET-SystemConfiguration-CrashReporterSettings'></a>
## CrashReporterSettings `type`

##### Namespace

GlobalNET.SystemConfiguration

##### Summary

Libreria condivisa

<a name='F-GlobalNET-SystemConfiguration-CrashReporterSettings-_ReportCrash'></a>
### _ReportCrash `constants`

##### Summary

FirstRun

<a name='T-GlobalNET-Pages-CreditNoteListPage'></a>
## CreditNoteListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

CreditNoteListPage

<a name='M-GlobalNET-Pages-CreditNoteListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-CurrencyListPage'></a>
## CurrencyListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

CurrencyListPage

<a name='M-GlobalNET-Pages-CurrencyListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalOperations-DBOperations'></a>
## DBOperations `type`

##### Namespace

GlobalNET.GlobalOperations

##### Summary

Centralised DBFunctions as Load DB Congig, System Dials (Language, Params)
Another Db functions As Saving System Loging, Language Dictionary Autofiling

<a name='M-GlobalNET-GlobalOperations-DBOperations-DBTranslation-System-String,System-Boolean,System-Boolean,System-String-'></a>
### DBTranslation(systemName,notCreateNew,comaList,lang) `method`

##### Summary

Centralised Method for Translating by DB Dictionary Service insert the news words for
translate (After translate request) to Database Automaticaly with Empty Translate.
Service return translate if is possible or requested word send back CamelCase ignored

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| systemName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| notCreateNew | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| comaList | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| lang | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-DBOperations-LoadOrRefreshUserData'></a>
### LoadOrRefreshUserData() `method`

##### Summary

Centralised Method for Refresh All UserData
params, for correct App running.
Thinking for remove and new Load
Actualy limited by DebugingHelpSetting
Itr user After Succes User Login

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-GlobalOperations-DBOperations-LoadStartupDBData'></a>
### LoadStartupDBData() `method`

##### Summary

Startup Load System Parameters ,Languages, System Controlling, Server Setting

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-GlobalOperations-DBOperations-SaveSystemFailMessage-System-String,System-String-'></a>
### SaveSystemFailMessage(message) `method`

##### Summary

Save Exception to DB Fail List (System Log)
Write to System Logger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-DBOperations-SetNonUserDataOnSuccessStartUp'></a>
### SetNonUserDataOnSuccessStartUp() `method`

##### Summary

SYSTEM: Set NonUser Startup Data for Correct Prepare System 
Its for All Status Possible - NODB,OS,IS,Network,etc.
For check ANY possible problems out of System

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Api-DBResultMessage'></a>
## DBResultMessage `type`

##### Namespace

GlobalNET.Api

##### Summary

Global API Definition of Result API calls 
for All Calling of Insert / Update / Delete

<a name='T-GlobalNET-GlobalOperations-DataOperations'></a>
## DataOperations `type`

##### Namespace

GlobalNET.GlobalOperations

##### Summary

Centralized DataOperations as Cleaning dataset
Language Dictionary Auto filing

<a name='M-GlobalNET-GlobalOperations-DataOperations-GetTranslatedApiList-System-Boolean,System-Collections-Generic-List{System-String}-'></a>
### GetTranslatedApiList(listOnly,omitApiList) `method`

##### Summary

Global Method for Using API Uris as Unique Generic List for
All API Call - logic is All standardized not only DataPages as automated Logic

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| listOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| omitApiList | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-GlobalNET-GlobalOperations-DataOperations-NullSetInExtensionFields``1-``0@-'></a>
### NullSetInExtensionFields\`\`1() `method`

##### Summary

!!! SYSTEM RULE: ClassList with joining fields names must be null able before API operation
!!! ClassName must contain: "Extended" WORD
Extension field in Class - Dataset must be set as null before Database Operation
else is joining to other dataset is valid and can be blocked by fail key
Its Check Extended in ClassName - SYSTEM RULE

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-GlobalNET-GlobalOperations-DataOperations-ParameterCheck-System-String-'></a>
### ParameterCheck(parameterName) `method`

##### Summary

Return Requested User or if not exist default DB parameter
CamelCase Ignored

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-GlobalNET-Classes-DataViewSupport'></a>
## DataViewSupport `type`

##### Namespace

GlobalNET.Classes

##### Summary

Actual List Item informations for Controls each Page in MainView

<a name='T-GlobalNET-Pages-DocumentAdviceListPage'></a>
## DocumentAdviceListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

DocumentAdviceListPage

<a name='M-GlobalNET-Pages-DocumentAdviceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-DocumentItemList'></a>
## DocumentItemList `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Univessal Document List (Item) for Offer,Order,Invoice

<a name='T-GlobalNET-Pages-DocumentTypeListPage'></a>
## DocumentTypeListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

DocumentTypeListPage

<a name='M-GlobalNET-Pages-DocumentTypeListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-DocumentationPage'></a>
## DocumentationPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

DocumentationPage

<a name='M-GlobalNET-Pages-DocumentationPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ExchangeRateListPage'></a>
## ExchangeRateListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ExchangeRateListPage

<a name='M-GlobalNET-Pages-ExchangeRateListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalOperations-FileOperations'></a>
## FileOperations `type`

##### Namespace

GlobalNET.GlobalOperations

<a name='M-GlobalNET-GlobalOperations-FileOperations-CopyFiles-System-String,System-String-'></a>
### CopyFiles(sourcePath,destinationPath) `method`

##### Summary

Prepared Method for Files Copy

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| destinationPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-FileOperations-CreateFile-System-String-'></a>
### CreateFile(file) `method`

##### Summary

Prepared Method for Create empty file

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-FileOperations-FileDetectEncoding-System-String-'></a>
### FileDetectEncoding(FileName) `method`

##### Summary

Prepared Method for Get Information of File encoding
UTF8,WIN1250,etc

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-FileOperations-LoadSettings'></a>
### LoadSettings() `method`

##### Summary

Application Startup Check and configure Data Structure in folder ProgramData
And required files, load client configuration config.json

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-GlobalOperations-FileOperations-SaveSettings'></a>
### SaveSettings() `method`

##### Summary

Function for saving Application Configuration
This is client configuration only

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-GlobalOperations-FileOperations-VncServerIniFile-System-String-'></a>
### VncServerIniFile(path) `method`

##### Summary

Generate ini file for start vns server
default password: groupware

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-XamlGeneratedNamespace-GeneratedInternalTypeHelper'></a>
## GeneratedInternalTypeHelper `type`

##### Namespace

XamlGeneratedNamespace

##### Summary

GeneratedInternalTypeHelper

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate-'></a>
### AddEventHandler() `method`

##### Summary

AddEventHandler

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String-'></a>
### CreateDelegate() `method`

##### Summary

CreateDelegate

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo-'></a>
### CreateInstance() `method`

##### Summary

CreateInstance

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo-'></a>
### GetPropertyValue() `method`

##### Summary

GetPropertyValue

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo-'></a>
### SetPropertyValue() `method`

##### Summary

SetPropertyValue

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-GlobalRuntimeMonitor'></a>
## GlobalRuntimeMonitor `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

!!!SYSTEM 
Global Runtime Monitor Definition For One Point monitoring
For Processes and each other Definition For optimize
the System Running

TODO
- move All Central Definitions Here
- create Monitor Window for managing

<a name='T-GlobalNET-Pages-GraphsPage'></a>
## GraphsPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

GraphsPage

<a name='M-GlobalNET-Pages-GraphsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-GroupListPage'></a>
## GroupListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

GroupListPage

<a name='M-GlobalNET-Pages-GroupListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalOperations-HardwareOperations'></a>
## HardwareOperations `type`

##### Namespace

GlobalNET.GlobalOperations

<a name='M-GlobalNET-GlobalOperations-HardwareOperations-ApplicationKeyboardMaping-System-Windows-Input-KeyEventArgs-'></a>
### ApplicationKeyboardMaping(sender,e) `method`

##### Summary

Application Keyboard controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='T-GlobalNET-GlobalGenerators-IconMaker'></a>
## IconMaker `type`

##### Namespace

GlobalNET.GlobalGenerators

##### Summary

System Online Icon Generator from custom Path
Its for working with Icon over Database Dynamically

<a name='M-GlobalNET-GlobalGenerators-IconMaker-Icon-System-Windows-Media-Color,System-String-'></a>
### Icon(color,iconPath) `method`

##### Summary

Generate Custom Icon from Defined Path

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Windows.Media.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Media.Color 'System.Windows.Media.Color') | The color. |
| iconPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The icon path. |

<a name='T-GlobalNET-Pages-IgnoredExceptionListPage'></a>
## IgnoredExceptionListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

IgnoredExceptionListPage

<a name='M-GlobalNET-Pages-IgnoredExceptionListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ImageGalleryListPage'></a>
## ImageGalleryListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ImageGalleryListPage

<a name='M-GlobalNET-Pages-ImageGalleryListPage-ClearGallery'></a>
### ClearGallery() `method`

##### Summary

Phycical clear local storage and form

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-ImageGalleryListPage-GrayscaleClick-System-Object,System-Windows-RoutedEventArgs-'></a>
### GrayscaleClick(sender,e) `method`

##### Summary

Images Effect Part

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Pages-ImageGalleryListPage-ImageChangesCancelClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### ImageChangesCancelClick(sender,e) `method`

##### Summary

Image Graphics Changes Controllers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-GlobalNET-Pages-ImageGalleryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-ImageGalleryListPage-LoadFromServer-System-Int32-'></a>
### LoadFromServer() `method`

##### Summary

Last proccess

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-ImageGalleryListPage-RefreshViewPhoto-System-Nullable{System-Int32}-'></a>
### RefreshViewPhoto(selectedPhotoId) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectedPhotoId | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | selectedPhotoId -1 is Select Last |

<a name='M-GlobalNET-Pages-ImageGalleryListPage-SaveImageToServer-System-Nullable{System-Int32}-'></a>
### SaveImageToServer(onlyThis) `method`

##### Summary

null For Full Folder else No of dbId, 0 = new

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyThis | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='T-GlobalNET-Pages-IncomingInvoiceListPage'></a>
## IncomingInvoiceListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

IncomingInvoiceListPage

<a name='M-GlobalNET-Pages-IncomingInvoiceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-IncomingOrderListPage'></a>
## IncomingOrderListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

IncomingOrderListPage

<a name='M-GlobalNET-Pages-IncomingOrderListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ItemListPage'></a>
## ItemListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ItemListPage

<a name='M-GlobalNET-Pages-ItemListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Classes-Language'></a>
## Language `type`

##### Namespace

GlobalNET.Classes

##### Summary

Language definition support

<a name='T-GlobalNET-Pages-LanguageListPage'></a>
## LanguageListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

LanguageListPage

<a name='M-GlobalNET-Pages-LanguageListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-LicenseActivationFailListPage'></a>
## LicenseActivationFailListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

LicenseActivationFailListPage

<a name='M-GlobalNET-Pages-LicenseActivationFailListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-LicenseAlgorithmListPage'></a>
## LicenseAlgorithmListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

LicenseAlgorithmListPage

<a name='M-GlobalNET-Pages-LicenseAlgorithmListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-LoginHistoryListPage'></a>
## LoginHistoryListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

LoginHistoryListPage

<a name='M-GlobalNET-Pages-LoginHistoryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-MainWindow'></a>
## MainWindow `type`

##### Namespace

GlobalNET

##### Summary

MainWindow

<a name='M-GlobalNET-MainWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

System Core AND ALL shared functionalities

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-MainWindow-_hackyIsFirstWindow'></a>
### _hackyIsFirstWindow `constants`

##### Summary

MainControls Screen Variables

<a name='P-GlobalNET-MainWindow-DataGridSelected'></a>
### DataGridSelected `property`

##### Summary

Indicator for Enable New DataGrid Button

<a name='P-GlobalNET-MainWindow-DataGridSelectedIdListIndicator'></a>
### DataGridSelectedIdListIndicator `property`

##### Summary

[DataGrid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.DataGrid 'System.Windows.Controls.DataGrid') have selected record indicator

<a name='P-GlobalNET-MainWindow-DgRefresh'></a>
### DgRefresh `property`

##### Summary

Indicator for enable Refresh Button Indicator

<a name='P-GlobalNET-MainWindow-DownloadShow'></a>
### DownloadShow `property`

##### Summary

Indicator for show Downloading area

<a name='P-GlobalNET-MainWindow-DownloadStatus'></a>
### DownloadStatus `property`

##### Summary

Downloading of update status variable

<a name='P-GlobalNET-MainWindow-OperationRunning'></a>
### OperationRunning `property`

##### Summary

Indicator for mark operation status for any programmatic operations

<a name='P-GlobalNET-MainWindow-ProgressRing'></a>
### ProgressRing `property`

##### Summary

ProgressRing Visibility indicator

<a name='P-GlobalNET-MainWindow-RunReleaseMode'></a>
### RunReleaseMode `property`

<a name='P-GlobalNET-MainWindow-ServerLoggerSource'></a>
### ServerLoggerSource `property`

##### Summary

System Logger Source Status and Controller
This is status of Settings System Logger Source

<a name='P-GlobalNET-MainWindow-ServiceRunning'></a>
### ServiceRunning `property`

##### Summary

Service Status description

<a name='P-GlobalNET-MainWindow-ServiceStatus'></a>
### ServiceStatus `property`

##### Summary

Service Status public Variable

<a name='P-GlobalNET-MainWindow-ShowSystemLogger'></a>
### ShowSystemLogger `property`

##### Summary

System Logger Activator by Setted Parametr
Can be setted for All Apps or Every User individually

<a name='P-GlobalNET-MainWindow-SystemLogger'></a>
### SystemLogger `property`

##### Summary

System Online Logger for EASY developing

<a name='P-GlobalNET-MainWindow-UserLogged'></a>
### UserLogged `property`

##### Summary

User Logged Status

<a name='P-GlobalNET-MainWindow-VncRunning'></a>
### VncRunning `property`

<a name='M-GlobalNET-MainWindow-AddOrRemoveTab-System-String,System-Object,System-String-'></a>
### AddOrRemoveTab(headerName,tabPage,tagText) `method`

##### Summary

Tabs Pages control for Insert/Move/Change Pages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| headerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| tabPage | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| tagText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-MainWindow-BtnKeyboardClick-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnKeyboardClick(sender,e) `method`

##### Summary

System tools controllers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-BtnShowLoggerClick-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnShowLoggerClick(sender,e) `method`

##### Summary

Show System On line Logger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-Btn_LaunchHelp_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Btn_LaunchHelp_Click(sender,e) `method`

##### Summary

Help button controller for Show Help File

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-Btn_LaunchMetroTheme_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Btn_LaunchMetroTheme_Click(sender,e) `method`

##### Summary

Show Metro Theme possibilities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-Btn_about_click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Btn_about_click(sender,e) `method`

##### Summary

about applications information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-CbFilterDropDownClosed-System-Object,System-EventArgs-'></a>
### CbFilterDropDownClosed(sender,e) `method`

##### Summary

Full dynamic apply sett ed filter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-MainWindow-CbPrintReportsSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### CbPrintReportsSelected(sender,e) `method`

##### Summary

Print Report Selection Controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-FilterField_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### FilterField_SelectionChanged(sender,e) `method`

##### Summary

Full dynamic set sign DataGrid advanced filter type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-MainWindow-MainGrid_IsDraggingChanged-System-Object,System-Windows-RoutedPropertyChangedEventArgs{System-Boolean}-'></a>
### MainGrid_IsDraggingChanged(sender,e) `method`

##### Summary

Dragging and separate to more Applications: TabPanel drag Controller - not Used

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedPropertyChangedEventArgs{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedPropertyChangedEventArgs 'System.Windows.RoutedPropertyChangedEventArgs{System.Boolean}') |  |

<a name='M-GlobalNET-MainWindow-MainWindow_Closing-System-Object,System-ComponentModel-CancelEventArgs-'></a>
### MainWindow_Closing(sender,e) `method`

##### Summary

Applications Close Request Controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') |  |

<a name='M-GlobalNET-MainWindow-MainWindow_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### MainWindow_KeyDown(sender,e) `method`

##### Summary

MainWindow Keyboard pointer to Keyboard Central Application controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-MainWindow-MainWindow_Loaded-System-Object,System-Windows-RoutedEventArgs-'></a>
### MainWindow_Loaded(sender,e) `method`

##### Summary

Application Loaded Start Backend timer for check server
set Theme

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-MainWindow_MouseLeave-System-Object,System-Windows-Input-MouseEventArgs-'></a>
### MainWindow_MouseLeave() `method`

##### Summary

Writing Last User action for monitoring Free Time
Used by: SceenSaver

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-MainWindow-MenuSortOnStart'></a>
### MenuSortOnStart() `method`

##### Summary

Auto Menu Alphabetical sorting for selected Application Language

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-MainWindow-Menu_action_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Menu_action_Click(sender,e) `method`

##### Summary

THIS IS AUTOMATIC INCLUDE DATALIST VIEW MENU in FORMAT  APIcallPage
open or select existed TabPanel VERTICAL MENU -  Copy and CHANGE ONLY Page Name AND Report CALL  as /XXXX

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-Mi_filter_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Mi_filter_Click(sender,e) `method`

##### Summary

Full dynamic Show/Hidden DataGrid advanced Filter Menu

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-Mi_logout_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Mi_logout_Click(sender,e) `method`

##### Summary

Application Logout button Controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### RemoveFilterItem_Click(sender,e) `method`

##### Summary

Full dynamic Remove Item from DataGrid advanced Filter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-SetServiceStop'></a>
### SetServiceStop() `method`

##### Summary

Server is unavailable All operations are blocked

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-MainWindow-ShowLoginDialog'></a>
### ShowLoginDialog() `method`

##### Summary

Application Login Dialog

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-MainWindow-ShowMessage-System-Boolean,System-String,System-Boolean-'></a>
### ShowMessage(error,message,confirm) `method`

##### Summary

Central Application Message Dialog for All Info / Error / other messages for User

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| error | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| confirm | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-GlobalNET-MainWindow-StringToFilter-System-Windows-Controls-ComboBox,System-String-'></a>
### StringToFilter(filterBox,advancedFilter) `method`

##### Summary

Full dynamic build filter on selected page from saved advanced filter

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filterBox | [System.Windows.Controls.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.ComboBox 'System.Windows.Controls.ComboBox') |  |
| advancedFilter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-MainWindow-SystemLoggerSourceChanged_Click-System-Object,System-EventArgs-'></a>
### SystemLoggerSourceChanged_Click(sender,e) `method`

##### Summary

System Logger Source Selector
Server Logger has Source From Client Settings by WebSocket URL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | The [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') instance containing the event data. |

<a name='M-GlobalNET-MainWindow-SystemTimerController-System-Object,System-Timers-ElapsedEventArgs-'></a>
### SystemTimerController(sender,e) `method`

##### Summary

Backend System Timer for check server connection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Timers.ElapsedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Timers.ElapsedEventArgs 'System.Timers.ElapsedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-TabPanelOnSelectionChange-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### TabPanelOnSelectionChange(sender,e) `method`

##### Summary

Tab click selection change reload ID and Pointers for ListView Buttons

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='M-GlobalNET-MainWindow-TiltOpenForm-System-String-'></a>
### TiltOpenForm(translateHeader) `method`

##### Summary

Tilts: Standardized Opening or create Tilt documents

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| translateHeader | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-GlobalNET-GlobalOperations-MathTypeOperations'></a>
## MathTypeOperations `type`

##### Namespace

GlobalNET.GlobalOperations

<a name='M-GlobalNET-GlobalOperations-MathTypeOperations-CheckTypeValue-System-String,System-String-'></a>
### CheckTypeValue() `method`

##### Summary

Global DataTypes Chwecker with Bool Result
Used on System Parameters

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-MaturityListPage'></a>
## MaturityListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

MaturityListPage

<a name='M-GlobalNET-Pages-MaturityListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalOperations-MediaOperations'></a>
## MediaOperations `type`

##### Namespace

GlobalNET.GlobalOperations

<a name='M-GlobalNET-GlobalOperations-MediaOperations-ArrayToImage-System-Byte[]-'></a>
### ArrayToImage(array) `method`

##### Summary

Cresate Bitmap Image from DB array to Image for show preview

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') |  |

<a name='M-GlobalNET-GlobalOperations-MediaOperations-GetImageImmediatelly-System-String-'></a>
### GetImageImmediatelly(path) `method`

##### Summary

Important Closing connections of openned files by Form and binding
this is solution for close oppened file after load
Solution for All Files

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-GlobalNET-Pages-MottoListPage'></a>
## MottoListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

MottoListPage

<a name='M-GlobalNET-Pages-MottoListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-DocumentationPage-MyCustomLifeSpanHandler'></a>
## MyCustomLifeSpanHandler `type`

##### Namespace

GlobalNET.Pages.DocumentationPage

<a name='T-GlobalNET-Pages-TemplateWebViewPage-MyCustomLifeSpanHandler'></a>
## MyCustomLifeSpanHandler `type`

##### Namespace

GlobalNET.Pages.TemplateWebViewPage

<a name='M-GlobalNET-Pages-DocumentationPage-MyCustomLifeSpanHandler-OnBeforePopup-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-IFrame,System-String,System-String,CefSharp-WindowOpenDisposition,System-Boolean,CefSharp-IPopupFeatures,CefSharp-IWindowInfo,CefSharp-IBrowserSettings,System-Boolean@,CefSharp-IWebBrowser@-'></a>
### OnBeforePopup(chromiumWebBrowser,browser,frame,targetUrl,targetFrameName,targetDisposition,userGesture,popupFeatures,windowInfo,browserSettings,noJavascriptAccess,newBrowser) `method`

##### Summary

Block open New Solo Window Frame as popup

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chromiumWebBrowser | [CefSharp.IWebBrowser](#T-CefSharp-IWebBrowser 'CefSharp.IWebBrowser') |  |
| browser | [CefSharp.IBrowser](#T-CefSharp-IBrowser 'CefSharp.IBrowser') |  |
| frame | [CefSharp.IFrame](#T-CefSharp-IFrame 'CefSharp.IFrame') |  |
| targetUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| targetFrameName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| targetDisposition | [CefSharp.WindowOpenDisposition](#T-CefSharp-WindowOpenDisposition 'CefSharp.WindowOpenDisposition') |  |
| userGesture | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| popupFeatures | [CefSharp.IPopupFeatures](#T-CefSharp-IPopupFeatures 'CefSharp.IPopupFeatures') |  |
| windowInfo | [CefSharp.IWindowInfo](#T-CefSharp-IWindowInfo 'CefSharp.IWindowInfo') |  |
| browserSettings | [CefSharp.IBrowserSettings](#T-CefSharp-IBrowserSettings 'CefSharp.IBrowserSettings') |  |
| noJavascriptAccess | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') |  |
| newBrowser | [CefSharp.IWebBrowser@](#T-CefSharp-IWebBrowser@ 'CefSharp.IWebBrowser@') |  |

<a name='M-GlobalNET-Pages-TemplateWebViewPage-MyCustomLifeSpanHandler-OnBeforePopup-CefSharp-IWebBrowser,CefSharp-IBrowser,CefSharp-IFrame,System-String,System-String,CefSharp-WindowOpenDisposition,System-Boolean,CefSharp-IPopupFeatures,CefSharp-IWindowInfo,CefSharp-IBrowserSettings,System-Boolean@,CefSharp-IWebBrowser@-'></a>
### OnBeforePopup(chromiumWebBrowser,browser,frame,targetUrl,targetFrameName,targetDisposition,userGesture,popupFeatures,windowInfo,browserSettings,noJavascriptAccess,newBrowser) `method`

##### Summary

Block open New Solo Window Frame as popup

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chromiumWebBrowser | [CefSharp.IWebBrowser](#T-CefSharp-IWebBrowser 'CefSharp.IWebBrowser') |  |
| browser | [CefSharp.IBrowser](#T-CefSharp-IBrowser 'CefSharp.IBrowser') |  |
| frame | [CefSharp.IFrame](#T-CefSharp-IFrame 'CefSharp.IFrame') |  |
| targetUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| targetFrameName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| targetDisposition | [CefSharp.WindowOpenDisposition](#T-CefSharp-WindowOpenDisposition 'CefSharp.WindowOpenDisposition') |  |
| userGesture | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| popupFeatures | [CefSharp.IPopupFeatures](#T-CefSharp-IPopupFeatures 'CefSharp.IPopupFeatures') |  |
| windowInfo | [CefSharp.IWindowInfo](#T-CefSharp-IWindowInfo 'CefSharp.IWindowInfo') |  |
| browserSettings | [CefSharp.IBrowserSettings](#T-CefSharp-IBrowserSettings 'CefSharp.IBrowserSettings') |  |
| noJavascriptAccess | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') |  |
| newBrowser | [CefSharp.IWebBrowser@](#T-CefSharp-IWebBrowser@ 'CefSharp.IWebBrowser@') |  |

<a name='T-GlobalNET-Pages-NotesListPage'></a>
## NotesListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

NotesListPage

<a name='M-GlobalNET-Pages-NotesListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-OfferListPage'></a>
## OfferListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

OfferListPage

<a name='M-GlobalNET-Pages-OfferListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-OperationListPage'></a>
## OperationListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

OperationListPage

<a name='M-GlobalNET-Pages-OperationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-OutgoingInvoiceListPage'></a>
## OutgoingInvoiceListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

OutgoingInvoiceListPage

<a name='M-GlobalNET-Pages-OutgoingInvoiceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-OutgoingOrderListPage'></a>
## OutgoingOrderListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

OutgoingOrderListPage

<a name='M-GlobalNET-Pages-OutgoingOrderListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ParameterListPage'></a>
## ParameterListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ParameterListPage

<a name='M-GlobalNET-Pages-ParameterListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-PartListPage'></a>
## PartListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

PartListPage

<a name='M-GlobalNET-Pages-PartListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-PaymentMethodListPage'></a>
## PaymentMethodListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

PaymentMethodListPage

<a name='M-GlobalNET-Pages-PaymentMethodListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-PaymentStatusListPage'></a>
## PaymentStatusListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

PaymentStatusListPage

<a name='M-GlobalNET-Pages-PaymentStatusListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-PersonListPage'></a>
## PersonListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

PersonListPage

<a name='M-GlobalNET-Pages-PersonListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ReceiptListPage'></a>
## ReceiptListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ReceiptListPage

<a name='M-GlobalNET-Pages-ReceiptListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ReportListPage'></a>
## ReportListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ReportListPage

<a name='M-GlobalNET-Pages-ReportListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ReportQueueListPage'></a>
## ReportQueueListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ReportQueueListPage

<a name='M-GlobalNET-Pages-ReportQueueListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Classes-ReportSelection'></a>
## ReportSelection `type`

##### Namespace

GlobalNET.Classes

##### Summary

Report naming support

<a name='T-GlobalNET-Properties-Resources'></a>
## Resources `type`

##### Namespace

GlobalNET.Properties

##### Summary

Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.

<a name='P-GlobalNET-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
  vyhledání prostředků pomocí třídy prostředků se silnými typy.

<a name='P-GlobalNET-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.

<a name='P-GlobalNET-Properties-Resources-no_photo'></a>
### no_photo `property`

##### Summary

Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.

<a name='T-GlobalNET-Pages-ScreenSaverPage'></a>
## ScreenSaverPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ScreenSaverPage

<a name='M-GlobalNET-Pages-ScreenSaverPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Classes-ServerSettingKeys'></a>
## ServerSettingKeys `type`

##### Namespace

GlobalNET.Classes

##### Summary

Server Configuration definition for Backend API  EASYDATACenter

<a name='T-GlobalNET-Pages-ServerSettingPage'></a>
## ServerSettingPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ServerSettingPage

<a name='M-GlobalNET-Pages-ServerSettingPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-SupportPage'></a>
## SupportPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

SupportPage

<a name='M-GlobalNET-Pages-SupportPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-SvgIconListPage'></a>
## SvgIconListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

SvgIconListPage

<a name='M-GlobalNET-Pages-SvgIconListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-SystemFailListPage'></a>
## SystemFailListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

SystemFailListPage

<a name='M-GlobalNET-Pages-SystemFailListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-SystemHelper-SystemLoggerHelper'></a>
## SystemLoggerHelper `type`

##### Namespace

GlobalNET.SystemHelper

##### Summary

System Logger Helper
Defined Central WebSocket Monitor Controller

<a name='M-GlobalNET-SystemHelper-SystemLoggerHelper-DisposeSystemLoggerWebSocketMonitor'></a>
### DisposeSystemLoggerWebSocketMonitor() `method`

##### Summary

Disable Server Logger When the System logger is enabled

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-SystemHelper-SystemLoggerHelper-SystemLoggerWebSocketMonitorOnOff'></a>
### SystemLoggerWebSocketMonitorOnOff() `method`

##### Summary

Systems the logger web socket monitor on/off.
Full Control For Server WebSocket Logger

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-SystemHelper-SystemLoggerWebSocketClass'></a>
## SystemLoggerWebSocketClass `type`

##### Namespace

GlobalNET.SystemHelper

##### Summary

System Logger WebSocket Monitor Controller Class Definition
For Centralized Using

<a name='T-GlobalNET-GlobalOperations-SystemOperations'></a>
## SystemOperations `type`

##### Namespace

GlobalNET.GlobalOperations

##### Summary

Centralised System Functions for work with
Types, methods, Formats, Logic, supported methods

<a name='M-GlobalNET-GlobalOperations-SystemOperations-FilterToString-System-Windows-Controls-ComboBox-'></a>
### FilterToString(filterBox) `method`

##### Summary

SYSTEM Advanced Filter Conversion for API
return existing filter for saving to string in selected Page

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filterBox | [System.Windows.Controls.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.ComboBox 'System.Windows.Controls.ComboBox') |  |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-GetExceptionMessages-System-Exception,System-Int32-'></a>
### GetExceptionMessages(exception,msgCount) `method`

##### Summary

Mining All Exception Information For Central System Logger
Ignore Some selected Fails is possible by Ignored Exception Settings

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-GetExceptionMessagesAll-System-Exception,System-Int32-'></a>
### GetExceptionMessagesAll(exception,msgCount) `method`

##### Summary

Mining All Exception Information For Local System Logger
EveryTime Show All fails for Best Developing On Expert Level

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-IncreaseFileVersionBuild'></a>
### IncreaseFileVersionBuild() `method`

##### Summary

Automatic Increase version System
Ideal for small systems with more release in 1 day
Increase Windows Correct 3 position for Widows Installation
In Debug is increase last 4 position

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-GlobalOperations-SystemOperations-RandomString-System-Int32-'></a>
### RandomString(length) `method`

##### Summary

Generate Random String with defined length

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-RemoveAppNamespaceFromString-System-String-'></a>
### RemoveAppNamespaceFromString(stringForRemoveNamespace) `method`

##### Summary

Its Solution for this is a solution for demanding and multiplied servers
Or Running SHARP and Test System By One Backend Server Service
API Urls with Namespaces in Name are for Backend model with More Same Database Schemas
Backend Databases count in One Server Service is Unlimited

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringForRemoveNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-SendMailWithMailTo-System-String,System-String,System-String,System-String-'></a>
### SendMailWithMailTo(address,subject,body,attach) `method`

##### Summary

System Mail sending

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| subject | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| attach | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-SendMailWithServerSetting-System-String-'></a>
### SendMailWithServerSetting(message) `method`

##### Summary

Email Sender for send Direct Email by Server Configuration for Testing

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-SetLanguageDictionary-System-Windows-ResourceDictionary,System-String-'></a>
### SetLanguageDictionary(Resources,languageDefault) `method`

##### Summary

Settings Local Application Translation dictionaries (Resources Files) for Pages
Will be replaced by DBDictionary, but for Offline Running must be possible

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Resources | [System.Windows.ResourceDictionary](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.ResourceDictionary 'System.Windows.ResourceDictionary') |  |
| languageDefault | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-GlobalOperations-SystemOperations-StartExternalProccess-System-String,System-String,System-String,System-String-'></a>
### StartExternalProccess(fullFilePath,startupPath,arguments) `method`

##### Summary

System External Process Starter for Conrtalized Using
Return the processId when is started or null

TODO
- create process Monitor
- save the monitored procceses to System Monitor
- must be refactored actual status

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The full file path. |
| startupPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The startup path. |
| arguments | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The arguments. |

<a name='T-GlobalNET-GlobalClasses-SystemStatuses'></a>
## SystemStatuses `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

!!SYSTEM Global Definition for System Statuses

SYSTEM Running mode
In debug mode is disabled the System Logger
Visual Studio Debugger difficult operation has problem
If you want you can enable SystemLogger by change to: DebugWithSystemLogger

Its Used as String EveryWhere
Its good Soution for Centarized Statuses of System
Errors Are Saved In SystemLogger or Database

<a name='T-GlobalNET-SystemStructure-SystemWindowDataModel'></a>
## SystemWindowDataModel `type`

##### Namespace

GlobalNET.SystemStructure

<a name='M-GlobalNET-SystemStructure-SystemWindowDataModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Its Solution For MultiInstance Application
If The InterTab Is Enabled Can be Dragged Tab To the New Application

##### Parameters

This constructor has no parameters.

<a name='T-GlobalNET-Pages-TemplateClassListPage'></a>
## TemplateClassListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateClassListPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
 Manual work needed Translate All XAML fields by Resources
 Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateClassListPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
 this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
 All is setted as global Classes for All Pages and Work is Fully automatized by System core

<a name='M-GlobalNET-Pages-TemplateClassListPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Delete button Click
Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that is only for Select record
This is full automatic, not needed manual work
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data)
Manual Changing is needed for set Translate of Column Names via Dictionary Items
Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Edit button Click
Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the simple 'Search Input' for DatagidView (List Data)
Manual Changing is needed of filtered columns by Search Value
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with pages Called from MainWindow.cs
Dynamicaly Called Only from MainWindow.cs when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-Pages-TemplateClassListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data.
 Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
 Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
 This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
 this method is for global working with pages Called from MainWindow.cs on Refresh button click
 Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on New button Click
Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateClassListViewPage'></a>
## TemplateClassListViewPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateClassListViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateClassListViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
 this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
 All is setted as global Classes for All Pages and Work is Fully automatized by System core

<a name='M-GlobalNET-Pages-TemplateClassListViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that is only for Select record
This is full automatic, not needed manual work
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListViewPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data)
Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListViewPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the simple 'Search Input' for DatagidView (List Data)
Here you define which column of Dataset will be filtered
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with pages Called from MainWindow.cs
Dynamicaly Called Only from MainWindow.cs when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-Pages-TemplateClassListViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListViewPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data.
 Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
 Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
 This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
 this method is for global working with pages Called from MainWindow.cs on Refresh button click
 Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateClassListWithSubPage'></a>
## TemplateClassListWithSubPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
 Manual work needed Translate All XAML fields by Resources
 Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateClassListWithSubPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
 this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
 All is setted as global Classes for All Pages and Work is Fully automatized by System core

 HERE you Define All Data Variables For This Form

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-ClearItemsFields'></a>
### ClearItemsFields() `method`

##### Summary

Standartized Method for Clear SubRecord Input Fields with custom Dataset
For Correct Using must be Fields changed for used dataset

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### Customer_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Delete button Click
Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that is only for Select record
This is full automatic, not needed manual work
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data)
Manual Changing is needed for set Translate of Column Names via Dictionary Items
Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
### DgSubListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of SubDatagidView (List Data)
Manual Changing is needed for set Translate of Column Names via Dictionary Items
Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Edit button Click
Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the simple 'Search Input' for DatagidView (List Data)
Manual Changing is needed of filtered columns by Search Value
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with pages Called from MainWindow.cs
Dynamicaly Called Only from MainWindow.cs when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data.
 Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
 Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
 This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
 this method is for global working with pages Called from MainWindow.cs on Refresh button click
 Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on New button Click
Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### NotesChanged(sender,e) `method`

##### Summary

Standartized Maximal Simle Code with Reaction and Fill input After ParentComboboxSelection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### PartNumberGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in Combobox
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### PartNumber_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectCustomer_Enter(sender,e) `method`

##### Summary

Standartized methods with Indicate Customer Selection and Start Filling Input
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### SelectGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in Combobox
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectPartNumber_Enter(sender,e) `method`

##### Summary

Standartized methods with Indicate Customer Selection and Start Filling Input
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-SetCustomer'></a>
### SetCustomer(sender,e) `method`

##### Summary

Standartized methods For Filling Input after Selection
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [M:GlobalNET.Pages.TemplateClassListWithSubPage.SetCustomer](#T-M-GlobalNET-Pages-TemplateClassListWithSubPage-SetCustomer 'M:GlobalNET.Pages.TemplateClassListWithSubPage.SetCustomer') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-SetPartNumber'></a>
### SetPartNumber(sender,e) `method`

##### Summary

Standartized methods For Filling Input after Selection
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [M:GlobalNET.Pages.TemplateClassListWithSubPage.SetPartNumber](#T-M-GlobalNET-Pages-TemplateClassListWithSubPage-SetPartNumber 'M:GlobalNET.Pages.TemplateClassListWithSubPage.SetPartNumber') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean-'></a>
### SetSubListsNonActiveOnNewItem() `method`

##### Summary

Standartized Method for Load All SubData which is needed for Working with SubRecord
For Correct Using must be changed for actual datasets

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-UpdateCustomerSearchResults'></a>
### UpdateCustomerSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value
This is full automatic, not needed manual work

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubPage-UpdatePartNumberSearchResults'></a>
### UpdatePartNumberSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value
This is full automatic, not needed manual work

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateClassListWithSubViewPage'></a>
## TemplateClassListWithSubViewPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
 Manual work needed Translate All XAML fields by Resources
 Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateClassListWithSubViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
 this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
 All is setted as global Classes for All Pages and Work is Fully automatized by System core

 HERE you Define All Data Variables For This Form

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Delete button Click
Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that is only for Select record
This is full automatic, not needed manual work
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data)
Manual Changing is needed for set Translate of Column Names via Dictionary Items
Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
### DgSubListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of SubDatagidView (List Data)
Manual Changing is needed for set Translate of Column Names via Dictionary Items
Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Edit button Click
Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the simple 'Search Input' for DatagidView (List Data)
Manual Changing is needed of filtered columns by Search Value
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
this method is for global working with pages Called from MainWindow.cs
Dynamicaly Called Only from MainWindow.cs when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data.
 Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
 Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
 This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
 this method is for global working with pages Called from MainWindow.cs on Refresh button click
 Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-LoadSubDataList'></a>
### LoadSubDataList() `method`

##### Summary

Standartized Method for Loading SubData.
 Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
 Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
 This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
 this method is for global working with pages Called from MainWindow.cs on Refresh button click
 Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateClassListWithSubViewPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on New button Click
Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateDocumentViewPage'></a>
## TemplateDocumentViewPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

Template Page For View document, pictures, text and and much more file formats opened in WebViewer

<a name='M-GlobalNET-Pages-TemplateDocumentViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and direct show example file

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateDocumentViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-GlobalNET-Pages-TemplateDocumentViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateSTLPage'></a>
## TemplateSTLPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

TemplateSTLPage

<a name='F-GlobalNET-Pages-TemplateSTLPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-GlobalNET-Pages-TemplateSTLPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateSettingsPage'></a>
## TemplateSettingsPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

TemplateSettingsPage

<a name='M-GlobalNET-Pages-TemplateSettingsPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
 Manual work needed Translate All XAML fields by Resources
 Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateSettingsPage-Languages'></a>
### Languages `constants`

##### Summary

Define Collection For Combobox

<a name='F-GlobalNET-Pages-TemplateSettingsPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-GlobalNET-Pages-TemplateSettingsPage-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnApiTest_Click(sender,e) `method`

##### Summary

Customized GET Call

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateSettingsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateVideoPage'></a>
## TemplateVideoPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

TemplateVideoPage

<a name='F-GlobalNET-Pages-TemplateVideoPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-GlobalNET-Pages-TemplateVideoPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateWebViewPage'></a>
## TemplateWebViewPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

Template Page For internet pages document, pictures, text and and much more file formats opened in WebViewer

<a name='M-GlobalNET-Pages-TemplateWebViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and direct show example file

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateWebViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-GlobalNET-Pages-TemplateWebViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TerminalPage'></a>
## TerminalPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

TerminalPage

<a name='M-GlobalNET-Pages-TerminalPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-TiltTargets'></a>
## TiltTargets `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Tilt Document Types Definitions

<a name='T-GlobalNET-Pages-ToolPanelDefinitionListPage'></a>
## ToolPanelDefinitionListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ToolPanelDefinitionListPage

<a name='M-GlobalNET-Pages-ToolPanelDefinitionListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-ToolPanelListPage'></a>
## ToolPanelListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ToolPanelListPage

<a name='M-GlobalNET-Pages-ToolPanelListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-TranslatedApiList'></a>
## TranslatedApiList `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Class for Using as customized list the List of API urls
for Central using in the system
One Api is One: Dataview / Right / Report Posibility / Menu Item / Page
Exist rules for automatic processing in System Core Logic for simple Developing

<a name='T-GlobalNET-Pages-UnitListPage'></a>
## UnitListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

UnitListPage

<a name='M-GlobalNET-Pages-UnitListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-UpdateVariant'></a>
## UpdateVariant `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Global class for using Name/Value - Example Reports, Language and others

<a name='T-GlobalNET-Pages-UsedLicenseListPage'></a>
## UsedLicenseListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

UsedLicenseListPage

<a name='M-GlobalNET-Pages-UsedLicenseListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-GlobalClasses-UserData'></a>
## UserData `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Basic user data for login

<a name='T-GlobalNET-Pages-UserListPage'></a>
## UserListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

UserListPage

<a name='M-GlobalNET-Pages-UserListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-UserRoleListPage'></a>
## UserRoleListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

UserRoleListPage

<a name='M-GlobalNET-Pages-UserRoleListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-VatListPage'></a>
## VatListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

VatListPage

<a name='M-GlobalNET-Pages-VatListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-WarehouseListPage'></a>
## WarehouseListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

WarehouseListPage

<a name='M-GlobalNET-Pages-WarehouseListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-WelcomePage'></a>
## WelcomePage `type`

##### Namespace

GlobalNET.Pages

##### Summary

WelcomePage

<a name='M-GlobalNET-Pages-WelcomePage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-WorkListPage'></a>
## WorkListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

WorkListPage

<a name='M-GlobalNET-Pages-WorkListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.
