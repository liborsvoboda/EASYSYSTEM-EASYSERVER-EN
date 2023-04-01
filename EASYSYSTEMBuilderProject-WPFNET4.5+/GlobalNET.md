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
  - [TiltReceiptDoc](#F-GlobalNET-App-TiltReceiptDoc 'GlobalNET.App.TiltReceiptDoc')
  - [log](#F-GlobalNET-App-log 'GlobalNET.App.log')
  - [InitializeComponent()](#M-GlobalNET-App-InitializeComponent 'GlobalNET.App.InitializeComponent')
  - [Main()](#M-GlobalNET-App-Main 'GlobalNET.App.Main')
  - [OnStartup(e)](#M-GlobalNET-App-OnStartup-System-Windows-StartupEventArgs- 'GlobalNET.App.OnStartup(System.Windows.StartupEventArgs)')
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
- [CrashReporterGlobalField](#T-GlobalNET-Helper-CrashReporterGlobalField 'GlobalNET.Helper.CrashReporterGlobalField')
  - [_ReportCrash](#F-GlobalNET-Helper-CrashReporterGlobalField-_ReportCrash 'GlobalNET.Helper.CrashReporterGlobalField._ReportCrash')
- [CreditNoteListPage](#T-GlobalNET-Pages-CreditNoteListPage 'GlobalNET.Pages.CreditNoteListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-CreditNoteListPage-InitializeComponent 'GlobalNET.Pages.CreditNoteListPage.InitializeComponent')
- [CurrencyListPage](#T-GlobalNET-Pages-CurrencyListPage 'GlobalNET.Pages.CurrencyListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-CurrencyListPage-InitializeComponent 'GlobalNET.Pages.CurrencyListPage.InitializeComponent')
- [DBResultMessage](#T-GlobalNET-Api-DBResultMessage 'GlobalNET.Api.DBResultMessage')
- [DataViewSupport](#T-GlobalNET-Classes-DataViewSupport 'GlobalNET.Classes.DataViewSupport')
- [DocumentAdviceListPage](#T-GlobalNET-Pages-DocumentAdviceListPage 'GlobalNET.Pages.DocumentAdviceListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-DocumentAdviceListPage-InitializeComponent 'GlobalNET.Pages.DocumentAdviceListPage.InitializeComponent')
- [DocumentTypeListPage](#T-GlobalNET-Pages-DocumentTypeListPage 'GlobalNET.Pages.DocumentTypeListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-DocumentTypeListPage-InitializeComponent 'GlobalNET.Pages.DocumentTypeListPage.InitializeComponent')
- [DocumentationPage](#T-GlobalNET-Pages-DocumentationPage 'GlobalNET.Pages.DocumentationPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-DocumentationPage-InitializeComponent 'GlobalNET.Pages.DocumentationPage.InitializeComponent')
- [ExchangeRateListPage](#T-GlobalNET-Pages-ExchangeRateListPage 'GlobalNET.Pages.ExchangeRateListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ExchangeRateListPage-InitializeComponent 'GlobalNET.Pages.ExchangeRateListPage.InitializeComponent')
- [ExtendedTemplateClassList](#T-GlobalNET-Classes-ExtendedTemplateClassList 'GlobalNET.Classes.ExtendedTemplateClassList')
- [FileFunctions](#T-GlobalNET-GlobalFunctions-FileFunctions 'GlobalNET.GlobalFunctions.FileFunctions')
  - [VncServerIniFile(path)](#M-GlobalNET-GlobalFunctions-FileFunctions-VncServerIniFile-System-String- 'GlobalNET.GlobalFunctions.FileFunctions.VncServerIniFile(System.String)')
- [GeneratedInternalTypeHelper](#T-XamlGeneratedNamespace-GeneratedInternalTypeHelper 'XamlGeneratedNamespace.GeneratedInternalTypeHelper')
  - [AddEventHandler()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.AddEventHandler(System.Reflection.EventInfo,System.Object,System.Delegate)')
  - [CreateDelegate()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateDelegate(System.Type,System.Object,System.String)')
  - [CreateInstance()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateInstance(System.Type,System.Globalization.CultureInfo)')
  - [GetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.GetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Globalization.CultureInfo)')
  - [SetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.SetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Object,System.Globalization.CultureInfo)')
- [GraphsPage](#T-GlobalNET-Pages-GraphsPage 'GlobalNET.Pages.GraphsPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-GraphsPage-InitializeComponent 'GlobalNET.Pages.GraphsPage.InitializeComponent')
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
  - [metroWindowClosing](#F-GlobalNET-MainWindow-metroWindowClosing 'GlobalNET.MainWindow.metroWindowClosing')
  - [VncRunning](#P-GlobalNET-MainWindow-VncRunning 'GlobalNET.MainWindow.VncRunning')
  - [Cb_PrintReportsSelected(sender,e)](#M-GlobalNET-MainWindow-Cb_PrintReportsSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.MainWindow.Cb_PrintReportsSelected(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [FilterField_SelectionChanged(sender,e)](#M-GlobalNET-MainWindow-FilterField_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.MainWindow.FilterField_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-MainWindow-InitializeComponent 'GlobalNET.MainWindow.InitializeComponent')
  - [IpKeyboardClick(sender,e)](#M-GlobalNET-MainWindow-IpKeyboardClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.MainWindow.IpKeyboardClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [MainGrid_IsDraggingChanged(sender,e)](#M-GlobalNET-MainWindow-MainGrid_IsDraggingChanged-System-Object,System-Windows-RoutedPropertyChangedEventArgs{System-Boolean}- 'GlobalNET.MainWindow.MainGrid_IsDraggingChanged(System.Object,System.Windows.RoutedPropertyChangedEventArgs{System.Boolean})')
  - [Menu_action_Click(sender,e)](#M-GlobalNET-MainWindow-Menu_action_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Menu_action_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Mi_filter_Click(sender,e)](#M-GlobalNET-MainWindow-Mi_filter_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Mi_filter_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [RemoveFilterItem_Click(sender,e)](#M-GlobalNET-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.RemoveFilterItem_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [StringToFilter(filterBox,advancedFilter)](#M-GlobalNET-MainWindow-StringToFilter-System-Windows-Controls-ComboBox,System-String- 'GlobalNET.MainWindow.StringToFilter(System.Windows.Controls.ComboBox,System.String)')
  - [TiltOpenForm(translateHeader)](#M-GlobalNET-MainWindow-TiltOpenForm-System-String- 'GlobalNET.MainWindow.TiltOpenForm(System.String)')
  - [cb_FilterDropDownClosed(sender,e)](#M-GlobalNET-MainWindow-cb_FilterDropDownClosed-System-Object,System-EventArgs- 'GlobalNET.MainWindow.cb_FilterDropDownClosed(System.Object,System.EventArgs)')
- [MaturityListPage](#T-GlobalNET-Pages-MaturityListPage 'GlobalNET.Pages.MaturityListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-MaturityListPage-InitializeComponent 'GlobalNET.Pages.MaturityListPage.InitializeComponent')
- [NotesListPage](#T-GlobalNET-Pages-NotesListPage 'GlobalNET.Pages.NotesListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-NotesListPage-InitializeComponent 'GlobalNET.Pages.NotesListPage.InitializeComponent')
- [OfferListPage](#T-GlobalNET-Pages-OfferListPage 'GlobalNET.Pages.OfferListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OfferListPage-InitializeComponent 'GlobalNET.Pages.OfferListPage.InitializeComponent')
- [OutgoingInvoiceListPage](#T-GlobalNET-Pages-OutgoingInvoiceListPage 'GlobalNET.Pages.OutgoingInvoiceListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OutgoingInvoiceListPage-InitializeComponent 'GlobalNET.Pages.OutgoingInvoiceListPage.InitializeComponent')
- [OutgoingOrderListPage](#T-GlobalNET-Pages-OutgoingOrderListPage 'GlobalNET.Pages.OutgoingOrderListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-OutgoingOrderListPage-InitializeComponent 'GlobalNET.Pages.OutgoingOrderListPage.InitializeComponent')
- [PageTemplatesCodeHelp](#T-GlobalNET-Templates-PageTemplatesCodeHelp 'GlobalNET.Templates.PageTemplatesCodeHelp')
  - [Languages](#F-GlobalNET-Templates-PageTemplatesCodeHelp-Languages 'GlobalNET.Templates.PageTemplatesCodeHelp.Languages')
  - [BtnApiTest_Click(sender,e)](#M-GlobalNET-Templates-PageTemplatesCodeHelp-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Templates.PageTemplatesCodeHelp.BtnApiTest_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [DefinedAllAplicationApiComunicationTypes()](#M-GlobalNET-Templates-PageTemplatesCodeHelp-DefinedAllAplicationApiComunicationTypes 'GlobalNET.Templates.PageTemplatesCodeHelp.DefinedAllAplicationApiComunicationTypes')
  - [DefinedGlobalMainWindowMethodsForAllPages()](#M-GlobalNET-Templates-PageTemplatesCodeHelp-DefinedGlobalMainWindowMethodsForAllPages 'GlobalNET.Templates.PageTemplatesCodeHelp.DefinedGlobalMainWindowMethodsForAllPages')
  - [NumberValidationTextBox(sender,e)](#M-GlobalNET-Templates-PageTemplatesCodeHelp-NumberValidationTextBox-System-Object,System-Windows-Input-TextCompositionEventArgs- 'GlobalNET.Templates.PageTemplatesCodeHelp.NumberValidationTextBox(System.Object,System.Windows.Input.TextCompositionEventArgs)')
  - [UsedSpecificMethodsForCustomizedWorking()](#M-GlobalNET-Templates-PageTemplatesCodeHelp-UsedSpecificMethodsForCustomizedWorking 'GlobalNET.Templates.PageTemplatesCodeHelp.UsedSpecificMethodsForCustomizedWorking')
- [ParameterListPage](#T-GlobalNET-Pages-ParameterListPage 'GlobalNET.Pages.ParameterListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ParameterListPage-InitializeComponent 'GlobalNET.Pages.ParameterListPage.InitializeComponent')
- [Parameters](#T-GlobalNET-GlobalClasses-Parameters 'GlobalNET.GlobalClasses.Parameters')
- [PaymentMethodListPage](#T-GlobalNET-Pages-PaymentMethodListPage 'GlobalNET.Pages.PaymentMethodListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-PaymentMethodListPage-InitializeComponent 'GlobalNET.Pages.PaymentMethodListPage.InitializeComponent')
- [PaymentStatusListPage](#T-GlobalNET-Pages-PaymentStatusListPage 'GlobalNET.Pages.PaymentStatusListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-PaymentStatusListPage-InitializeComponent 'GlobalNET.Pages.PaymentStatusListPage.InitializeComponent')
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
- [ServerSettingKeys](#T-GlobalNET-GlobalClasses-ServerSettingKeys 'GlobalNET.GlobalClasses.ServerSettingKeys')
- [ServerSettingPage](#T-GlobalNET-Pages-ServerSettingPage 'GlobalNET.Pages.ServerSettingPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ServerSettingPage-InitializeComponent 'GlobalNET.Pages.ServerSettingPage.InitializeComponent')
- [SupportPage](#T-GlobalNET-Pages-SupportPage 'GlobalNET.Pages.SupportPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-SupportPage-InitializeComponent 'GlobalNET.Pages.SupportPage.InitializeComponent')
- [SystemFailListPage](#T-GlobalNET-Pages-SystemFailListPage 'GlobalNET.Pages.SystemFailListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-SystemFailListPage-InitializeComponent 'GlobalNET.Pages.SystemFailListPage.InitializeComponent')
- [SystemFunctions](#T-GlobalNET-GlobalFunctions-SystemFunctions 'GlobalNET.GlobalFunctions.SystemFunctions')
  - [FilterToString(filterBox)](#M-GlobalNET-GlobalFunctions-SystemFunctions-FilterToString-System-Windows-Controls-ComboBox- 'GlobalNET.GlobalFunctions.SystemFunctions.FilterToString(System.Windows.Controls.ComboBox)')
  - [ParameterCheck(parameterName)](#M-GlobalNET-GlobalFunctions-SystemFunctions-ParameterCheck-System-String- 'GlobalNET.GlobalFunctions.SystemFunctions.ParameterCheck(System.String)')
- [TemplateClassList](#T-GlobalNET-Classes-TemplateClassList 'GlobalNET.Classes.TemplateClassList')
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
- [ToolPanelPage](#T-GlobalNET-Pages-ToolPanelPage 'GlobalNET.Pages.ToolPanelPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ToolPanelPage-InitializeComponent 'GlobalNET.Pages.ToolPanelPage.InitializeComponent')
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

Application Error handlers

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-App-TiltReceiptDoc'></a>
### TiltReceiptDoc `constants`

##### Summary

Tilt Document type definitions

<a name='F-GlobalNET-App-log'></a>
### log `constants`

##### Summary

Global Application Startup Settings

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

Class for User Authentification information

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

<a name='T-GlobalNET-Helper-CrashReporterGlobalField'></a>
## CrashReporterGlobalField `type`

##### Namespace

GlobalNET.Helper

##### Summary

Libreria condivisa

<a name='F-GlobalNET-Helper-CrashReporterGlobalField-_ReportCrash'></a>
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

<a name='T-GlobalNET-Api-DBResultMessage'></a>
## DBResultMessage `type`

##### Namespace

GlobalNET.Api

##### Summary

Definition of Result API calls for Insert / Update / Delete

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

<a name='T-GlobalNET-Classes-ExtendedTemplateClassList'></a>
## ExtendedTemplateClassList `type`

##### Namespace

GlobalNET.Classes

##### Summary

Example of extended Table dataset for user friendly

<a name='T-GlobalNET-GlobalFunctions-FileFunctions'></a>
## FileFunctions `type`

##### Namespace

GlobalNET.GlobalFunctions

<a name='M-GlobalNET-GlobalFunctions-FileFunctions-VncServerIniFile-System-String-'></a>
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

<a name='F-GlobalNET-MainWindow-metroWindowClosing'></a>
### metroWindowClosing `constants`

##### Summary

MainControls Screen Variables

<a name='P-GlobalNET-MainWindow-VncRunning'></a>
### VncRunning `property`

##### Summary

MainWindow Controller Statuses

<a name='M-GlobalNET-MainWindow-Cb_PrintReportsSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### Cb_PrintReportsSelected(sender,e) `method`

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

Full dynamic set sign datagrid advanced filter type

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

<a name='M-GlobalNET-MainWindow-IpKeyboardClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### IpKeyboardClick(sender,e) `method`

##### Summary

System tools controllers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-GlobalNET-MainWindow-MainGrid_IsDraggingChanged-System-Object,System-Windows-RoutedPropertyChangedEventArgs{System-Boolean}-'></a>
### MainGrid_IsDraggingChanged(sender,e) `method`

##### Summary

Draging and separate to more App: TabPanel drag Controller - not Used

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedPropertyChangedEventArgs{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedPropertyChangedEventArgs 'System.Windows.RoutedPropertyChangedEventArgs{System.Boolean}') |  |

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

Full dynamic Show/Hidden datagrid advanced Filter Menu

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### RemoveFilterItem_Click(sender,e) `method`

##### Summary

Full dynamic Remove Item from datagrid advanced Filter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

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

<a name='M-GlobalNET-MainWindow-TiltOpenForm-System-String-'></a>
### TiltOpenForm(translateHeader) `method`

##### Summary

Tilts: Standardized Opening or create Tilt documents

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| translateHeader | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GlobalNET-MainWindow-cb_FilterDropDownClosed-System-Object,System-EventArgs-'></a>
### cb_FilterDropDownClosed(sender,e) `method`

##### Summary

Full dynamic apply setted filter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

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

<a name='T-GlobalNET-Templates-PageTemplatesCodeHelp'></a>
## PageTemplatesCodeHelp `type`

##### Namespace

GlobalNET.Templates

##### Summary

Library with standarztized Definitions and Methods For Develop Any System

<a name='F-GlobalNET-Templates-PageTemplatesCodeHelp-Languages'></a>
### Languages `constants`

##### Summary

Define Collection For Combobox Example

<a name='M-GlobalNET-Templates-PageTemplatesCodeHelp-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnApiTest_Click(sender,e) `method`

##### Summary

Customized GET Call

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Templates-PageTemplatesCodeHelp-DefinedAllAplicationApiComunicationTypes'></a>
### DefinedAllAplicationApiComunicationTypes() `method`

##### Summary

Global Application Defined API Communication Types for Centalised using

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Templates-PageTemplatesCodeHelp-DefinedGlobalMainWindowMethodsForAllPages'></a>
### DefinedGlobalMainWindowMethodsForAllPages() `method`

##### Summary

Global Application avaiable Methods for All Pages for Centalised using

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Templates-PageTemplatesCodeHelp-NumberValidationTextBox-System-Object,System-Windows-Input-TextCompositionEventArgs-'></a>
### NumberValidationTextBox(sender,e) `method`

##### Summary

Special Method for input limitation as number only
Its only for help

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.TextCompositionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.TextCompositionEventArgs 'System.Windows.Input.TextCompositionEventArgs') |  |

<a name='M-GlobalNET-Templates-PageTemplatesCodeHelp-UsedSpecificMethodsForCustomizedWorking'></a>
### UsedSpecificMethodsForCustomizedWorking() `method`

##### Summary

Global Specific Methods For Customized Working

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

<a name='T-GlobalNET-GlobalClasses-Parameters'></a>
## Parameters `type`

##### Namespace

GlobalNET.GlobalClasses

##### Summary

Parameters Definition Class for special application settings

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

<a name='T-GlobalNET-GlobalClasses-ServerSettingKeys'></a>
## ServerSettingKeys `type`

##### Namespace

GlobalNET.GlobalClasses

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

<a name='T-GlobalNET-GlobalFunctions-SystemFunctions'></a>
## SystemFunctions `type`

##### Namespace

GlobalNET.GlobalFunctions

<a name='M-GlobalNET-GlobalFunctions-SystemFunctions-FilterToString-System-Windows-Controls-ComboBox-'></a>
### FilterToString(filterBox) `method`

##### Summary

return existing filter for saving to string in selected Page

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filterBox | [System.Windows.Controls.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.ComboBox 'System.Windows.Controls.ComboBox') |  |

<a name='M-GlobalNET-GlobalFunctions-SystemFunctions-ParameterCheck-System-String-'></a>
### ParameterCheck(parameterName) `method`

##### Summary

Return User or default DB parameter

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-GlobalNET-Classes-TemplateClassList'></a>
## TemplateClassList `type`

##### Namespace

GlobalNET.Classes

##### Summary

Example of Table Dataset

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

<a name='T-GlobalNET-Pages-ToolPanelPage'></a>
## ToolPanelPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

ToolPanelPage

<a name='M-GlobalNET-Pages-ToolPanelPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

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
