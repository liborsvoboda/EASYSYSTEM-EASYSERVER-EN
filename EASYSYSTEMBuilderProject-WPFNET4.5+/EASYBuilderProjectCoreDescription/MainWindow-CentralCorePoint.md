## MAINWINDOW Central SYSTEM Control Manual
This is Core central point (MainWindow.xaml/cs) for full system
Here are Defined All join for Central Control for All parts of System
 
- MainWindow is Absolut Primary Control window off all actions in the application 
- Here are All global definitions, Messages, mainWindows and all Shared Controls for Pages
- Here are Application Menu events, Update, Reports, New/Edit/.. for Datalist, Filters, TabPages
- MainWindow Has Defined 3Menu Types for More Systems: 
       - Buttons in Header LINE -> For simple touch Terminal with few button for Agendas
       - SelectBox -> For TouchPanels with more MenuItems, but Touch functionality is Needed
       - TreeView -> For Robust Systems with a lot of MenuItems/Agendas
- in Xaml are declared all shared input/Controls/ETC for Application  
  App Update, Tools, Theme, Menus, Report Ctrl, Pages Controls, Graphics, ProgressRing, Tabpages Types, 

  



## IMPORTANT METHOD LIST SYSTEM CORE

---
**CORE SYSTEM METHODS**
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
**DATALIST GLOBAL METHODS**
- cb_FilterDropDownClosed - Reload Datalist with filtering
- Mi_filter_Click - Generate and show advanced filter (for SQL conditioning): 
- Cb_PrintReportsSelected - save fitler to DB, open selected Report
- Cb_verticalMenuSelected - Open selected Page/Agenda and set all controls,input,filter,reports status 
  **!!NEW AGENDA MUST BE DEFINED ONLY HERE.**
 

## INFO METHOD LIST SYSTEM CORE NOT NEEDED CHANGES
- Btn_about_click - Show About Info  
- WinMain_KeyDown - Global Control for Keyboard press ,implemented F1/ALT+Q

- Btn_LaunchHelp_Click - Open index.chm Windows Help File
- ApplicationClosing - Save theme, close App
- AppRestart - Restart for Configuration Reload
- StringToFilter - upload setted filter in page for actual view
- RemoveFilterItem_Click - Remove advanced filter Item
- FilterField_SelectionChanged - support methos for dynamic filter generation
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
#region MyReStandartized Definitions

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
/// Global Specific Methods For Customized Working
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