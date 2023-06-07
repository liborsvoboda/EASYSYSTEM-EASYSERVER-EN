### EASYBuilder Description SYSTEM CORE
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

A full detailed description of the system core for easy development of any system with full support for automated functions, methods to make any of your applications work properly

**this information is divided into information for**
* rapid development  
* complete information about the basic function of the system

----
### Projects Documentation
Used automatic tools
* Generating MD from XML Documentation from code


Generating MD from XML Documentation from code
```xml
<DocumentationFile>bin\Debug\Documentation\GlobalNET.xml</DocumentationFile>
<DocumentationMarkdown>$(MSBuildProjectDirectory)\GlobalNET.md</DocumentationMarkdown>
```
 
### DECLARED SYSTEM CONDITIONS FOR DEVELOP NEW AGENDA
Basic Info what you minimal need for start Developing of new Agendas

1. APP Initialization [INFO]
	- Starting APP with Welcome Page by JSON Setting
	- Initialize Technologies
	- Including Core Styles and themes
	- Set Global Properties
	- Set Global DataLists  (Parameters, Setting, Tilts, System Classes, UserData, Error Handlers, API Security, etc)
	- Set CrashReporting join
	
1. Welcome Page [INFO] - Video Start Page with Mottos


1. NAMESPACES [CONDITIONS]
	Pages - Each Agenda must be in Namespace Pages
	Classes - All Agenda Classes are in Namespace Classes for developer Help


1. DataClases [CONDITIONS] - DataList - Table Models Description (for Agendas/Pages)
	- Create By TemplateClass.cs file your new Class/DataModel Definition in your Agenda Folder
	- you can create Extended Table Model for more field in basic DataListModel - (example: ReceiptList, OutgoingOrderList, etc.)
	- Done

1. ApiCommunications [CONDITIONS] - In the Class is in ENUM all API address list
	- All API Cals  which has 'List' word on End is automatically supported for insert Report
	- Insert your New API address to this enum
	- Done
	
1. Languages [CONDITIONS] - Each used 'Word' must exist in all Language Files Before Build 
	- insert all new translations [check duplicity]to all dictionaries for your new Agenda field, menuName
	- Done

1. PageTemplatesCodeHelp [INFO] - is central List of special methods in the system (Load/SaveFile, load, lang, number validation, etc..)


1. Templates [INFO]  - For simple create new ANY agengas by COPY/PASTE for simple modify INPUT fields only
	- for new Agenda Create new folder in Agendas and copy TemplateClass and correct TemplatePage to this folder
	- rename these files and change class model to your new class[COPY/PASTE from backend]
	- replace 'TemplateClass' for your new in XAML and CS file of your new Page/Agenda
	- now the form field change only and modify and check fields, translations, apiCalls in cs code for your new
	- Done
	

1. MainMenu [CONDITIONS]  - in MainWindow must be new Agenga inserted to the application menu
    - Insert new menu Item -im Xaml copy existing menu item and rename to your new Agenda   
    - Translate menu item - In CS code insert the translate menu item in initialize Method
    - Set Menu Reaction - in MainWindows Method 'Cb_verticalMenuSelected' copy existing menuitem part code in the 'CASE' and change XAML menu name and name of called 'Page'
      Here on end case for List Report set the '/YourTableNameList' in Report line 
      or for non report Table set 'cb_printReports.ItemsSource = null;'
	- Done
	
1. Reports [INFO] - In system menu Reports you can upload Report file for your new Agenda 

NOW Build and YOUR new Agenda is IN App Menu and After click is opened
**THIS IS ALL INFORMATIONS FOR SUCCESS DEVELOPING**
---

### SHORT SYSTEM DESCRIPTION

	System is Fully dynamic Controlled For All menuInserted Pages/Agendas 
	(Insert new Page/Agenda to menu + Translate for implement to full system only)

	All method are implemented with global logic of using for central Core of this System and his Modification
	For working with any standard system agenda (Typically IS System - SAP Example) 

	INSERT/UPDATE/DELETE/SELECT/FILTER/PRINT/SHOW/MEDIA 3D/VIDEO/DOCS/EAN CODES/1000 FINISHED TOOLS on GITHUB/UNLIMITED ETC

	FOR WINDOWS MODERN SYSTEMS/TERMINALS/ETC ON START (WEB FORMAT IS SUPPORTED BY TECHNOLOGY WILL BE DONE IN YEAR FUTURE

---
### MAINWINDOW Central SYSTEM Control Manual
This is Core central point (MainWindow.xaml/cs) for full system
Here are Defined All join for Central Control for All parts of System
 
- MainWindow is Absolute Primary Control window off all actions in the application 
- Here are All global definitions, Messages, mainWindows and all Shared Controls for Pages
- Here are Application Menu events, Update, Reports, New/Edit/.. for DataList, Filters, TabPages
- MainWindow Has Defined 3Menu Types for More Systems: 
       - Buttons in Header LINE -> For simple touch Terminal with few button for Agendas
       - SelectBox -> For TouchPanels with more MenuItems, but Touch functionality is Needed
       - TreeView -> For Robust Systems with a lot of MenuItems/Agendas
- in Xaml are declared all shared input/Controls/ETC for Application  
  App Update, Tools, Theme, Menus, Report Ctrl, Pages Controls, Graphics, ProgressRing, TabPages Types, 


---
### CORE SYSTEM METHODS - OLDER,Was modernized**
- Initialize - Initiate Theme/Color/App menu/Load Config/Show Login   

### Here is Translate Menu Items**
  
- Timer10sec_Elapsed - Auto Backend Timer cycling by Config [default 5sec]
    - check if Backend is Accesible - Server status Control
    - load Server Setting
    - Load Application Parameters for NULL user
    
- ShowLoginDialog - Login, Load User Params, Token, Enable Menu Items  
- ShowMessage - Shared Message for call from Pages For show in MainWindow  
- SetServiceStop - connect/disconnect menuItems Pages on Backend Service Status

---
### DATALIST GLOBAL METHODS - OLDER,Was modernized**
- cb_FilterDropDownClosed - Reload Datalist with filtering
- Mi_filter_Click - Generate and show advanced filter (for SQL conditioning): 
- Cb_PrintReportsSelected - save filter to DB, open selected Report
- Cb_verticalMenuSelected - Open selected Page/Agenda and set all controls,input,filter,reports status 
  **!!NEW AGENDA MUST BE DEFINED ONLY HERE.**
 

###  INFO METHOD LIST SYSTEM CORE NOT NEEDED CHANGES - OLDER,Was modernized
- Btn_about_click - Show About Info  
- WinMain_KeyDown - Global Control for Keyboard press ,implemented F1/ALT+Q

- Btn_LaunchHelp_Click - Open index.chm Windows Help File
- ApplicationClosing - Save theme, close App
- AppRestart - Restart for Configuration Reload
- StringToFilter - upload seted filter in page for actual view
- RemoveFilterItem_Click - Remove advanced filter Item
- FilterField_SelectionChanged - support method for dynamic filter generation
- MainGrid_IsDraggingChanged - For Draging TabPages - ACTUALLY DISABLED
- Menu_action_Click - Automatic Datalist Controls Action Handler
- AddNewTab - Automatic TabPages Controller
- TabPanelOnSelectionChange - Automatic Controller for TabPages Changing
- ChangeMenuView - Specific for Version with more menu types. Show/Hide used menu type


### System Core Code Rules
```cs

/// <summary>
/// Library with standarztized Definitions and Methods For Develop Any System
/// </summary>
public class PageTemplatesCodeHelp
{
#region MyReStandartized Definitions  - OLDER,Was modernized

/// <summary>
/// Define Collection For Combobox Example
/// </summary>
public ObservableCollection<Language> Languages = new ObservableCollection<Language>() {
                                                        new Language() { Name = "System", Value = "system" },
                                                        new Language() { Name = "Czech", Value = "cs-CZ" },
                                                     };

#endregion



/// <summary>
/// Special Method for input limitation as number only
/// Its only for help
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
{
    Regex regex = new Regex("[^0-9]+");
    e.Handled = regex.IsMatch(e.Text);
}


/// <summary>
/// Global Application Defined API Communication Types for Centalised using
/// </summary>
private async void DefinedAllAplicationApiComunicationTypes()
{
    ///ApiUrls variable is List With All API cals

    ///DBResultMessage is Class for Global using of All Api with all information of Request result
    DBResultMessage dBResult;

    /// Serialize Dataset for API sending INSERT/UPDATE
    TemplateClassList myRecord = new TemplateClassList();
    string json = JsonConvert.SerializeObject(myRecord);
    StringContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

    ///API for load/Select Data
    await ApiCommunication.GetApiRequest<List<TemplateClassList>>(ApiUrls.TemplateClassList, null, App.UserData.Authentification.Token);

    ///API for Data Insert
    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.TemplateClassList, httpContent, null, App.UserData.Authentification.Token);

    ///API for Data Update
    dBResult = await ApiCommunication.PostApiRequest(ApiUrls.TemplateClassList, httpContent, null, App.UserData.Authentification.Token);

    ///API for Delete Data
    dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.TemplateClassList, "someId", App.UserData.Authentification.Token);

}

/// <summary>
/// Global Application avaiable Methods for All Pages for Centalised using
/// </summary>
private async void DefinedGlobalMainWindowMethodsForAllPages()
{

    ///Aplication Restart
    MainWindow.AppRestart();

    ///Progresring for Wait indication
    MainWindow.ProgressRing = Visibility.Hidden;

    ///Show Info message
    await MainWindow.ShowMessage(false, "Resources[\"dictionaryWord\"].ToString()");

    ///Show Confirm Dialog
    MessageDialogResult result = await MainWindow.ShowMessage(false, "Resources[\"dictionaryWord\"].ToString()" + " ", true);
    if (result == MessageDialogResult.Affirmative) { }

    ///Method For Sett Language of Each Page
    Language defaultLanguage = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage);
    ///_ = MediaFunctions.SetLanguageDictionary(Resources, defaultLanguage.Value);

}


/// <summary>
/// Global Specific Methods For Customized Working  - OLDER,Was modernized
/// </summary>
private async void UsedSpecificMethodsForCustomizedWorking()
{

    #region Other Help Global Definitions and Methods
    ///Load Parameter From Table Parameters text is Parameter name
    var res = ServerCoreFunctions.ParameterCheck("someParameterName").Correct ? int.Parse(ServerCoreFunctions.ParameterCheck("someParameterName").Value) : 50;

    ///Set ComboBox Item By myValue (from selected record or another)
    int index = 0; ComboBox cb_defaultLanguage = new ComboBox();
    cb_defaultLanguage.Items.SourceCollection.Cast<Language>().ToList().ForEach(language => { if (language.Name == "myvalue") { cb_defaultLanguage.SelectedIndex = index; } index++; });

    ///Open File Dialog
    OpenFileDialog dlg = new OpenFileDialog
    { DefaultExt = ".exe", Filter = "Exe files |*.exe", Title = "Resources[\"fileOpenDescription\"].ToString()" };
    if (dlg.ShowDialog() == true) { } 
    #endregion

}



#region Other Custom Communications 
/// <summary>
/// Customized GET Call 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private async void BtnApiTest_Click(object sender, RoutedEventArgs e)
{
    using (HttpClient httpClient = new HttpClient())
    {
        try
        {
            string json = await httpClient.GetStringAsync("someUrl");
            await MainWindow.ShowMessage(false, json);
        }
        catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.StackTrace); }
    }
} 
#endregion
```
---
### PAGE/AGENDA STANDARTIZED DEFINITION FOR CREATE NEW ANY SYSTEM STANDARD AGENGA

	AGENDA (Page) IS BUILDED FROM STANDARTIZED METHODS FOR FULL CONTROL OF EACH STANDARD Agenda Page
		   Each FULL agenga has these Methods for work with SYSTEM CORE

	AGENDA CONTAIN - DaTaModel Class File (Copied from Backend Server or DB Structure ScaffoldContext)
					 PreDefined XAML FORM (contain both LIST/FORM definitions) 
					 List od Global System Methods for Control Full Agenda in System Core

	PAGE - AGENDA METHOD LIST
		Method InitializePage       - used by MenuClick - Load Dictionaries, Parameters, Translate Form Fields And Run 'LoadDataList' for Datalist/Dials, others, Set Record = False
		Method LoadDataList         - used by REFRESH Button - Call API for again load datasets in Page (DB Select)
		Method NewRecord            - used by NEW Button     - Open detail form for New Record
		Method EditRecord(false)    - used by EDIT Button    - Open detail form for edit Record
		Method EditRecord(true)     - used by COPY Button    - Open detail form for create copied Record (with ID=0)
		Method DeleteRecord         - used by DELETE Button  - Call delete API for selected record in datalist (DB Delete)

		Method Filter               - SEARCH Textbox - SIMPLE SEARCH in all defined columns in PAGE code - Method Filter
		Method DgListView_Translate - Translate Datalist column - translate column names by Xaml Language Dictionaries
		Method DgListView_MouseDoubleClick - Select and Open selected Record Detail
		Method DgListView_SelectionChanged - Select Record For control buttons enabling, show Report with join on Id

		Method BtnSave_Click    - Form to DataClassModel, send API (DB Insert/DB Update), Return to DataList View
		Method BtnCancel_Click  - Cancel Form and Return to DataListView
		Method SetRecord        - Load Selected Record (edit,copy) to Detail Form

		In Combined Forms with SubTable The methods Are copied as SubMethods (Translate,Data,Form Fields)

----
	
	Standard SUBSELECT ComboBox/ListBox/ListView/Custom For Dial Join Record Selection (Addresses, Items, Etc.)

		Standard Method List for Full Mouse/Keyboard Control
		- SelectGotFocus - Call SubDataList Controller for Selection one Record for Selection 'UpdateCustomerSearchResults'
		- UpdateCustomerSearchResults - Control full SubData List, select, show Info message not exist, Select Founded Record
		- Customer_KeyDown - Keyboard Up/Down Event for Data listing in ListView Form Item/Input
		- SelectCustomer_Enter - Selection by Enter
		- MouseSelectCustomer_Click - Selection by Mouse
		- SetXxxxxx                 - Set Joined Fields From this Selection


----

		Standard Methods For SubDocItems INSERT/DELETE (Invoice Example)
		- dgSubListView_SelectionChanged - Select Item form List For Delete Control
		- BtnItemInsert_Click            - Insert new Item to SubDataList from SubFormInputFields
		- BtnItemDelete_Click            - Delete selected SubItem from DataList
		- ClearItemsFields               - Clear SubItemForm
		- SetSubListsNonActiveOnNewItem  - Load DataSources For SubItem Selections types (Dials -> ItemList, CurrencyList)

		Optional 
		- HideTiltButtons                - Hide/Show Button for show subDocument
		- TiltToInvoice_Click            - Open subDocument

----
	
	Standard Tilt Documents (Next Joined Generating SubDoc Offer -> Order, etc)
		
		Standard Method List for full generation process
		- ImportInvoice - Import Existed Document (example in CreditNoteList)
	
----

###  PREPARED TEMPLATES FOR FAST DEVELOPING - Older was Modernized  
SYSTEM TEMPLATES FOR MAKE ANY TOUCH/IS/ETC. SYSTEM


### System HAS 4 Standard Data Form Types in Main Structure (System Templates)		
						   
    Implemented Forms for build Robust Any System  
	   TemplateListViewPage  - show DATALIST ONLY, used in Login history list
	   TemplateListPage      - show DATALIST WITH DETAIL FORM, Standard Dials,  
	                           used in Parameters, User, Roles, etc.
	   TemplateListPageWithSubViewPage - show DATALIST WITH DETAIL FORM AND SUB TABLE DATAVIEW   
	                                     used in Currency agenda 
	   TemplateListPageWithSubPage - show DATALIST WITH DETAIL FORM AND SUB TABLE DATAVIEW + FORM 
	                                 used in invoice, order for work 2Tables HEADER/Items in One time

### System HAS 3 Form Types in Main Structure (All are in Templates)    
>DATALIST ONLY               - **TemplateListViewPage**   
	   Show Datalist only (Login history for example, views, etc..)
	   
> DATALIST WITH DETAIL FORM   - **TemplateListPage**           
       Show Datalist and Detail Form for PAge Table ( Dials, Simple agendas with one primary table, etc...)
       
>SETTING                     - **TemplateSettingsPage**       
Customized Forms with unlimited posibilities,(Setting Form, special Form, special Page, Video, 3D, etc)

### In System are implemented multimedia templates (MultiMedia Templates)   

    Implemented Special MultiMedia Forms
        TemplateDocumentViewPage - XPS,PDF,TXT,and more format direct viewer/Print
        TemplateSTLPage          - Show 3D STL project
        TemplateVideoPage        - Play MP4 Video player
    
    Supported next implementation    
        GITHUB WPF TOOLS FOR SYSTEM IS / OS, HW can possible to implement for FREE
---

### API communication - 4 TYPES is enough
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

It is so. INSERT/UPDATE/DETETE/SELECT are the mentioned types which are enough
ensure the communication of any system.
And top it all off with a single list of APIaddress calls and communication is resolved
set up for this as a standardized automatic part of the kernel.

System kernel code dump, Where you just always add the address and don't care about anything else

### System APIAddresList - all calls in one place  

```cs
    /// <summary>
    /// ALL standard View AND Form API Call must end with "List" - These will automatic added for reports Definitions
    /// </summary>
    public enum ApiUrls
    {
        GlobalNETAttachmentList,
        GlobalNETAddressList,
        Authentication,
        BackendCheck,
        GlobalNETBranchList,
        GlobalNETCalendar,
        GlobalNETCreditNoteList,
        GlobalNETCreditNoteItemList,
        GlobalNETCurrencyList,
        GlobalNETDocumentAdviceList,
        GlobalNETExchangeRateList,
        GlobalNETIncomingInvoiceList,
        GlobalNETIncomingInvoiceItemList,
        GlobalNETIncomingOrderList,
        GlobalNETIncomingOrderItemList,

        GlobalNETTemplateClassList
    }
```

### 4 API Calls - SYSTEM Core module  

```cs
    class ApiCommunication
    {
        public static async Task<Authentification> Authentification(ApiUrls apiUrl, string userName = null, string password = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(userName + ":" + password)));
                    StringContent test = new StringContent("", Encoding.UTF8, "application/json");
                    HttpResponseMessage json = await httpClient.PostAsync(App.Setting.ApiAddress + "/" + apiUrl, test);
                    return JsonConvert.DeserializeObject<Authentification>(await json.Content.ReadAsStringAsync());
                }
                catch { return new Authentification() { Token = null, Expiration = null }; }
            }
        }

        public static async Task<T> GetApiRequest<T>(ApiUrls apiUrl, string key = null, string token = null) where T : new()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    string json = await httpClient.GetStringAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""));
                    return JsonConvert.DeserializeObject<T>(json);
                } catch { return new T(); }
            }
        }

        public static async Task<DBResultMessage> PostApiRequest(ApiUrls apiUrl, HttpContent body, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.PostAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""), body);
                    DBResultMessage result = JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                    if (result.ErrorMessage == null) { result.ErrorMessage = await json.Content.ReadAsStringAsync(); }
                    return result;
                }
                catch (Exception ex)
                { return new DBResultMessage() { RecordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, Status = "error" }; }
            }
        }

        public static async Task<DBResultMessage> PutApiRequest(ApiUrls apiUrl, HttpContent body, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.PutAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""), body);
                    DBResultMessage result = JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                    if (result.ErrorMessage == null) { result.ErrorMessage = await json.Content.ReadAsStringAsync(); }
                    return result;
                }
                catch (Exception ex)
                { return new DBResultMessage() { RecordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, Status = "error" }; }
            }
        }

        public static async Task<DBResultMessage> DeleteApiRequest(ApiUrls apiUrl, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.DeleteAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""));
                    return JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                }
                catch (Exception ex)
                { return new DBResultMessage() { RecordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, Status = "error" }; }
            }
        }

        public static async Task<bool> CheckApiConnection()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string json = await httpClient.GetStringAsync(App.Setting.ApiAddress + "/" + ApiUrls.BackendCheck);
                    return true;
                }
                catch
                { return false; }
            }
        }

    }
```
----

### EASYBuilder Premade Templates
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

Pre-prepared templates are used to easily create a new agenda.
Even if there are only a few of them, they are fully sufficient to create complex systems of more or less all types, not only IS Systems - for which 4 templates are enough, but also Special Systems, Media Systems, Management / BI, and many others.
The system is nothing more than a list of very frequently repeated forms.

And you simply click on the graphic builder, which is part of Visual Studio. And that's the entire development of the system.
Here is a list of prepared templates in the system for more than n IS SYSTEM

---
### SystemTemplates - Media Templates --Older was modernized  
* TemplateListViewPage - Displays only the DataList. For example access history, Detailed form is not even needed

* TemplateListPage - displays the DataList and the Detailed form both for displaying the list and editing the record. That is, the most common template where you just edit the fields according to the table.

* TemplateListPageWithSubViewPage - displays the DataList and Detail form + additional DataList sub items. For example, the current exchange rate for currency. So it is a system type of Template

* TemplateListPageWithSubPage - displays a DataList and a Detail Form + another DataList with a Detail Item Form. For example Invoice - Header + Items. And with these templates you can write, for example, the entire SAP.

---
### MultiMediaTemplates - Media Templates --Older was modernized  
> TemplateVideoPage - Video player  
> TemplateSTLPage - STL representation of a 3D object   
> TemplateDocumentViewPage - Web browser that displays most file types  
   PDF, Docx, TXT, PNG, JPG, etc.

---
### CustomTemplates - Custom templates - Just slanted forms after all   
> TemplateSettingsPage - sample template for creating a unique form
These types, which you can click on in Visual Studio in the case of necessity, will reveal all unique types of forms when he wants anything atypical

### Shared Agendas - Real Creation  
In the SharedAgendas folder you will find approx. 50 Agendas - all forms already created forms for
immediate use or as an inspiration for the creation of new agendas.

### Code Examples   
[https://learn.microsoft.com/cs-cz/samples/browse/?terms=xaml](https://learn.microsoft.com/cs-cz/samples/browse/?terms=xaml "")  

---

### Literature  

https://www.c-sharpcorner.com/article/what-is-power-bi-report-builder-and-how-to-design-paginated-report-using-power-b/
https://github.com/majorsilence/My-FyiReporting/releases
https://mahapps.com/api/MahApps.Metro.Controls/
https://helix-toolkit.github.io/
https://www.c-sharpcorner.com/UploadFile/mahesh/viewing-word-documents-in-wpf/
https://techcohere.com/post/Create-PDF-File-From-WPF-Window-using-iTextsharp-1001
https://www.c-sharpcorner.com/UploadFile/mahesh/viewing-word-documents-in-wpf/
https://github.com/xceedsoftware/wpftoolkit
https://www.tutorialspoint.com/wpf/wpf_3d_graphics.htm

Number Formats (For Parameters)
https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

Manual Builder
https://github.com/EWSoftware/SHFB/releases 
https://github.com/psoares33/FyiReporting-Docs/wiki

---

### all method in MainWindow from Agenda Page Example  

```cs
((SchedulerPage)((MainWindowViewModel)DataContext).TabContents[0].Content).LoadScheduledTask();
```
---

### Convert Project to ASPNETCORE project  

https://learn.microsoft.com/cs-cz/dotnet/core/porting/upgrade-assistant-overview?WT.mc_id=dotnet-35129-website
dotnet tool install -g --add-source "https://api.nuget.org/v3/index.json" --ignore-failed-sources upgrade-assistant
upgrade-assistant upgrade <Path to csproj or sln to upgrade> převod na web
---

### Connection string Example  
```cs
Server=192.168.1.35,1433;Database=db;User ID=user;Password=pw;
Server=SQLSRV;DataBase=db;Trusted_Connection=True;Connect Timeout=30;
```

---

### Print example from CMD with parameters  

"RdlReader.exe" "C:\WorkListPrint.rdl" -p "&Search=%%&Id=0"

Report has dataset and you can insert field over right mouse/ insert / object /

Expressions
PageBreak ={PersonalNumber} - new page by  each personalNumber

functions in C# not MSSQL

using ="Filter:" + Replace({?Search}, "%", "")  - Search is param, replace %%

for run report mut be set Default values for parameters
=Fields!OperationNumber.Value + " " + {Note}
=Sum({Amount})
---

### Call from System Thread  
```cs
volani funkce ze stejneho vlakna
this.Invoke(() => { if (ServiceStatus != Resources["running"].ToString()) reloadScheduledTasks(); });
```

---

### Set Collor Icon programmaticaly   
```cs
Application.Current.MainWindow.Icon = IconMaker.Icon(Colors.White);
```


---

### Remove opened Page programatically  
```cs
MetroWindow wnd = (MetroWindow)App.Current.MainWindow;
TabablzControl tc = (TabablzControl)wnd.FindName("InitialTabablzControl");
TabContent itc0 = (TabContent)tc.SelectedItem;
tc.RemoveFromSource(itc0);
```

---

### rogram Help - Will be implemented  
```cs
Adding Help
#region Help Added
        private DependencyObject CurrentHelpDO { get; set; }
        private Popup CurrentHelpPopup { get; set; }
        private bool HelpActive { get; set; }
        private MouseEventHandler _helpHandler = null;
        static bool isHelpMode = false;
#endregion

private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
{
    if (isHelpMode && 1 == 0)
    {
        e.Handled = true;
        isHelpMode = false;
        Mouse.OverrideCursor = null;

        if (Help.MyHelpCommand.CanExecute(null, this))
        {
            Help.MyHelpCommand.Execute(null, this);
        }
    }
}

private void winMain_MouseMove(object sender, MouseEventArgs e)
{
    HitTestResult hitTestResult = VisualTreeHelper.HitTest(((Visual)sender), e.GetPosition(this));

    if (hitTestResult.VisualHit != null && CurrentHelpDO != hitTestResult.VisualHit)
    {
        DependencyObject checkHelpDO = hitTestResult.VisualHit;
        string helpText = AutomationProperties.GetHelpText(checkHelpDO);

        while (String.IsNullOrEmpty(helpText) && checkHelpDO != null && checkHelpDO != mainWindow)
        {
            checkHelpDO = VisualTreeHelper.GetParent(checkHelpDO);
            helpText = AutomationProperties.GetHelpText(checkHelpDO);
        }

        if (String.IsNullOrEmpty(helpText) && CurrentHelpPopup != null)
        {
            CurrentHelpPopup.IsOpen = false;
            CurrentHelpDO = null;
        }
        else if (!String.IsNullOrEmpty(helpText) && CurrentHelpDO != checkHelpDO)
        {
            CurrentHelpDO = checkHelpDO;
            if (CurrentHelpPopup != null)
            {
                CurrentHelpPopup.IsOpen = false;
            }

            CurrentHelpPopup = new Popup()
            {
                PopupAnimation = PopupAnimation.Scroll,
                PlacementTarget = (UIElement)hitTestResult.VisualHit,
                IsOpen = true,
                Child = new Border()
                {
                    CornerRadius = new CornerRadius(10),
                    BorderBrush = new SolidColorBrush(Colors.Goldenrod),
                    BorderThickness = new Thickness(2),
                    Background = new SolidColorBrush(Colors.LightYellow),
                    Child = new TextBlock()
                    {
                        Margin = new Thickness(10),
                        Text = helpText.Replace("\\r\\n", "\r\n"),
                        FontSize = 14,
                        FontWeight = FontWeights.Normal
                    }
                }
            };
            CurrentHelpPopup.IsOpen = true;
        }
    }
}

private void btnHelp_PreviewMouseDown(object sender, MouseButtonEventArgs e)
{
    if (isHelpMode)
    {
        isHelpMode = false;
        Mouse.OverrideCursor = null;
    }
}

private void btn_LaunchHelp_Click(object sender, RoutedEventArgs e)
{
    System.Windows.Forms.Help.ShowHelp(null, "SIMTERM.chm");
}

private void ToggleHelp()
{
    CurrentHelpDO = null;
    if (CurrentHelpPopup != null)
    {
        CurrentHelpPopup.IsOpen = false;
    }

    HelpActive = !HelpActive;

    if (_helpHandler == null)
    {
        _helpHandler = new MouseEventHandler(winMain_MouseMove);
    }

    if (HelpActive)
    {
        mainWindow.MouseMove += _helpHandler;
    }
    else
    {
        mainWindow.MouseMove -= _helpHandler;
    }
    ToggleHelp(mainWindow);
}

private void ToggleHelp(DependencyObject dependObj)
{
    for (int x = 0; x < VisualTreeHelper.GetChildrenCount(dependObj); x++)
    {
        DependencyObject child = VisualTreeHelper.GetChild(dependObj, x);
        ToggleHelp(child);
    }

    if (dependObj is UIElement)
    {
        UIElement element = (UIElement)dependObj;

        if (HelpActive)
        {
            string helpText = AutomationProperties.GetHelpText(element);

            if (!String.IsNullOrEmpty(helpText))
            {
            }
        }
    }
}
```

---

### Developing Page Code Help  
```cs
/// <summary>
    /// Library with standardize Definitions and Methods For Develop Any System
    /// </summary>
    public class PageTemplatesCodeHelp {

        #region MyReStandartized Definitions

        /// <summary>
        /// Define Collection For ComboBox Example
        /// </summary>
        public ObservableCollection<Language> Languages = new ObservableCollection<Language>() {
                                                                new Language() { Name = "System", Value = "system" },
                                                                new Language() { Name = "Czech", Value = "cs-CZ" },
                                                             };

        #endregion MyReStandartized Definitions

        /// <summary>
        /// Special Method for input limitation as number only
        /// Its only for help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Example of Load System Parameters for Page
        /// Add Call this method Before LoadDatalist and Tilt Documents
        /// LoadParameters() will be later translating Detail Fields
        /// </summary>
        private async void LoadParameters() {
            string itemVatPriceFormat = await DataOperations.ParameterCheck("ItemVatPriceFormat");
            string documentVatPriceFormat = await DataOperations.ParameterCheck("DocumentVatPriceFormat");
            int intValue = int.Parse(await DataOperations.ParameterCheck("DocumentRowHeight"));
        }

        /// <summary>
        /// Global Application Defined API Communication Types for Centralized using
        /// </summary>
        private async void DefinedAllAplicationApiComunicationTypes() {
            ///ApiUrls variable is List With All API calls

            ///DBResultMessage is Class for Global using of All API with all information of Request result
            DBResultMessage dBResult;

            /// Serialize Dataset for API sending INSERT/UPDATE
            TemplateClassList myRecord = new TemplateClassList();
            string json = JsonConvert.SerializeObject(myRecord);
            StringContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            ///API for load/Select Data
            await ApiCommunication.GetApiRequest<List<TemplateClassList>>(ApiUrls.GlobalNETTemplateClassList, null, App.UserData.Authentification.Token);

            ///API for Data Insert
            dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETTemplateClassList, httpContent, null, App.UserData.Authentification.Token);

            ///API for Data Update
            dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETTemplateClassList, httpContent, null, App.UserData.Authentification.Token);

            ///API for Delete Data
            dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETTemplateClassList, "someId", App.UserData.Authentification.Token);
        }
```

---

### Developing Global MainWindow Code Help  
```cs
// <summary>
        /// Global Application available Methods for All Pages for Centralized using
        /// </summary>
        private async void DefinedGlobalMainWindowMethodsForAllPages() {
            ///Application Restart
            App.AppRestart();

            ///ProgresRing for Wait indication
            MainWindow.ProgressRing = Visibility.Hidden;

            ///Show Info message
            await MainWindow.ShowMessage(false, "Resources[\"dictionaryWord\"].ToString()");

            ///Show Confirm Dialog
            MessageDialogResult result = await MainWindow.ShowMessage(false, "Resources[\"dictionaryWord\"].ToString()" + " ", true);
            if (result == MessageDialogResult.Affirmative) { }

            ///Method For Sett Language of Each Page
            Language defaultLanguage = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage);
            ///_ = SystemOperations.SetLanguageDictionary(Resources, defaultLanguage.Value);
        }

        /// <summary>
        /// Global Specific Methods For Customized Working
        /// </summary>
        private async void UsedSpecificMethodsForCustomizedWorking() {

            #region Other Help Global Definitions and Methods

            ///Load Parameter From Table Parameters text is Parameter name
            var res = int.Parse(await DataOperations.ParameterCheck("someParameterName"));

            ///Set ComboBox Item By myValue (from selected record or another)
            int index = 0; ComboBox cb_defaultLanguage = new ComboBox();
            cb_defaultLanguage.Items.SourceCollection.Cast<Language>().ToList().ForEach(language => { if (language.Name == "myvalue") { cb_defaultLanguage.SelectedIndex = index; } index++; });

            ///Open File Dialog
            OpenFileDialog dlg = new OpenFileDialog
            { DefaultExt = ".exe", Filter = "Exe files |*.exe", Title = "Resources[\"fileOpenDescription\"].ToString()" };
            if (dlg.ShowDialog() == true) { }

            #endregion Other Help Global Definitions and Methods
        }
```

---

### Customizing Page Code Help  
```cs
 /// <summary>
        /// Customized GET Call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnApiTest_Click(object sender, RoutedEventArgs e) {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string json = await httpClient.GetStringAsync("someUrl");
                    await MainWindow.ShowMessage(false, json);
                }
                catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.StackTrace); }
            }
        }
```

---

### Classlist Type Examples - Recommended
```cs
 /// <summary>
    /// Typical Table schema for API which you copy from Generated Model in API Server
    /// On API server is Automatically generated by Scaffold command
    /// Class is Same as API result
    /// Example Load Data: listVariable = await ApiCommunication.GetApiRequest<List<TemplateClassList>>(ApiUrls.GlobalNETTemplateClassList, null, App.UserData.Authentification.Token);
    /// </summary>
    public partial class ExampleClassList {
        public int Id { get; set; } = 0;
        public string SystemName { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    /// <summary>
    /// Extend API Class with Custom Column in One dataset
    /// !!!SYSTEM CONDITION: Name must contain "Extended" 
    /// !!!FOR NULL SET IN THE JOING FIELDS BEFORE SEND OVER API
    /// 
    /// Move the fields with SAME NAME as Joined Table on API to ExtendedClass
    /// Will be set to 'null' Before API send
    /// 
    /// Using: for Translation, Info about joined table, etc
    /// It must be cleaned by operation "NullSetInExtensionFields" before Database operation 
    /// for disable join control on API for valid independent table
    /// Other is valid join key for other Tables
    /// </summary>
    public partial class ExtendedExampleClassList : TemplateClassList {

        public string Currency { get; set; }  // its join to table Currency
        public string TotalCurrency { get; set; }


        public ExtendedExampleClassList() { }
        public ExtendedExampleClassList(ItemList ch) {
            foreach (var prop in ch.GetType().GetProperties())
            { this.GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(ch, null), null); }
        }
    }


    /// <summary>
    /// WARNING: If you Add the field with Same Name as joined table in Database Model
    /// you must set this field as 'null' before send Insert / Update
    /// in HttpContent must Be as 'null' value other is taken as Data Join by API Server
    ///
    /// SIMPLE USING
    /// API Class is extended on root level by custom fields
    /// Example Load Data and Fill custom Fields:
    ///
    /// listVariable = await ApiCommunication.GetApiRequest<List<TemplateClassList>>(ApiUrls.GlobalNETTemplateClassList, null, App.UserData.Authentification.Token);
    /// listVariable.ForEach(async rec => { rec.Translation = await DBOperations.DBTranslation(rec.SystemName); });
    /// </summary>
    public partial class ExampleClassListWithLocalTranslation {
        public int Id { get; set; } = 0;
        public string SystemName { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Translation { get; set; } = null;
    }

```

---


### MarkDown Template Help  
```cs

```

---

