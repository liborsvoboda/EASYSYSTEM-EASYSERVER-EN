using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Net;


// This is Template Page ListView only Table Data View
namespace GlobalNET.Pages
{
    /// <summary>
    /// This standartized Template is only for list view od Data table
    /// Called from MainWindow.cs on open New Tab
    /// </summary>
    public partial class TemplateListViewPage : UserControl
    {

        /// <summary>
        /// Standartized declaring static page data and selected record for All Pages
        /// this method is for global working with pages Called from MainWindow.cs for Control of Button Menu and Selections (Report,Filter and more)
        /// All is setted as global Classes for All Pages and Work is Fully automatized by System core
        /// 
        /// </summary>
        public DataViewSupport dataViewSupport = new DataViewSupport();
        public TemplateClassList selectedRecord = new TemplateClassList();


        /// <summary>
        /// Initialize page with loading Dictionary and start loding data
        /// Runned on start
        /// </summary>
        public TemplateListViewPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            _ = LoadDataList();
            SetRecord();
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
            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<TemplateClassList>>(ApiUrls.GlobalNETTemplateClassList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token); }
            catch { }
            MainWindow.ProgressRing = Visibility.Hidden;return true;
        }


        /// <summary>
        /// Standartized method for translating column names of DatagidView (List Data)
        /// Here you can set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
        /// This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part)
        /// this method is for global working with page internal reaction on DatagrigView DataFiling on Start Page
        /// Runned On Page Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex"></param>
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            try { 
                ((DataGrid)sender).Columns.ToList().ForEach(e =>
                {
                    string headername = e.Header.ToString();
                    if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                });
            } catch { }
        }


        /// <summary>
        /// Standartized method for searching match in setted columns. Searched value is from the simple 'Search Input' for DatagidView (List Data)
        /// Here you define which column of Dataset will be filtered
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
                    TemplateClassList user = e as TemplateClassList;
                    return user.Name.ToLower().Contains(filter.ToLower())
                    || user.Description.ToLower().Contains(filter.ToLower());
                };
            } catch { }
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
            selectedRecord = (TemplateClassList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord();
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
            { selectedRecord = (TemplateClassList)DgListView.SelectedItem; }
            else { selectedRecord = new TemplateClassList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord();
        }


        /// <summary>
        /// Standartized method for Save Record And return to Dataview.
        /// Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction Selected record to FORM
        /// By ClasName Replacing All other changes are automaticaly (API,DatasetType), just must define and control Each Field Of Dataset
        /// this method is for global working page its local control From XAML
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetRecord()
        {
            MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
            ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
        }
    }
}