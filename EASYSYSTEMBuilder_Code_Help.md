## EASYBuilder Description SYSTEM CORE
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

A full detailed description of the system core for easy development of any system with full support for automated functions, methods to make any of your applications work properly

**this information is divided into information for**
* rapid development  
* complete information about the basic function of the system

----
##Projects Documentation
Used automatic tools
* Generating MD from XML Documentation from code


Generating MD from XML Documentation from code
```xml
<DocumentationFile>bin\Debug\Documentation\GlobalNET.xml</DocumentationFile>
<DocumentationMarkdown>$(MSBuildProjectDirectory)\GlobalNET.md</DocumentationMarkdown>
```
 
## DECLARED SYSTEM CONDITIONS FOR DEVELOP NEW AGENDA
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

## SHORT SYSTEM DESCRIPTION

	System is Fully dynamic Controlled For All menuInserted Pages/Agendas 
	(Insert new Page/Agenda to menu + Translate for implement to full system only)

	All method are implemented with global logic of using for central Core of this System and his Modification
	For working with any standard system agenda (Typically IS System - SAP Example) 

	INSERT/UPDATE/DELETE/SELECT/FILTER/PRINT/SHOW/MEDIA 3D/VIDEO/DOCS/EAN CODES/1000 FINISHED TOOLS on GITHUB/UNLIMITED ETC

	FOR WINDOWS MODERN SYSTEMS/TERMINALS/ETC ON START (WEB FORMAT IS SUPPORTED BY TECHNOLOGY WILL BE DONE IN YEAR FUTURE

---
## MAINWINDOW Central SYSTEM Control Manual
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

  



## IMPORTANT METHOD LIST SYSTEM CORE

---
**CORE SYSTEM METHODS - OLDER,Was modernized**
- Initialize - Initiate Theme/Color/App menu/Load Config/Show Login   
 **Here is Translate Menu Items**
  
- Timer10sec_Elapsed - Auto Backend Timer cycling by Config [default 5sec]
    - check if Backend is Accesible - Server status Control
    - load Server Setting
    - Load Application Parameters for NULL user
    
- ShowLoginDialog - Login, Load User Params, Token, Enable Menu Items  
- ShowMessage - Shared Message for call from Pages For show in MainWindow  
- SetServiceStop - connect/disconnect menuItems Pages on Backend Service Status

---
**DATALIST GLOBAL METHODS - OLDER,Was modernized**
- cb_FilterDropDownClosed - Reload Datalist with filtering
- Mi_filter_Click - Generate and show advanced filter (for SQL conditioning): 
- Cb_PrintReportsSelected - save filter to DB, open selected Report
- Cb_verticalMenuSelected - Open selected Page/Agenda and set all controls,input,filter,reports status 
  **!!NEW AGENDA MUST BE DEFINED ONLY HERE.**
 

## INFO METHOD LIST SYSTEM CORE NOT NEEDED CHANGES - OLDER,Was modernized
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


**System Core Code Rules**
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
    var res = SystemFunctions.ParameterCheck("someParameterName").Correct ? int.Parse(SystemFunctions.ParameterCheck("someParameterName").Value) : 50;

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
## PAGE/AGENDA STANDARTIZED DEFINITION FOR CREATE NEW ANY SYSTEM STANDARD AGENGA

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

		Method Filter               - SEARCH Textox - SIMPLE SEARCH in all defined columns in PAGE code - Method Filter
		Method DgListView_Translate - Translate Datalist colum - translate column names by Xaml Language Dictionaries
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

## PREPARED TEMPLATES FOR FAST DEVELOPING - Older was Modernized
SYSTEM TEMPLATES FOR MAKE ANY TOUCH/IS/ETC. SYSTEM


**System HAS 4 Standard Data Form Types in Main Structure (System Templates)**  		
						   
    Implemented Forms for build Robust Any System  
	   TemplateListViewPage  - show DATALIST ONLY, used in Login history list
	   TemplateListPage      - show DATALIST WITH DETAIL FORM, Standard Dials,  
	                           used in Parameters, User, Roles, etc.
	   TemplateListPageWithSubViewPage - show DATALIST WITH DETAIL FORM AND SUB TABLE DATAVIEW   
	                                     used in Currency agenda 
	   TemplateListPageWithSubPage - show DATALIST WITH DETAIL FORM AND SUB TABLE DATAVIEW + FORM 
	                                 used in invoice, order for work 2Tables HEADER/Items in One time

**System HAS 3 Form Types in Main Structure (All are in Templates)**  
>DATALIST ONLY               - **TemplateListViewPage**   
	   Show Datalist only (Login history for example, views, etc..)
	   
> DATALIST WITH DETAIL FORM   - **TemplateListPage**           
       Show Datalist and Detail Form for PAge Table ( Dials, Simple agendas with one primary table, etc...)
       
>SETTING                     - **TemplateSettingsPage**       
Customized Forms with unlimited posibilities,(Setting Form, special Form, special Page, Video, 3D, etc)

**In System are implemented multimedia templates (MultiMedia Templates)** 

    Implemented Special MultiMedia Forms
        TemplateDocumentViewPage - XPS,PDF,TXT,and more format direct viewer/Print
        TemplateSTLPage          - Show 3D STL project
        TemplateVideoPage        - Play MP4 Video player
    
    Supported next implementation    
        GITHUB WPF TOOLS FOR SYSTEM IS / OS, HW can possible to implement for FREE
---

## API communication - 4 TYPES is enough
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

It is so. INSERT/UPDATE/DETETE/SELECT are the mentioned types which are enough
ensure the communication of any system.
And top it all off with a single list of APIaddress calls and communication is resolved
set up for this as a standardized automatic part of the kernel.

System kernel code dump, Where you just always add the address and don't care about anything else

**System APIAddresList - all calls in one place**

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

**4 API Calls - SYSTEM Core module**

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

## EASYBuilder Premade Templates
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

Pre-prepared templates are used to easily create a new agenda.
Even if there are only a few of them, they are fully sufficient to create complex systems of more or less all types, not only IS Systems - for which 4 templates are enough, but also Special Systems, Media Systems, Management / BI, and many others.
The system is nothing more than a list of very frequently repeated forms.

And you simply click on the graphic builder, which is part of Visual Studio. And that's the entire development of the system.
Here is a list of prepared templates in the system for more than n IS SYSTEM

---
**SystemTemplates - Media Templates --Older was modernized**
* TemplateListViewPage - Displays only the DataList. For example access history, Detailed form is not even needed

* TemplateListPage - displays the DataList and the Detailed form both for displaying the list and editing the record. That is, the most common template where you just edit the fields according to the table.

* TemplateListPageWithSubViewPage - displays the DataList and Detail form + additional DataList sub items. For example, the current exchange rate for currency. So it is a system type of Template

* TemplateListPageWithSubPage - displays a DataList and a Detail Form + another DataList with a Detail Item Form. For example Invoice - Header + Items. And with these templates you can write, for example, the entire SAP.

---
**MultiMediaTemplates - Media Templates --Older was modernized**
> TemplateVideoPage - Video player  
> TemplateSTLPage - STL representation of a 3D object   
> TemplateDocumentViewPage - Web browser that displays most file types  
   PDF, Docx, TXT, PNG, JPG, etc.

---
**CustomTemplates - Custom templates - Just slanted forms after all**
> TemplateSettingsPage - sample template for creating a unique form
These types, which you can click on in Visual Studio in the case of necessity, will reveal all unique types of forms when he wants anything atypical

**Shared Agendas - Real Creation**
In the SharedAgendas folder you will find approx. 50 Agendas - all forms already created forms for
immediate use or as an inspiration for the creation of new agendas.

**Code Examples**  
[https://learn.microsoft.com/cs-cz/samples/browse/?terms=xaml](https://learn.microsoft.com/cs-cz/samples/browse/?terms=xaml "")  

---


