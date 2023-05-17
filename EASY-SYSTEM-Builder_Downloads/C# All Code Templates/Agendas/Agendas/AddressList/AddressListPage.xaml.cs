using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalClasses;
using GlobalNET.GlobalOperations;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GlobalNET.Pages {

    public partial class AddressListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static AddressList selectedRecord = new AddressList();

        public AddressListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            ObservableCollection<UpdateVariant> addressType = new ObservableCollection<UpdateVariant>() {
                                                               new UpdateVariant() { Name = Resources["all"].ToString(), Value = "all" },
                                                               new UpdateVariant() { Name = Resources["customer"].ToString(), Value = "customer" },
                                                               new UpdateVariant() { Name = Resources["supplier"].ToString(), Value = "supplier" },
                                                             };

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_companyName.Content = Resources["companyName"].ToString();
            lbl_contactName.Content = Resources["contactName"].ToString();
            lbl_street.Content = Resources["street"].ToString();
            lbl_city.Content = Resources["city"].ToString();
            lbl_postCode.Content = Resources["postCode"].ToString();
            lbl_phone.Content = Resources["phone"].ToString();
            lbl_email.Content = Resources["email"].ToString();
            lbl_bankAccount.Content = Resources["bankAccount"].ToString();
            lbl_addressType.Content = Resources["addressType"].ToString();
            lbl_ico.Content = Resources["ico"].ToString();
            lbl_dic.Content = Resources["dic"].ToString();
            lbl_active.Content = Resources["active"].ToString();

            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            cb_addressType.ItemsSource = addressType;

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token); }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }

            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "CompanyName") e.Header = Resources["companyName"].ToString();
                else if (headername == "ContactName") e.Header = Resources["contactName"].ToString();
                else if (headername == "Street") e.Header = Resources["street"].ToString();
                else if (headername == "City") e.Header = Resources["city"].ToString();
                else if (headername == "PostCode") e.Header = Resources["postCode"].ToString();
                else if (headername == "Phone") e.Header = Resources["phone"].ToString();
                else if (headername == "Email") e.Header = Resources["email"].ToString();
                else if (headername == "BankAccount") e.Header = Resources["bankAccount"].ToString();
                else if (headername == "Ico") e.Header = Resources["ico"].ToString();
                else if (headername == "Dic") e.Header = Resources["dic"].ToString();
                else if (headername == "Default") { e.Header = Resources["defaultAddress"].ToString(); e.DisplayIndex = DgListView.Columns.Count - 6; }
                else if (headername == "UnlockCode") { e.Header = Resources["unlockCode"].ToString(); e.DisplayIndex = DgListView.Columns.Count - 5; }
                else if (headername == "UnlockActivationHit") { e.Header = Resources["unlockActivationHit"].ToString(); e.DisplayIndex = DgListView.Columns.Count - 4; }
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "TimeStamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "AddressType") e.Visibility = Visibility.Hidden;
                else if (headername == "LicenseId") e.DisplayIndex = 0;
            });
        }

        //change filter fields
        public void Filter(string filter) {
            try
            {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) =>
                {
                    AddressList report = e as AddressList;
                    return report.AddressType.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.CompanyName) && report.CompanyName.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.ContactName) && report.ContactName.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.Street) && report.Street.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.City) && report.City.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.PostCode) && report.PostCode.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.Phone) && report.Phone.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.Email) && report.Email.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.BankAccount) && report.BankAccount.ToLower().Contains(filter.ToLower())
                    || report.AddressType.ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void NewRecord() {
            selectedRecord = new AddressList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (AddressList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (AddressList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.AddressList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (AddressList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (AddressList)DgListView.SelectedItem;
            }
            else { selectedRecord = new AddressList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.CompanyName = txt_companyName.Text;
                selectedRecord.ContactName = txt_contactName.Text;
                selectedRecord.Street = txt_street.Text;
                selectedRecord.City = txt_city.Text;
                selectedRecord.PostCode = txt_postCode.Text;
                selectedRecord.Phone = txt_phone.Text;
                selectedRecord.Email = txt_email.Text;
                selectedRecord.BankAccount = txt_bankAccount.Text;
                selectedRecord.AddressType = ((UpdateVariant)cb_addressType.SelectedItem).Value;
                selectedRecord.Ico = txt_ico.Text;
                selectedRecord.Dic = txt_dic.Text;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.AddressList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.AddressList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new AddressList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (AddressList)DgListView.SelectedItem : new AddressList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false) {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;
            txt_companyName.Text = selectedRecord.CompanyName;
            txt_contactName.Text = selectedRecord.ContactName;
            txt_street.Text = selectedRecord.Street;
            txt_city.Text = selectedRecord.City;
            txt_postCode.Text = selectedRecord.PostCode;
            txt_phone.Text = selectedRecord.Phone;
            txt_email.Text = selectedRecord.Email;
            txt_bankAccount.Text = selectedRecord.BankAccount;
            cb_addressType.Text = (selectedRecord.AddressType != null) ? Resources[selectedRecord.AddressType].ToString() : null;
            txt_ico.Text = selectedRecord.Ico;
            txt_dic.Text = selectedRecord.Dic;

            chb_active.IsChecked = selectedRecord.Active;

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
    }
}