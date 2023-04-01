using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using GlobalNET.GlobalFunctions;
using MahApps.Metro.Controls.Dialogs;
using System.Net;

// This is Template Page ListView + UserForm + SubListView Only
namespace GlobalNET.Pages
{
    /// <summary>
    /// This standartized Template is only for list view od Data table
    /// Called from MainWindow.cs on open New Tab
    /// </summary>
    public partial class TemplateClassListWithSubViewPage : UserControl
    {
        /// <summary>
        /// Standartized declaring static page data and selected record for All Pages
        /// this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
        /// All is setted as global Classes for All Pages and Work is Fully automatized by System core
        /// 
        /// HERE you Define All Data Variables For This Form
        /// </summary>
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static CurrencyList selectedRecord = new CurrencyList();

        public ExtendedExchangeRateList selectedSubRecord = new ExtendedExchangeRateList();


        /// <summary>
        /// Initialize page with loading Dictionary and start loding data
        /// Manual work needed Translate All XAML fields by Resources
        /// Runned on start
        /// 
        /// </summary>
        public TemplateClassListWithSubViewPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            lbl_id.Content = Resources["id"].ToString(); 
            lbl_name.Content = Resources["fname"].ToString();
            lbl_exchangeRate.Content = Resources["exchangeRate"].ToString();
            lbl_fixed.Content = Resources["fixed"].ToString();
            lbl_description.Content = Resources["description"].ToString();
            lbl_default.Content = Resources["default"].ToString();
            lbl_active.Content = Resources["active"].ToString();

            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            _ = LoadDataList();
            SetRecord(false);
        }


        /// <summary>
        /// Standartized Method for Loading data. 
        /// Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
        /// Loading is same centralized only change ClasName For Diferent Dataset
        /// 
        /// After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working with pages Called from MainWindow.cs on Refresh button click
        /// Runned on Pageloading or Filter or View Change
        /// </summary>
        /// <returns></returns>
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.GlobalNETCurrencyList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token); }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }


        /// <summary>
        /// Standartized method for translating column names of DatagidView (List Data)
        /// Manual Changing is needed for set Translate of Column Names via Dictionary Items
        /// Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
        /// Runned On Page Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex"></param>
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Name") e.Header = Resources["fname"].ToString();
                else if (headername == "ExchangeRate") e.Header = Resources["exchangeRate"].ToString();
                else if (headername == "Fixed") e.Header = Resources["fixed"].ToString();
                else if (headername == "Description") e.Header = Resources["description"].ToString();
                else if (headername == "Default") { e.Header = Resources["default"].ToString(); e.DisplayIndex = DgListView.Columns.Count - 3; }
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
            });
        }


        /// <summary>
        /// Standartized method for searching match in setted columns. Searched value is from the simple 'Search Input' for DatagidView (List Data)
        /// Manual Changing is needed of filtered columns by Search Value 
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working with pages Called from MainWindow.cs
        /// Dynamicaly Called Only from MainWindow.cs when Search value Inserted
        /// </summary>
        /// <param name="filter"></param>
        public void Filter(string filter)
        {
            try
            {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) => {
                    CurrencyList user = e as CurrencyList;
                    return user.Name.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Description) && user.Description.ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }


        /// <summary>
        /// Standartized Method on All Pages with Forms for New Record
        /// ALL Needed changes Are done By Replace CLASSNAME not needed manual work
        /// Dynamicaly Called Only from MainWindow.cs on New button Click
        /// Only Set Record And Hide Dataview and Show Detail
        /// </summary>
        public void NewRecord()
        {
            selectedRecord = new CurrencyList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }


        /// <summary>
        /// Standartized Method on All Pages with Forms for New Record
        /// ALL Needed changes Are done By Replace CLASSNAME not needed manual work
        /// Dynamicaly Called Only from MainWindow.cs on Edit button Click
        /// Only Set Record And Hide Dataview and Show Detail with selected Record
        /// </summary>
        public void EditRecord(bool copy)
        {
            selectedRecord = (CurrencyList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }


        /// <summary>
        /// Standartized Method on All Pages with Forms for New Record
        /// ALL Needed changes Are done By Replace CLASSNAME not needed manual work
        /// Dynamicaly Called Only from MainWindow.cs on Delete button Click
        /// Show MainWindow Standartized Message with info About Delete and After confirm Send DeleteApiRequest
        /// Reload Datalist and cancel Selected Record
        /// </summary>
        public async void DeleteRecord()
        {
            selectedRecord = (CurrencyList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETCurrencyList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }


        /// <summary>
        /// Standartized method for selecting and opening Detail Form. This is only View Page, that is only for Select record
        /// This is full automatic, not needed manual work
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working page its local control From XAML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (CurrencyList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }


        /// <summary>
        /// Standartized method for select one record only.
        /// This is full automatic, not needed manual work
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working page its local control From XAML
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (CurrencyList)DgListView.SelectedItem;
            } else { selectedRecord = new CurrencyList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }


        /// <summary>
        /// Standartized method for Save Record And return to Dataview.
        /// Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction FORM to SELECTED RECORD
        /// By ClasName Replacing All other changes are automaticaly (API,DatasetType), just must define and control Each Field Of Dataset
        /// this method is for global working page its local control From XAML
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.Name = txt_name.Text;
                selectedRecord.ExchangeRate = (decimal)txt_exchangeRate.Value;
                selectedRecord.Fixed = (bool)chb_fixed.IsChecked;
                selectedRecord.Description = tb_description.Text;
                selectedRecord.Default = (bool)chb_default.IsChecked;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETCurrencyList, httpContent, null, App.UserData.Authentification.Token);
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETCurrencyList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new CurrencyList();
                    await LoadDataList();
                    SetRecord(false);
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }


        /// <summary>
        /// Standartized method for cancel of Editing. Hide Detail and Dataview List is Shown
        /// This is full automatic, not needed manual work
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working page its local control From XAML
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (CurrencyList)DgListView.SelectedItem : new CurrencyList();
            SetRecord(false);
        }


        /// <summary>
        /// Standartized method for ¨Set New Record/ Edit Record / Copy Record And return to Dataview.
        /// Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction Selected record to FORM
        /// By ClasName Replacing All other changes are automaticaly (API,DatasetType), just must define and control Each Field Of Dataset
        /// this method is for global working page its local control From XAML
        /// 
        /// In this type Form Here Are loaded Data for SublistView (on knows selected record for correct join)
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetRecord(bool showForm, bool copy = false)
        {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;
            txt_name.Text = selectedRecord.Name;
            txt_exchangeRate.Value = (double)selectedRecord.ExchangeRate;
            chb_fixed.IsChecked = selectedRecord.Fixed;
            tb_description.Text = selectedRecord.Description;
            chb_default.IsChecked = selectedRecord.Default;
            chb_active.IsChecked = (selectedRecord.Id == 0) ? App.Setting.ActiveNewInputDefault : selectedRecord.Active;

            if (showForm)
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
                if (!selectedRecord.Fixed) { SubListView.Visibility = Visibility.Visible; LoadSubDataList(); } else { SubListView.Visibility = Visibility.Hidden; }
            } else {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }


        /// <summary>
        /// Standartized Method for Loading SubData. 
        /// Manual Changing is needed for simple form is All changed By CLASNAME Chage, but If you need More API data for selection Here are Defined All incoming Data
        /// Loading is same centralized only change ClasName For Diferent Dataset
        /// 
        /// After all data for DatagridView (List Data) are loaded The ProgressRing is hidden
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working with pages Called from MainWindow.cs on Refresh button click
        /// Runned on Pageloading or Filter or View Change
        /// </summary>
        /// <returns></returns>
        public async void LoadSubDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            List<ExchangeRateList> exchangeRateList = new List<ExchangeRateList>();
            List<ExtendedExchangeRateList> extendedExchangeRateList = new List<ExtendedExchangeRateList>();
            try
            {
                if (MainWindow.serviceRunning) exchangeRateList = await ApiCommunication.GetApiRequest<List<ExchangeRateList>>(ApiUrls.GlobalNETExchangeRateList, null, App.UserData.Authentification.Token);
                exchangeRateList.Where(a => a.CurrencyId == selectedRecord.Id).ToList().ForEach(record => {
                    ExtendedExchangeRateList item = new ExtendedExchangeRateList()
                    {
                        Id = record.Id,
                        CurrencyId = record.CurrencyId,
                        Value = record.Value,
                        ValidFrom = record.ValidFrom,
                        ValidTo = record.ValidTo,
                        Description = record.Description,
                        UserId = record.UserId,
                        Active = record.Active,
                        TimeStamp = record.TimeStamp,
                        Currency = selectedRecord.Name
                    };
                    extendedExchangeRateList.Add(item);
                });
                DgSubListView.ItemsSource = extendedExchangeRateList;
                DgSubListView.Items.Refresh();
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
            MainWindow.ProgressRing = Visibility.Hidden;
        }


        /// <summary>
        /// Standartized method for translating column names of SubDatagidView (List Data)
        /// Manual Changing is needed for set Translate of Column Names via Dictionary Items
        /// Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
        /// Runned On Page Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex"></param>
        private void DgSubListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Currency") e.Header = Resources["currency"].ToString();
                else if (headername == "Value") e.Header = Resources["value"].ToString();
                else if (headername == "ValidFrom") e.Header = Resources["validFrom"].ToString();
                else if (headername == "ValidTo") e.Header = Resources["validTo"].ToString();
                else if (headername == "Description") e.Header = Resources["description"].ToString();
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "CurrencyId") e.Visibility = Visibility.Hidden;
            });
        }


        /// <summary>
        /// Standartized method for Loading Data for Selected Record
        /// This is full automatic, not needed manual work
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working page its local control From XAML
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fixed_Checked(object sender, RoutedEventArgs e) => SubListView.Visibility = Visibility.Hidden;
        private void Fixed_UnChecked(object sender, RoutedEventArgs e)
        {
            SubListView.Visibility = Visibility.Visible; LoadSubDataList();
        }

        
    }
}