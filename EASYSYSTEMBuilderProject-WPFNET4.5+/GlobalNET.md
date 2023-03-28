<a name='assembly'></a>
# GlobalNET

## Contents

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
- [ExchangeRateListPage](#T-GlobalNET-Pages-ExchangeRateListPage 'GlobalNET.Pages.ExchangeRateListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ExchangeRateListPage-InitializeComponent 'GlobalNET.Pages.ExchangeRateListPage.InitializeComponent')
- [ExtendedTemplateClassList](#T-GlobalNET-Classes-ExtendedTemplateClassList 'GlobalNET.Classes.ExtendedTemplateClassList')
- [FileFunctions](#T-GlobalNET-GlobalFunctions-FileFunctions 'GlobalNET.GlobalFunctions.FileFunctions')
  - [VncServerIniFile(path)](#M-GlobalNET-GlobalFunctions-FileFunctions-VncServerIniFile-System-String- 'GlobalNET.GlobalFunctions.FileFunctions.VncServerIniFile(System.String)')
- [IncomingInvoiceListPage](#T-GlobalNET-Pages-IncomingInvoiceListPage 'GlobalNET.Pages.IncomingInvoiceListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-IncomingInvoiceListPage-InitializeComponent 'GlobalNET.Pages.IncomingInvoiceListPage.InitializeComponent')
- [IncomingOrderListPage](#T-GlobalNET-Pages-IncomingOrderListPage 'GlobalNET.Pages.IncomingOrderListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-IncomingOrderListPage-InitializeComponent 'GlobalNET.Pages.IncomingOrderListPage.InitializeComponent')
- [ItemListPage](#T-GlobalNET-Pages-ItemListPage 'GlobalNET.Pages.ItemListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-ItemListPage-InitializeComponent 'GlobalNET.Pages.ItemListPage.InitializeComponent')
- [Language](#T-GlobalNET-Classes-Language 'GlobalNET.Classes.Language')
- [LicenseActivationFailListPage](#T-GlobalNET-Pages-LicenseActivationFailListPage 'GlobalNET.Pages.LicenseActivationFailListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LicenseActivationFailListPage-InitializeComponent 'GlobalNET.Pages.LicenseActivationFailListPage.InitializeComponent')
- [LicenseAlgorithmListPage](#T-GlobalNET-Pages-LicenseAlgorithmListPage 'GlobalNET.Pages.LicenseAlgorithmListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LicenseAlgorithmListPage-InitializeComponent 'GlobalNET.Pages.LicenseAlgorithmListPage.InitializeComponent')
- [LoginHistoryListPage](#T-GlobalNET-Pages-LoginHistoryListPage 'GlobalNET.Pages.LoginHistoryListPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-LoginHistoryListPage-InitializeComponent 'GlobalNET.Pages.LoginHistoryListPage.InitializeComponent')
- [MainWindow](#T-GlobalNET-MainWindow 'GlobalNET.MainWindow')
  - [FilterField_SelectionChanged(sender,e)](#M-GlobalNET-MainWindow-FilterField_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.MainWindow.FilterField_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-MainWindow-InitializeComponent 'GlobalNET.MainWindow.InitializeComponent')
  - [Menu_action_Click(sender,e)](#M-GlobalNET-MainWindow-Menu_action_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Menu_action_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Mi_filter_Click(sender,e)](#M-GlobalNET-MainWindow-Mi_filter_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.Mi_filter_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [RemoveFilterItem_Click(sender,e)](#M-GlobalNET-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.MainWindow.RemoveFilterItem_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [StringToFilter(filterBox,advancedFilter)](#M-GlobalNET-MainWindow-StringToFilter-System-Windows-Controls-ComboBox,System-String- 'GlobalNET.MainWindow.StringToFilter(System.Windows.Controls.ComboBox,System.String)')
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
- [SystemFunctions](#T-GlobalNET-GlobalFunctions-SystemFunctions 'GlobalNET.GlobalFunctions.SystemFunctions')
  - [FilterToString(filterBox)](#M-GlobalNET-GlobalFunctions-SystemFunctions-FilterToString-System-Windows-Controls-ComboBox- 'GlobalNET.GlobalFunctions.SystemFunctions.FilterToString(System.Windows.Controls.ComboBox)')
- [TemplateClassList](#T-GlobalNET-Classes-TemplateClassList 'GlobalNET.Classes.TemplateClassList')
- [TemplateDocumentViewPage](#T-GlobalNET-Pages-TemplateDocumentViewPage 'GlobalNET.Pages.TemplateDocumentViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateDocumentViewPage-#ctor 'GlobalNET.Pages.TemplateDocumentViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateDocumentViewPage-dataViewSupport 'GlobalNET.Pages.TemplateDocumentViewPage.dataViewSupport')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateDocumentViewPage-InitializeComponent 'GlobalNET.Pages.TemplateDocumentViewPage.InitializeComponent')
- [TemplateListPage](#T-GlobalNET-Pages-TemplateListPage 'GlobalNET.Pages.TemplateListPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateListPage-#ctor 'GlobalNET.Pages.TemplateListPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateListPage-dataViewSupport 'GlobalNET.Pages.TemplateListPage.dataViewSupport')
  - [DeleteRecord()](#M-GlobalNET-Pages-TemplateListPage-DeleteRecord 'GlobalNET.Pages.TemplateListPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateListPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateListPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateListPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateListPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-GlobalNET-Pages-TemplateListPage-EditRecord-System-Boolean- 'GlobalNET.Pages.TemplateListPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateListPage-Filter-System-String- 'GlobalNET.Pages.TemplateListPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateListPage-InitializeComponent 'GlobalNET.Pages.TemplateListPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateListPage-LoadDataList 'GlobalNET.Pages.TemplateListPage.LoadDataList')
  - [NewRecord()](#M-GlobalNET-Pages-TemplateListPage-NewRecord 'GlobalNET.Pages.TemplateListPage.NewRecord')
- [TemplateListPageWithSubPage](#T-GlobalNET-Pages-TemplateListPageWithSubPage 'GlobalNET.Pages.TemplateListPageWithSubPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-#ctor 'GlobalNET.Pages.TemplateListPageWithSubPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateListPageWithSubPage-dataViewSupport 'GlobalNET.Pages.TemplateListPageWithSubPage.dataViewSupport')
  - [ClearItemsFields()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-ClearItemsFields 'GlobalNET.Pages.TemplateListPageWithSubPage.ClearItemsFields')
  - [Customer_KeyDown(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.Customer_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [DeleteRecord()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-DeleteRecord 'GlobalNET.Pages.TemplateListPageWithSubPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-EditRecord-System-Boolean- 'GlobalNET.Pages.TemplateListPageWithSubPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-Filter-System-String- 'GlobalNET.Pages.TemplateListPageWithSubPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-InitializeComponent 'GlobalNET.Pages.TemplateListPageWithSubPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-LoadDataList 'GlobalNET.Pages.TemplateListPageWithSubPage.LoadDataList')
  - [NewRecord()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-NewRecord 'GlobalNET.Pages.TemplateListPageWithSubPage.NewRecord')
  - [NotesChanged(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.NotesChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [PartNumberGotFocus(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.PartNumberGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [PartNumber_KeyDown(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.PartNumber_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectCustomer_Enter(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.SelectCustomer_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectGotFocus(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.SelectGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [SelectPartNumber_Enter(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubPage.SelectPartNumber_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SetCustomer(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-SetCustomer 'GlobalNET.Pages.TemplateListPageWithSubPage.SetCustomer')
  - [SetPartNumber(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubPage-SetPartNumber 'GlobalNET.Pages.TemplateListPageWithSubPage.SetPartNumber')
  - [SetSubListsNonActiveOnNewItem()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean- 'GlobalNET.Pages.TemplateListPageWithSubPage.SetSubListsNonActiveOnNewItem(System.Boolean)')
  - [UpdateCustomerSearchResults()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-UpdateCustomerSearchResults 'GlobalNET.Pages.TemplateListPageWithSubPage.UpdateCustomerSearchResults')
  - [UpdatePartNumberSearchResults()](#M-GlobalNET-Pages-TemplateListPageWithSubPage-UpdatePartNumberSearchResults 'GlobalNET.Pages.TemplateListPageWithSubPage.UpdatePartNumberSearchResults')
- [TemplateListPageWithSubViewPage](#T-GlobalNET-Pages-TemplateListPageWithSubViewPage 'GlobalNET.Pages.TemplateListPageWithSubViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-#ctor 'GlobalNET.Pages.TemplateListPageWithSubViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateListPageWithSubViewPage-dataViewSupport 'GlobalNET.Pages.TemplateListPageWithSubViewPage.dataViewSupport')
  - [DeleteRecord()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DeleteRecord 'GlobalNET.Pages.TemplateListPageWithSubViewPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateListPageWithSubViewPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateListPageWithSubViewPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateListPageWithSubViewPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-EditRecord-System-Boolean- 'GlobalNET.Pages.TemplateListPageWithSubViewPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-Filter-System-String- 'GlobalNET.Pages.TemplateListPageWithSubViewPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-InitializeComponent 'GlobalNET.Pages.TemplateListPageWithSubViewPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-LoadDataList 'GlobalNET.Pages.TemplateListPageWithSubViewPage.LoadDataList')
  - [LoadSubDataList()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-LoadSubDataList 'GlobalNET.Pages.TemplateListPageWithSubViewPage.LoadSubDataList')
  - [NewRecord()](#M-GlobalNET-Pages-TemplateListPageWithSubViewPage-NewRecord 'GlobalNET.Pages.TemplateListPageWithSubViewPage.NewRecord')
- [TemplateListViewPage](#T-GlobalNET-Pages-TemplateListViewPage 'GlobalNET.Pages.TemplateListViewPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateListViewPage-#ctor 'GlobalNET.Pages.TemplateListViewPage.#ctor')
  - [dataViewSupport](#F-GlobalNET-Pages-TemplateListViewPage-dataViewSupport 'GlobalNET.Pages.TemplateListViewPage.dataViewSupport')
  - [DgListView_MouseDoubleClick(sender,e)](#M-GlobalNET-Pages-TemplateListViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'GlobalNET.Pages.TemplateListViewPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-GlobalNET-Pages-TemplateListViewPage-DgListView_Translate-System-Object,System-EventArgs- 'GlobalNET.Pages.TemplateListViewPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [Filter(filter)](#M-GlobalNET-Pages-TemplateListViewPage-Filter-System-String- 'GlobalNET.Pages.TemplateListViewPage.Filter(System.String)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateListViewPage-InitializeComponent 'GlobalNET.Pages.TemplateListViewPage.InitializeComponent')
  - [LoadDataList()](#M-GlobalNET-Pages-TemplateListViewPage-LoadDataList 'GlobalNET.Pages.TemplateListViewPage.LoadDataList')
- [TemplateSTLPage](#T-GlobalNET-Pages-TemplateSTLPage 'GlobalNET.Pages.TemplateSTLPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateSTLPage-InitializeComponent 'GlobalNET.Pages.TemplateSTLPage.InitializeComponent')
- [TemplateSettingsPage](#T-GlobalNET-Pages-TemplateSettingsPage 'GlobalNET.Pages.TemplateSettingsPage')
  - [#ctor()](#M-GlobalNET-Pages-TemplateSettingsPage-#ctor 'GlobalNET.Pages.TemplateSettingsPage.#ctor')
  - [Languages](#F-GlobalNET-Pages-TemplateSettingsPage-Languages 'GlobalNET.Pages.TemplateSettingsPage.Languages')
  - [BtnApiTest_Click(sender,e)](#M-GlobalNET-Pages-TemplateSettingsPage-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs- 'GlobalNET.Pages.TemplateSettingsPage.BtnApiTest_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateSettingsPage-InitializeComponent 'GlobalNET.Pages.TemplateSettingsPage.InitializeComponent')
- [TemplateVideoPage](#T-GlobalNET-Pages-TemplateVideoPage 'GlobalNET.Pages.TemplateVideoPage')
  - [InitializeComponent()](#M-GlobalNET-Pages-TemplateVideoPage-InitializeComponent 'GlobalNET.Pages.TemplateVideoPage.InitializeComponent')
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

<a name='T-GlobalNET-Classes-TemplateClassList'></a>
## TemplateClassList `type`

##### Namespace

GlobalNET.Classes

##### Summary

Example of Table Dataset

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

<a name='T-GlobalNET-Pages-TemplateListPage'></a>
## TemplateListPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateListPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
Manual work needed Translate All XAML fields by Resources
Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateListPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
All is setted as global Classes for All Pages and Work is Fully automatized by System core

<a name='M-GlobalNET-Pages-TemplateListPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Delete button Click
Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Edit button Click
Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPage-Filter-System-String-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPage-LoadDataList'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on New button Click
Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateListPageWithSubPage'></a>
## TemplateListPageWithSubPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
Manual work needed Translate All XAML fields by Resources
Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateListPageWithSubPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
All is setted as global Classes for All Pages and Work is Fully automatized by System core

HERE you Define All Data Variables For This Form

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-ClearItemsFields'></a>
### ClearItemsFields() `method`

##### Summary

Standartized Method for Clear SubRecord Input Fields with custom Dataset
For Correct Using must be Fields changed for used dataset

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### Customer_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Delete button Click
Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Edit button Click
Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-Filter-System-String-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-LoadDataList'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on New button Click
Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### NotesChanged(sender,e) `method`

##### Summary

Standartized Maximal Simle Code with Reaction and Fill input After ParentComboboxSelection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### PartNumberGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in Combobox 
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### PartNumber_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectCustomer_Enter(sender,e) `method`

##### Summary

Standartized methods with Indicate Customer Selection and Start Filling Input
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### SelectGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in Combobox 
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectPartNumber_Enter(sender,e) `method`

##### Summary

Standartized methods with Indicate Customer Selection and Start Filling Input
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-SetCustomer'></a>
### SetCustomer(sender,e) `method`

##### Summary

Standartized methods For Filling Input after Selection
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [M:GlobalNET.Pages.TemplateListPageWithSubPage.SetCustomer](#T-M-GlobalNET-Pages-TemplateListPageWithSubPage-SetCustomer 'M:GlobalNET.Pages.TemplateListPageWithSubPage.SetCustomer') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-SetPartNumber'></a>
### SetPartNumber(sender,e) `method`

##### Summary

Standartized methods For Filling Input after Selection
This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [M:GlobalNET.Pages.TemplateListPageWithSubPage.SetPartNumber](#T-M-GlobalNET-Pages-TemplateListPageWithSubPage-SetPartNumber 'M:GlobalNET.Pages.TemplateListPageWithSubPage.SetPartNumber') |  |

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean-'></a>
### SetSubListsNonActiveOnNewItem() `method`

##### Summary

Standartized Method for Load All SubData which is needed for Working with SubRecord
For Correct Using must be changed for actual datasets

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-UpdateCustomerSearchResults'></a>
### UpdateCustomerSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value
This is full automatic, not needed manual work

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubPage-UpdatePartNumberSearchResults'></a>
### UpdatePartNumberSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value
This is full automatic, not needed manual work

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateListPageWithSubViewPage'></a>
## TemplateListPageWithSubViewPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
Manual work needed Translate All XAML fields by Resources
Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateListPageWithSubViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
All is setted as global Classes for All Pages and Work is Fully automatized by System core

HERE you Define All Data Variables For This Form

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Delete button Click
Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on Edit button Click
Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-Filter-System-String-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-LoadDataList'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-LoadSubDataList'></a>
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

<a name='M-GlobalNET-Pages-TemplateListPageWithSubViewPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record
ALL Needed changes Are done By Replace CLASSNAME not needed manual work
Dynamicaly Called Only from MainWindow.cs on New button Click
Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='T-GlobalNET-Pages-TemplateListViewPage'></a>
## TemplateListViewPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

This standartized Template is only for list view od Data table
Called from MainWindow.cs on open New Tab

<a name='M-GlobalNET-Pages-TemplateListViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data
Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-GlobalNET-Pages-TemplateListViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages
this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
All is setted as global Classes for All Pages and Work is Fully automatized by System core

<a name='M-GlobalNET-Pages-TemplateListViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListViewPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListViewPage-Filter-System-String-'></a>
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

<a name='M-GlobalNET-Pages-TemplateListViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GlobalNET-Pages-TemplateListViewPage-LoadDataList'></a>
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

<a name='T-GlobalNET-Pages-TemplateSTLPage'></a>
## TemplateSTLPage `type`

##### Namespace

GlobalNET.Pages

##### Summary

TemplateSTLPage

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

<a name='M-GlobalNET-Pages-TemplateVideoPage-InitializeComponent'></a>
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