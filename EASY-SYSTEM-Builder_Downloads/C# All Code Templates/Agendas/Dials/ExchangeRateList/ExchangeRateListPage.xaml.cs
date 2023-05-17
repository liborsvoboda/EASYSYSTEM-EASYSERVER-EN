using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

// This is Template ListView + UserForm
namespace GlobalNET.Pages {

    public partial class ExchangeRateListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ExtendedExchangeRateList selectedRecord = new ExtendedExchangeRateList();

        private List<CurrencyList> CurrencyList = new List<CurrencyList>();

        public ExchangeRateListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            try
            {
                lbl_id.Content = Resources["id"].ToString();
                lbl_currency.Content = Resources["currency"].ToString();
                lbl_validFrom.Content = Resources["validFrom"].ToString();
                lbl_validTo.Content = Resources["validTo"].ToString();
                lbl_value.Content = Resources["value"].ToString();
                lbl_description.Content = Resources["description"].ToString();
                lbl_active.Content = Resources["active"].ToString();

                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            List<ExchangeRateList> ExchangeRateList = new List<ExchangeRateList>();
            List<ExtendedExchangeRateList> extendedExchangeRateList = new List<ExtendedExchangeRateList>();
            try
            {
                CurrencyList = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.CurrencyList, null, App.UserData.Authentification.Token);
                ExchangeRateList = await ApiCommunication.GetApiRequest<List<ExchangeRateList>>(ApiUrls.ExchangeRateList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);

                ExchangeRateList.ForEach(record =>
                {
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
                        Currency = CurrencyList.Where(a => a.Id == record.CurrencyId).First().Name
                    };
                    extendedExchangeRateList.Add(item);
                });
                cb_currency.ItemsSource = CurrencyList.Where(a => a.Fixed == false).ToList();
                DgListView.ItemsSource = extendedExchangeRateList;
                DgListView.Items.Refresh();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }

            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            try
            {
                ((DataGrid)sender).Columns.ToList().ForEach(e =>
                {
                    string headername = e.Header.ToString();
                    if (headername == "Currency") e.Header = Resources["currency"].ToString();
                    else if (headername == "ValidFrom") { e.Header = Resources["validFrom"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy"; }
                    else if (headername == "ValidTo") { e.Header = Resources["validTo"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy"; }
                    else if (headername == "Value") e.Header = Resources["value"].ToString();
                    else if (headername == "Description") e.Header = Resources["description"].ToString();
                    else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                    else if (headername == "CurrencyId") e.Visibility = Visibility.Hidden;
                });
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        //change filter fields
        public void Filter(string filter) {
            try
            {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) =>
                {
                    ExtendedExchangeRateList user = e as ExtendedExchangeRateList;
                    return user.Currency.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Description) && user.Description.ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        public void NewRecord() {
            selectedRecord = new ExtendedExchangeRateList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (ExtendedExchangeRateList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (ExtendedExchangeRateList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.ExchangeRateList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ExtendedExchangeRateList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (ExtendedExchangeRateList)DgListView.SelectedItem;
            }
            else { selectedRecord = new ExtendedExchangeRateList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.CurrencyId = ((CurrencyList)cb_currency.SelectedItem).Id;
                selectedRecord.Value = (decimal)txt_value.Value;
                selectedRecord.ValidFrom = dp_validFrom.Value;
                selectedRecord.ValidTo = dp_validTo.Value;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                selectedRecord.Currency = null;
                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.ExchangeRateList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.ExchangeRateList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new ExtendedExchangeRateList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ExtendedExchangeRateList)DgListView.SelectedItem : new ExtendedExchangeRateList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false) {
            SetSubListsNonActiveOnNewItem(selectedRecord.Id == 0);
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;
            cb_currency.Text = selectedRecord.Currency;
            txt_value.Value = (double)selectedRecord.Value;
            dp_validFrom.Value = selectedRecord.ValidFrom;
            dp_validTo.Value = selectedRecord.ValidTo;
            txt_description.Text = selectedRecord.Description;
            chb_active.IsChecked = (selectedRecord.Id == 0) ? App.Setting.ActiveNewInputDefault : selectedRecord.Active;

            if (showForm)
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
            }
            else
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        private void SetSubListsNonActiveOnNewItem(bool newItem) {
            if (newItem)
            {
                cb_currency.ItemsSource = CurrencyList.Where(a => a.Active).ToList();
            }
            else { cb_currency.ItemsSource = CurrencyList; }
        }
    }
}