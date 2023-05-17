using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalClasses;
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

    public partial class OfferListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ExtendedOfferList selectedRecord = new ExtendedOfferList();

        private DocumentAdviceList DocumentAdviceList = new DocumentAdviceList();
        private List<CurrencyList> CurrencyList = new List<CurrencyList>();
        private string Supplier = null; private string Customer = null;
        private List<AddressList> AddressList = new List<AddressList>();
        private string LastCustomerCorrectSearch, LastPartNumberCorrectSearch = ""; private bool messageShown = false;

        private List<DocumentItemList> DocumentItemList = new List<DocumentItemList>();
        private List<ItemList> ItemList = new List<ItemList>();
        private List<VatList> VatList = new List<VatList>();
        private List<NotesList> NotesList = new List<NotesList>();
        private List<UnitList> UnitList = new List<UnitList>();
        private string itemVatPriceFormat = "N2"; private string documentVatPriceFormat = "N0";

        public OfferListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            try
            {
                lbl_documentNumber.Content = Resources["documentNumber"].ToString();
                lbl_supplier.Content = Resources["supplier"].ToString();
                lbl_customer.Content = Resources["customer"].ToString();
                lbl_offerValidity.Content = Resources["offerValidity"].ToString();
                lbl_storned.Content = Resources["storned"].ToString();
                lbl_totalCurrency.Content = Resources["totalCurrency"].ToString();
                lbl_totalPrice.Content = Resources["totalPrice"].ToString();
                lbl_description.Content = Resources["description"].ToString();

                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();
                btn_insert.Content = Resources["insert"].ToString();
                btn_delete.Content = Resources["delete"].ToString();

                LoadParameters();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }

            _ = LoadDataList();
            SetRecord(false);
        }

        private async void LoadParameters() {
            itemVatPriceFormat = await DataOperations.ParameterCheck("ItemVatPriceFormat");
            documentVatPriceFormat = await DataOperations.ParameterCheck("DocumentVatPriceFormat");
            DgListView.RowHeight = int.Parse(await DataOperations.ParameterCheck("DocumentRowHeight"));
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            List<OfferList> offerList = new List<OfferList>();
            List<ExchangeRateList> exchangeRateList = new List<ExchangeRateList>();
            List<ExtendedOfferList> extendedOfferList = new List<ExtendedOfferList>();
            BranchList defaultAddress = new BranchList();
            try
            {
                defaultAddress = await ApiCommunication.GetApiRequest<BranchList>(ApiUrls.BranchList, "Active", App.UserData.Authentification.Token);
                DocumentAdviceList = await ApiCommunication.GetApiRequest<DocumentAdviceList>(ApiUrls.DocumentAdviceList, "offer/" + defaultAddress.Id, App.UserData.Authentification.Token);
                if (DocumentAdviceList == null) { await MainWindow.ShowMessage(true, Resources["documentAdviceNotSet"].ToString()); }
                cb_totalCurrency.ItemsSource = CurrencyList = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.CurrencyList, null, App.UserData.Authentification.Token);
                cb_notes.ItemsSource = NotesList = await ApiCommunication.GetApiRequest<List<NotesList>>(ApiUrls.NotesList, null, App.UserData.Authentification.Token);
                cb_unit.ItemsSource = UnitList = await ApiCommunication.GetApiRequest<List<UnitList>>(ApiUrls.UnitList, null, App.UserData.Authentification.Token);
                cb_vat.ItemsSource = VatList = await ApiCommunication.GetApiRequest<List<VatList>>(ApiUrls.VatList, null, App.UserData.Authentification.Token);

                CurrencyList.ForEach(async currency =>
                {
                    if (!currency.Fixed) { currency.ExchangeRate = (await ApiCommunication.GetApiRequest<ExchangeRateList>(ApiUrls.ExchangeRateList, currency.Name, App.UserData.Authentification.Token)).Value; }
                });

                Supplier = defaultAddress.CompanyName + Environment.NewLine +
                            defaultAddress.ContactName + Environment.NewLine +
                            defaultAddress.Street + Environment.NewLine +
                            defaultAddress.PostCode + " " + defaultAddress.City + Environment.NewLine + Environment.NewLine +
                            Resources["account"].ToString() + ": " + defaultAddress.BankAccount + Environment.NewLine +
                            Resources["ico"].ToString() + ": " + defaultAddress.Ico + "; " + Resources["dic"].ToString() + ": " + defaultAddress.Dic + Environment.NewLine +
                            Resources["phone"].ToString() + ": " + defaultAddress.Phone + Environment.NewLine +
                            Resources["email"].ToString() + ": " + defaultAddress.Email;

                offerList = await ApiCommunication.GetApiRequest<List<OfferList>>(ApiUrls.OfferList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
                offerList.ForEach(record =>
                {
                    ExtendedOfferList item = new ExtendedOfferList()
                    {
                        Id = record.Id,
                        DocumentNumber = record.DocumentNumber,
                        Supplier = record.Supplier,
                        Customer = record.Customer,
                        OfferValidity = record.OfferValidity,
                        Storned = record.Storned,
                        TotalCurrencyId = record.TotalCurrencyId,
                        Description = record.Description,
                        TotalPriceWithVat = record.TotalPriceWithVat,
                        UserId = record.UserId,
                        TimeStamp = record.TimeStamp,
                        TotalCurrency = CurrencyList.Where(a => a.Id == record.TotalCurrencyId).First().Name
                    };
                    extendedOfferList.Add(item);
                });
                DgListView.ItemsSource = extendedOfferList;
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
                    if (headername == "DocumentNumber") e.Header = Resources["documentNumber"].ToString();
                    else if (headername == "Supplier") e.Header = Resources["supplier"].ToString();
                    else if (headername == "Customer") e.Header = Resources["customer"].ToString();
                    else if (headername == "OfferValidity") { e.Header = Resources["offerValidity"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                    else if (headername == "Storned") { e.Header = Resources["storned"].ToString(); e.DisplayIndex = 8; }
                    else if (headername == "Description") e.Header = Resources["description"].ToString();
                    else if (headername == "TotalPriceWithVat") { e.Header = Resources["totalPriceWithVat"].ToString(); e.DisplayIndex = 5; e.CellStyle = DatagridStyles.gridTextRightAligment; (e as DataGridTextColumn).Binding.StringFormat = "N2"; }
                    else if (headername == "TotalCurrency") { e.Header = Resources["currency"].ToString(); e.DisplayIndex = 6; }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                    else if (headername == "TotalCurrencyId") e.Visibility = Visibility.Hidden;
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
                    ExtendedOfferList user = e as ExtendedOfferList;
                    return user.Customer.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Description) && user.Description.ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        public void NewRecord() {
            selectedRecord = new ExtendedOfferList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (ExtendedOfferList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (ExtendedOfferList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.OfferList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ExtendedOfferList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (ExtendedOfferList)DgListView.SelectedItem;
            }
            else { selectedRecord = new ExtendedOfferList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.DocumentNumber = txt_documentNumber.Text;
                selectedRecord.Supplier = txt_supplier.Text;
                selectedRecord.Customer = txt_customer.Text;
                selectedRecord.OfferValidity = (txt_offerValidity.Value == null) ? 30 : (int)txt_offerValidity.Value;
                selectedRecord.Storned = (bool)chb_storned.IsChecked;
                selectedRecord.TotalCurrencyId = ((CurrencyList)cb_totalCurrency.SelectedItem).Id;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.TotalPriceWithVat = decimal.Parse(txt_totalPrice.Text.Split(' ')[0]);
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                selectedRecord.TotalCurrency = null;
                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.OfferList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.OfferList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    //Save Items
                    DocumentItemList.ForEach(item => { item.Id = 0; item.DocumentNumber = dBResult.status; item.UserId = App.UserData.Authentification.Id; });
                    dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.OfferItemList, dBResult.status, App.UserData.Authentification.Token);
                    json = JsonConvert.SerializeObject(DocumentItemList); httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.OfferItemList, httpContent, null, App.UserData.Authentification.Token);
                    if (dBResult.recordCount != DocumentItemList.Count()) { await MainWindow.ShowMessage(true, Resources["itemsDBError"].ToString() + Environment.NewLine + dBResult.ErrorMessage); }
                    else
                    {
                        selectedRecord = new ExtendedOfferList();
                        await LoadDataList();
                        SetRecord(false);
                    }
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ExtendedOfferList)DgListView.SelectedItem : new ExtendedOfferList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private async void SetRecord(bool showForm, bool copy = false) {
            SetSubListsNonActiveOnNewItem(selectedRecord.Id == 0);
            selectedRecord.Id = (copy) ? 0 : selectedRecord.Id;

            string originalDocumentNumber = (string.IsNullOrWhiteSpace(selectedRecord.DocumentNumber) && !string.IsNullOrWhiteSpace(DocumentAdviceList.Number)) ? (DocumentAdviceList.Prefix + (int.Parse(DocumentAdviceList.Number) + 1).ToString("D" + DocumentAdviceList.Number.Length.ToString())) : selectedRecord.DocumentNumber;
            if (copy)
            {
                txt_documentNumber.Text = (DocumentAdviceList.Prefix + (int.Parse(DocumentAdviceList.Number) + 1).ToString("D" + DocumentAdviceList.Number.Length.ToString()));
            }
            else { txt_documentNumber.Text = originalDocumentNumber; }

            txt_supplier.Text = (!string.IsNullOrWhiteSpace(selectedRecord.Supplier)) ? selectedRecord.Supplier : Supplier;
            txt_customer.Text = selectedRecord.Customer;
            txt_offerValidity.Value = (selectedRecord.OfferValidity == 0) ? 30 : selectedRecord.OfferValidity;
            chb_storned.IsChecked = selectedRecord.Storned;
            cb_totalCurrency.Text = selectedRecord.TotalCurrency;
            txt_description.Text = selectedRecord.Description;

            if (showForm)
            {
                DocumentItemList = await ApiCommunication.GetApiRequest<List<DocumentItemList>>(ApiUrls.OfferItemList, originalDocumentNumber, App.UserData.Authentification.Token);
                DgSubListView.ItemsSource = DocumentItemList; DgSubListView.Items.Refresh(); ClearItemsFields(); txt_totalPrice.Text = DocumentItemList.Sum(a => a.TotalPriceWithVat).ToString(documentVatPriceFormat) + ((cb_totalCurrency.SelectedItem != null) ? " " + ((CurrencyList)cb_totalCurrency.SelectedItem).Name : "");
                if (CurrencyList.Where(a => a.Default).Count() == 1 && cb_totalCurrency.Text == null) { cb_totalCurrency.Text = CurrencyList.First(a => a.Default).Name; }

                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
            }
            else
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        private void DgSubListView_Translate(object sender, EventArgs ex) {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "PartNumber") e.Header = Resources["partNumber"].ToString();
                else if (headername == "Name") e.Header = Resources["fname"].ToString();
                else if (headername == "Unit") { e.Header = Resources["unit"].ToString(); ; e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "PcsPrice") { e.Header = Resources["pcsPrice"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Count") { e.Header = Resources["count"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "TotalPrice") { e.Header = Resources["totalPrice"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Vat") { e.Header = Resources["vat"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "TotalPriceWithVat") { e.Header = Resources["totalPriceWithVat"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Id") e.Visibility = Visibility.Hidden;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "TimeStamp") e.Visibility = Visibility.Hidden;
                else if (headername == "DocumentNumber") e.Visibility = Visibility.Hidden;
            });
        }

        private void SelectGotFocus(object sender, RoutedEventArgs e) => UpdateCustomerSearchResults();

        private async void UpdateCustomerSearchResults() {
            try
            {
                lv_customerSearchResults.Visibility = Visibility.Visible;
                List<AddressList> tempAddressList = AddressList.Where(a => a.CompanyName.ToLower().Contains(!string.IsNullOrWhiteSpace(txt_customerFilter.Text) ? txt_customerFilter.Text.ToLower() : "")).ToList();
                if (tempAddressList.Count() == 0 && !messageShown)
                {
                    messageShown = true;
                    var result = await MainWindow.ShowMessage(false, Resources["companyNotExist"].ToString());
                    if (result == MessageDialogResult.Affirmative) { messageShown = false; }
                    txt_customerFilter.Text = LastCustomerCorrectSearch; txt_customerFilter.CaretIndex = txt_customer.Text.Length;
                }
                else
                {
                    lv_customerSearchResults.ItemsSource = tempAddressList;
                    if (lv_customerSearchResults.Items.Count == 1)
                    {
                        lv_customerSearchResults.SelectedItem = lv_customerSearchResults.Items[0];
                        SetCustomer();
                    }
                    else { lv_customerSearchResults.Visibility = Visibility.Visible; }
                    LastCustomerCorrectSearch = txt_customerFilter.Text;
                }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void Customer_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Up && lv_customerSearchResults.Visibility == Visibility.Visible) { lv_customerSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_customerSearchResults.Visibility == Visibility.Visible) { lv_customerSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_customerSearchResults.Visibility == Visibility.Visible) { txt_customerFilter.Focus(); }
        }

        private void SelectCustomer_Enter(object sender, KeyEventArgs e) {
            if ((e.Key == Key.Enter) && lv_customerSearchResults.Visibility == Visibility.Visible) { SetCustomer(); }
        }

        private void MouseSelectCustomer_Click(object sender, MouseButtonEventArgs e) => SetCustomer();

        private void SetCustomer() {
            if (lv_customerSearchResults.SelectedIndex > -1)
            {
                Customer = ((AddressList)lv_customerSearchResults.SelectedItem).CompanyName + Environment.NewLine +
                            ((AddressList)lv_customerSearchResults.SelectedItem).ContactName + Environment.NewLine +
                            ((AddressList)lv_customerSearchResults.SelectedItem).Street + Environment.NewLine +
                            ((AddressList)lv_customerSearchResults.SelectedItem).PostCode + " " + ((AddressList)lv_customerSearchResults.SelectedItem).City + Environment.NewLine + Environment.NewLine +
                            Resources["account"].ToString() + ": " + ((AddressList)lv_customerSearchResults.SelectedItem).BankAccount + Environment.NewLine +
                            Resources["ico"].ToString() + ": " + ((AddressList)lv_customerSearchResults.SelectedItem).Ico + "; " + Resources["dic"].ToString() + ": " + ((AddressList)lv_customerSearchResults.SelectedItem).Dic + Environment.NewLine +
                            Resources["phone"].ToString() + ": " + ((AddressList)lv_customerSearchResults.SelectedItem).Phone + Environment.NewLine +
                            Resources["email"].ToString() + ": " + ((AddressList)lv_customerSearchResults.SelectedItem).Email;
                txt_customer.Text = Customer;
            }
            else { txt_customer.Text = null; }
            lv_customerSearchResults.Visibility = Visibility.Hidden; txt_customer.Focus();
        }

        private void PartNumberGotFocus(object sender, RoutedEventArgs e) => UpdatePartNumberSearchResults();

        private void NameGotFocus(object sender, RoutedEventArgs e) => lv_partNumberSearchResults.Visibility = Visibility.Hidden;

        private async void UpdatePartNumberSearchResults() {
            try
            {
                lv_partNumberSearchResults.Visibility = Visibility.Visible;
                List<ItemList> tempItemList = ItemList.Where(a => a.PartNumber.ToLower().Contains(!string.IsNullOrWhiteSpace(txt_partNumber.Text) ? txt_partNumber.Text.ToLower() : "")).ToList();
                if (tempItemList.Count() == 0 && !messageShown)
                {
                    messageShown = true;
                    var result = await MainWindow.ShowMessage(false, Resources["itemNotExist"].ToString());
                    if (result == MessageDialogResult.Affirmative) { messageShown = false; }
                    txt_partNumber.Text = LastPartNumberCorrectSearch; txt_partNumber.CaretIndex = txt_customer.Text.Length;
                }
                else
                {
                    lv_partNumberSearchResults.ItemsSource = tempItemList;
                    if (lv_partNumberSearchResults.Items.Count == 1)
                    {
                        lv_partNumberSearchResults.SelectedItem = lv_partNumberSearchResults.Items[0]; SetPartNumber();
                    }
                    else { lv_partNumberSearchResults.Visibility = Visibility.Visible; }
                    LastPartNumberCorrectSearch = txt_partNumber.Text;
                }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void PartNumber_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Up && lv_partNumberSearchResults.Visibility == Visibility.Visible) { lv_partNumberSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_partNumberSearchResults.Visibility == Visibility.Visible) { lv_partNumberSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_partNumberSearchResults.Visibility == Visibility.Visible) { txt_count.Focus(); }
        }

        private void SelectPartNumber_Enter(object sender, KeyEventArgs e) {
            if ((e.Key == Key.Enter) && lv_partNumberSearchResults.Visibility == Visibility.Visible) { SetPartNumber(); }
        }

        private void MouseSelectPartNumber_Click(object sender, MouseButtonEventArgs e) => SetPartNumber();

        private void CountChanged(object sender, RoutedPropertyChangedEventArgs<double?> e) => CalculateItemVatPrice();

        private void VatChanged(object sender, SelectionChangedEventArgs e) {
            CalculateItemVatPrice();
        }

        private void SetPartNumber() {
            if (lv_partNumberSearchResults.SelectedIndex > -1)
            {
                txt_partNumber.Text = ((ItemList)lv_partNumberSearchResults.SelectedItem).PartNumber;
                txt_name.Text = ((ItemList)lv_partNumberSearchResults.SelectedItem).Name;
                cb_unit.Text = ((ItemList)lv_partNumberSearchResults.SelectedItem).Unit;
                txt_pcsPrice.Value = double.Parse(((double)((ItemList)lv_partNumberSearchResults.SelectedItem).Price * (1 / (double)CurrencyList.First(a => a.Name == ((CurrencyList)cb_totalCurrency.SelectedItem).Name).ExchangeRate) * (double)CurrencyList.First(a => a.Id == ((ItemList)lv_partNumberSearchResults.SelectedItem).CurrencyId).ExchangeRate).ToString(itemVatPriceFormat));
                cb_vat.SelectedItem = VatList.First(a => a.Id == ((ItemList)lv_partNumberSearchResults.SelectedItem).VatId);
                CalculateItemVatPrice();
            }
            lv_partNumberSearchResults.Visibility = Visibility.Hidden; txt_count.Focus();
        }

        private void CalculateItemVatPrice() {
            try
            {
                txt_totalPriceWithVat.Text = ((double)txt_count.Value * (double)(txt_pcsPrice.Value + txt_pcsPrice.Value * (double)((VatList)cb_vat.SelectedItem).Value)).ToString(itemVatPriceFormat) + " " + ((CurrencyList)cb_totalCurrency.SelectedItem).Name;
                btn_insert.IsEnabled = true;
            }
            catch { txt_totalPriceWithVat.Text = null; btn_insert.IsEnabled = false; }
            txt_totalPrice.Text = DocumentItemList.Sum(a => a.TotalPriceWithVat).ToString(documentVatPriceFormat) + ((cb_totalCurrency.SelectedItem != null) ? " " + ((CurrencyList)cb_totalCurrency.SelectedItem).Name : "");
        }

        private void dgSubListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgSubListView.SelectedItems.Count > 0)
            {
                btn_delete.IsEnabled = true;
            }
            else { btn_delete.IsEnabled = false; }
        }

        private void BtnItemInsert_Click(object sender, RoutedEventArgs e) {
            try
            {
                DocumentItemList.Add(new DocumentItemList()
                {
                    DocumentNumber = txt_documentNumber.Text,
                    PartNumber = txt_partNumber.Text,
                    Name = txt_name.Text,
                    Unit = cb_unit.Text,
                    PcsPrice = (decimal)txt_pcsPrice.Value,
                    Count = (decimal)txt_count.Value,
                    TotalPrice = (decimal)txt_pcsPrice.Value * (decimal)txt_count.Value,
                    Vat = ((VatList)cb_vat.SelectedItem).Value,
                    TotalPriceWithVat = decimal.Parse(((double)txt_count.Value * (double)(txt_pcsPrice.Value + txt_pcsPrice.Value * (double)((VatList)cb_vat.SelectedItem).Value)).ToString(itemVatPriceFormat))
                });
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            DgSubListView.ItemsSource = DocumentItemList;
            DgSubListView.Items.Refresh();

            txt_totalPrice.Text = DocumentItemList.Sum(a => a.TotalPriceWithVat).ToString(documentVatPriceFormat) + ((cb_totalCurrency.SelectedItem != null) ? " " + ((CurrencyList)cb_totalCurrency.SelectedItem).Name : "");
            ClearItemsFields();
        }

        private void BtnItemDelete_Click(object sender, RoutedEventArgs e) {
            DocumentItemList.RemoveAt(DgSubListView.SelectedIndex);
            DgSubListView.ItemsSource = DocumentItemList;
            DgSubListView.Items.Refresh();
            txt_totalPrice.Text = DocumentItemList.Sum(a => a.TotalPriceWithVat).ToString(documentVatPriceFormat) + ((cb_totalCurrency.SelectedItem != null) ? " " + ((CurrencyList)cb_totalCurrency.SelectedItem).Name : "");
        }

        private void NotesChanged(object sender, SelectionChangedEventArgs e) {
            if (cb_notes.SelectedItem != null) { txt_description.Text = ((NotesList)cb_notes.SelectedItem).Description; cb_notes.SelectedItem = null; }
        }

        private void ClearItemsFields() {
            txt_partNumber.Text = txt_name.Text = cb_unit.Text = txt_totalPriceWithVat.Text = null;
            txt_count.Value = txt_pcsPrice.Value = null;
            cb_unit.SelectedItem = cb_vat.SelectedItem = null;
            lv_partNumberSearchResults.Visibility = Visibility.Hidden;
        }

        private async void SetSubListsNonActiveOnNewItem(bool newItem) {
            if (newItem)
            {
                cb_totalCurrency.ItemsSource = CurrencyList.Where(a => a.Active).ToList();
                AddressList = (await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, null, App.UserData.Authentification.Token)).Where(a => a.Active).ToList();
                ItemList = (await ApiCommunication.GetApiRequest<List<ItemList>>(ApiUrls.ItemList, null, App.UserData.Authentification.Token)).Where(a => a.Active).ToList();
                cb_notes.ItemsSource = NotesList.Where(a => a.Active).ToList(); cb_unit.ItemsSource = UnitList.Where(a => a.Active).ToList(); cb_vat.ItemsSource = VatList.Where(a => a.Active).ToList();
            }
            else
            {
                cb_totalCurrency.ItemsSource = CurrencyList;
                AddressList = await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, null, App.UserData.Authentification.Token);
                ItemList = await ApiCommunication.GetApiRequest<List<ItemList>>(ApiUrls.ItemList, null, App.UserData.Authentification.Token);
                cb_notes.ItemsSource = NotesList; cb_unit.ItemsSource = UnitList; cb_vat.ItemsSource = VatList;
            }
        }
    }
}