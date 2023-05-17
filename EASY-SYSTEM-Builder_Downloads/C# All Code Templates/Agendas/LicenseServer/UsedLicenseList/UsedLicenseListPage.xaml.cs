using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using GlobalNET.GlobalStyles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GlobalNET.Pages {

    public partial class UsedLicenseListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ExtendedUsedLicenseList selectedRecord = new ExtendedUsedLicenseList();

        public UsedLicenseListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            _ = LoadDataList();
            SetRecord();
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            List<ItemList> itemList = new List<ItemList>();
            List<AddressList> addressList = new List<AddressList>();
            List<UsedLicenseList> UsedLicenseLists = new List<UsedLicenseList>();
            List<ExtendedUsedLicenseList> ExtendedUsedLicenseLists = new List<ExtendedUsedLicenseList>();
            try { if (MainWindow.serviceRunning) addressList = await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, null, App.UserData.Authentification.Token); }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            try { if (MainWindow.serviceRunning) itemList = await ApiCommunication.GetApiRequest<List<ItemList>>(ApiUrls.ItemList, null, App.UserData.Authentification.Token); }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            try { if (MainWindow.serviceRunning) UsedLicenseLists = await ApiCommunication.GetApiRequest<List<UsedLicenseList>>(ApiUrls.UsedLicenseList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token); }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            try
            {
                UsedLicenseLists.ForEach(record =>
                {
                    ExtendedUsedLicenseList item = new ExtendedUsedLicenseList()
                    {
                        Id = record.Id,
                        IpAddress = record.IpAddress,
                        UnlockCode = record.UnlockCode,
                        AlgorithmName = record.AlgorithmName,
                        PartNumber = record.PartNumber,
                        License = record.License,
                        ActivateDate = record.ActivateDate,
                        ItemId = record.ItemId,
                        AddressId = record.AddressId,
                        ItemName = itemList.Where(a => a.Id == record.ItemId).First().Name,
                        CompanyName = addressList.Where(a => a.Id == record.AddressId).First().CompanyName
                    };
                    ExtendedUsedLicenseLists.Add(item);
                });

                DgListView.ItemsSource = ExtendedUsedLicenseLists;
                DgListView.Items.Refresh();
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.Message); }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "Item") e.Header = Resources["item"].ToString();
                else if (headername == "PartNumber") { e.Header = Resources["partNumber"].ToString(); e.DisplayIndex = 1; }
                else if (headername == "CompanyName") e.Header = Resources["companyName"].ToString();
                else if (headername == "ItemName") e.Header = Resources["itemName"].ToString();
                else if (headername == "UnlockCode") e.Header = Resources["unlockCode"].ToString();
                else if (headername == "AlgorithmName") { e.Header = Resources["algorithmName"].ToString(); e.DisplayIndex = 2; }
                else if (headername == "License") e.Header = Resources["license"].ToString();
                else if (headername == "Activated") e.Header = Resources["activated"].ToString();
                else if (headername == "ActivateDate") e.Header = Resources["activateDate"].ToString();
                else if (headername == "IpAddress") e.Header = Resources["ipAddress"].ToString();
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "ItemId") e.Visibility = Visibility.Hidden;
                else if (headername == "AddressId") e.Visibility = Visibility.Hidden;
            });
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ExtendedUsedLicenseList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord();
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (ExtendedUsedLicenseList)DgListView.SelectedItem; }
            else { selectedRecord = new ExtendedUsedLicenseList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord();
        }

        //change filter fields
        public void Filter(string filter) {
            try
            {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) =>
                {
                    ExtendedUsedLicenseList LicenseList = e as ExtendedUsedLicenseList;
                    return LicenseList.PartNumber.ToLower().Contains(filter.ToLower())
                    || LicenseList.ItemName.ToLower().Contains(filter.ToLower())
                    || LicenseList.License.ToLower().Contains(filter.ToLower())
                    || LicenseList.AlgorithmName.ToLower().Contains(filter.ToLower())
                    || LicenseList.CompanyName.ToLower().Contains(filter.ToLower())
                    || LicenseList.ActivateDate.Value.ToShortDateString().ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(LicenseList.IpAddress) && LicenseList.IpAddress.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(LicenseList.ActivateDate.Value.ToString()) && LicenseList.ActivateDate.Value.ToUniversalTime().ToString().ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        //change dataset prepare for working
        private void SetRecord() {
            MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
            ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
        }
    }
}