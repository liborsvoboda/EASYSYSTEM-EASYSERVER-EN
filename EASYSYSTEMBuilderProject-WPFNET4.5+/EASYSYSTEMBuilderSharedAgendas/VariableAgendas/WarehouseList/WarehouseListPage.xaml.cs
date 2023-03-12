using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using System.Net;

namespace GlobalNET.Pages
{
    public partial class WarehouseListPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static WarehouseList selectedRecord = new WarehouseList();

        public WarehouseListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            try { 
                lbl_id.Content = Resources["id"].ToString();
                lbl_name.Content = Resources["fname"].ToString();
                lbl_description.Content = Resources["description"].ToString();
                lbl_active.Content = Resources["active"].ToString();
                lbl_allowNegativeStatus.Content = Resources["allowNegativeStatus"].ToString();
                lbl_default.Content = Resources["default"].ToString();
                lbl_lockedByStockTaking.Content = Resources["lockedByStockTaking"].ToString();
                lbl_lastStockTaking.Content = Resources["lastStockTaking"].ToString();

                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();
            } catch { }

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            try { 
                    DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<WarehouseList>>(ApiUrls.GlobalNETWarehouseList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token); 

            } catch { }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            try {
                ((DataGrid)sender).Columns.ToList().ForEach(e =>
                {
                    string headername = e.Header.ToString();
                    if (headername == "Name") e.Header = Resources["fname"].ToString();
                    else if (headername == "Description") e.Header = Resources["description"].ToString();
                    else if (headername == "AllowNegativeStatus") e.Header = Resources["allowNegativeStatus"].ToString();
                    else if (headername == "Default") e.Header = Resources["default"].ToString();
                    else if (headername == "LockedByStockTaking") e.Header = Resources["lockedByStockTaking"].ToString();
                    else if (headername == "LastStockTaking") { e.Header = Resources["lastStockTaking"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy HH:mm:ss"; }
                    else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                });
            } catch { }
        }

        //change filter fields
        public void Filter(string filter)
        {
            try {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) => {
                    WarehouseList user = e as WarehouseList;
                    return user.Name.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Description) && user.Description.ToLower().Contains(filter.ToLower());
                };
            } catch { }
        }

        public void NewRecord()
        {
            selectedRecord = new WarehouseList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy)
        {
            selectedRecord = (WarehouseList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord()
        {
            selectedRecord = (WarehouseList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETWarehouseList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (WarehouseList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (WarehouseList)DgListView.SelectedItem;
            }
            else { selectedRecord = new WarehouseList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.Name = txt_name.Text;
                selectedRecord.AllowNegativeStatus = (bool)chb_allowNegativeStatus.IsChecked;
                selectedRecord.Default = (bool)chb_default.IsChecked;
                selectedRecord.LockedByStockTaking = (bool)chb_lockedByStockTaking.IsChecked;
                selectedRecord.LastStockTaking = ((DateTime)dp_lastStockTaking.Value).Date;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETWarehouseList, httpContent, null, App.UserData.Authentification.Token);
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETWarehouseList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new WarehouseList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (WarehouseList)DgListView.SelectedItem : new WarehouseList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false)
        {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;
            txt_name.Text = selectedRecord.Name;
            chb_allowNegativeStatus.IsChecked = selectedRecord.AllowNegativeStatus;
            chb_default.IsChecked = selectedRecord.Default;
            chb_lockedByStockTaking.IsChecked = selectedRecord.LockedByStockTaking;
            dp_lastStockTaking.Value = selectedRecord.LastStockTaking;
            txt_description.Text = selectedRecord.Description;
            chb_active.IsChecked = (selectedRecord.Id == 0) ? App.Setting.ActiveNewInputDefault : selectedRecord.Active;

            if (showForm) {
                MainWindow.DataGridSelected = MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
            } else {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

    }
}