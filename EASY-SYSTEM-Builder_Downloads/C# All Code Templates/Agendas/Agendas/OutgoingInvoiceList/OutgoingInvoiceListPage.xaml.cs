﻿using GlobalNET.Api;
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

    public partial class OutgoingInvoiceListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ExtendedOutgoingInvoiceList selectedRecord = new ExtendedOutgoingInvoiceList();

        private DocumentAdviceList DocumentAdviceList = new DocumentAdviceList();
        private List<CurrencyList> CurrencyList = new List<CurrencyList>();
        private List<MaturityList> MaturityList = new List<MaturityList>();
        private List<PaymentMethodList> PaymentMethodList = new List<PaymentMethodList>();
        private List<PaymentStatusList> PaymentStatusList = new List<PaymentStatusList>();
        private List<NotesList> NotesList = new List<NotesList>();

        private string Supplier = null; private string Customer = null;
        private List<AddressList> AddressList = new List<AddressList>();
        private string LastCustomerCorrectSearch, LastPartNumberCorrectSearch = ""; private bool messageShown = false;

        private List<DocumentItemList> DocumentItemList = new List<DocumentItemList>();
        private List<ItemList> ItemList = new List<ItemList>();
        private List<VatList> VatList = new List<VatList>();
        private List<UnitList> UnitList = new List<UnitList>();
        private string itemVatPriceFormat = "N2"; private string documentVatPriceFormat = "N0";

        public OutgoingInvoiceListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            try
            {
                lbl_documentNumber.Content = Resources["documentNumber"].ToString();
                lbl_supplier.Content = Resources["supplier"].ToString();
                lbl_customer.Content = Resources["customer"].ToString();
                lbl_issueDate.Content = Resources["issueDate"].ToString();
                lbl_paymentMethod.Content = Resources["paymentMethod"].ToString();
                lbl_taxDate.Content = Resources["taxDate"].ToString();
                lbl_orderNumber.Content = Resources["orderNumber"].ToString();
                lbl_maturityDate.Content = Resources["maturityDate"].ToString();
                lbl_maturity.Content = Resources["maturity"].ToString();
                lbl_totalCurrency.Content = Resources["totalCurrency"].ToString();
                lbl_totalPrice.Content = Resources["totalPrice"].ToString();
                lbl_paymentStatus.Content = Resources["paymentStatus"].ToString();
                lbl_storned.Content = Resources["storned"].ToString();
                lbl_description.Content = Resources["description"].ToString();

                btn_createReceipt.Content = Resources["createReceipt"].ToString();
                btn_showReceipt.Content = Resources["showReceipt"].ToString();

                btn_createCreditNote.Content = Resources["createCreditNote"].ToString();
                btn_showCreditNote.Content = Resources["showCreditNote"].ToString();
                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();
                btn_insert.Content = Resources["insert"].ToString();
                btn_delete.Content = Resources["delete"].ToString();

                LoadParameters();

                //OpenFormFromTiltOffer
                if (App.tiltTargets == TiltTargets.OfferToInvoice.ToString()) { ImportOffer(); }
                if (App.tiltTargets == TiltTargets.OrderToInvoice.ToString()) { ImportOrder(); }
                else { Task<bool> start = LoadDataList(); SetRecord(false); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private async void LoadParameters() {
            itemVatPriceFormat = await DataOperations.ParameterCheck("ItemVatPriceFormat");
            documentVatPriceFormat = await DataOperations.ParameterCheck("DocumentVatPriceFormat");
            DgListView.RowHeight = int.Parse(await DataOperations.ParameterCheck("DocumentRowHeight"));
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            List<OutgoingInvoiceList> outgoingInvoiceList = new List<OutgoingInvoiceList>();
            List<ExchangeRateList> exchangeRateList = new List<ExchangeRateList>();
            List<ExtendedOutgoingInvoiceList> extendedOutgoingInvoiceList = new List<ExtendedOutgoingInvoiceList>();
            BranchList defaultAddress = new BranchList();
            try
            {
                defaultAddress = await ApiCommunication.GetApiRequest<BranchList>(ApiUrls.BranchList, "Active", App.UserData.Authentification.Token);
                DocumentAdviceList = await ApiCommunication.GetApiRequest<DocumentAdviceList>(ApiUrls.DocumentAdviceList, "outgoingInvoice/" + defaultAddress.Id, App.UserData.Authentification.Token);
                if (DocumentAdviceList == null) { await MainWindow.ShowMessage(true, await DBOperations.DBTranslation("documentAdviceNotSet"), false); }
                AddressList = (await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, null, App.UserData.Authentification.Token)).Where(a => a.AddressType == "all" || a.AddressType == "supplier").ToList();
                cb_totalCurrency.ItemsSource = CurrencyList = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.CurrencyList, null, App.UserData.Authentification.Token);
                cb_notes.ItemsSource = NotesList = await ApiCommunication.GetApiRequest<List<NotesList>>(ApiUrls.NotesList, null, App.UserData.Authentification.Token);
                cb_maturity.ItemsSource = MaturityList = await ApiCommunication.GetApiRequest<List<MaturityList>>(ApiUrls.MaturityList, null, App.UserData.Authentification.Token);
                cb_paymentMethod.ItemsSource = PaymentMethodList = await ApiCommunication.GetApiRequest<List<PaymentMethodList>>(ApiUrls.PaymentMethodList, null, App.UserData.Authentification.Token);
                cb_paymentStatus.ItemsSource = PaymentStatusList = await ApiCommunication.GetApiRequest<List<PaymentStatusList>>(ApiUrls.PaymentStatusList, null, App.UserData.Authentification.Token);
                cb_unit.ItemsSource = UnitList = await ApiCommunication.GetApiRequest<List<UnitList>>(ApiUrls.UnitList, null, App.UserData.Authentification.Token);
                cb_vat.ItemsSource = VatList = await ApiCommunication.GetApiRequest<List<VatList>>(ApiUrls.VatList, null, App.UserData.Authentification.Token);
                ItemList = await ApiCommunication.GetApiRequest<List<ItemList>>(ApiUrls.ItemList, null, App.UserData.Authentification.Token);

                CurrencyList.ForEach(async currency =>
                {
                    if (!currency.Fixed)
                    {
                        ExchangeRateList exchangeRate = await ApiCommunication.GetApiRequest<ExchangeRateList>(ApiUrls.ExchangeRateList, currency.Name, App.UserData.Authentification.Token);
                        currency.ExchangeRate = exchangeRate != null ? exchangeRate.Value : 0;
                    }
                });

                Supplier = defaultAddress.CompanyName + Environment.NewLine +
                            defaultAddress.ContactName + Environment.NewLine +
                            defaultAddress.Street + Environment.NewLine +
                            defaultAddress.PostCode + " " + defaultAddress.City + Environment.NewLine + Environment.NewLine +
                            Resources["account"].ToString() + ": " + defaultAddress.BankAccount + Environment.NewLine +
                            Resources["ico"].ToString() + ": " + defaultAddress.Ico + "; " + Resources["dic"].ToString() + ": " + defaultAddress.Dic + Environment.NewLine +
                            Resources["phone"].ToString() + ": " + defaultAddress.Phone + Environment.NewLine +
                            Resources["email"].ToString() + ": " + defaultAddress.Email;

                outgoingInvoiceList = await ApiCommunication.GetApiRequest<List<OutgoingInvoiceList>>(ApiUrls.OutgoingInvoiceList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
                outgoingInvoiceList.ForEach(record =>
                {
                    ExtendedOutgoingInvoiceList item = new ExtendedOutgoingInvoiceList()
                    {
                        Id = record.Id,
                        DocumentNumber = record.DocumentNumber,
                        Supplier = record.Supplier,
                        Customer = record.Customer,
                        IssueDate = record.IssueDate,
                        TaxDate = record.TaxDate,
                        MaturityDate = record.MaturityDate,
                        PaymentMethodId = record.PaymentMethodId,
                        MaturityId = record.MaturityId,
                        OrderNumber = record.OrderNumber,
                        Storned = record.Storned,
                        PaymentStatusId = record.PaymentStatusId,
                        TotalCurrencyId = record.TotalCurrencyId,
                        Description = record.Description,
                        TotalPriceWithVat = record.TotalPriceWithVat,
                        ReceiptId = record.ReceiptId,
                        CreditNoteId = record.CreditNoteId,
                        UserId = record.UserId,
                        TimeStamp = record.TimeStamp,
                        TotalCurrency = CurrencyList.Where(a => a.Id == record.TotalCurrencyId).First().Name,
                        ReceiptExist = !string.IsNullOrWhiteSpace(record.ReceiptId.ToString()),
                        CreditNoteExist = !string.IsNullOrWhiteSpace(record.CreditNoteId.ToString())
                    };
                    extendedOutgoingInvoiceList.Add(item);
                });
                DgListView.ItemsSource = extendedOutgoingInvoiceList;
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
                    if (headername == "DocumentNumber") { e.Header = Resources["documentNumber"].ToString(); e.DisplayIndex = 1; }
                    else if (headername == "Supplier") e.Header = Resources["supplier"].ToString();
                    else if (headername == "Customer") e.Header = Resources["customer"].ToString();
                    else if (headername == "OrderNumber") { e.Header = Resources["customerOrderNumber"].ToString(); e.DisplayIndex = 4; }
                    else if (headername == "IssueDate") { e.Header = Resources["issueDate"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy"; e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = 8; }
                    else if (headername == "MaturityDate") { e.Header = Resources["maturityDate"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy"; e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = 9; }
                    else if (headername == "Storned") { e.Header = Resources["storned"].ToString(); e.DisplayIndex = DgListView.Columns.Count - 2; }
                    else if (headername == "Description") e.Header = Resources["description"].ToString();
                    else if (headername == "TotalPriceWithVat") { e.Header = Resources["totalPriceWithVat"].ToString(); e.DisplayIndex = 7; e.CellStyle = DatagridStyles.gridTextRightAligment; (e as DataGridTextColumn).Binding.StringFormat = "N2"; }
                    else if (headername == "TotalCurrency") { e.Header = Resources["currency"].ToString(); e.DisplayIndex = 8; }
                    else if (headername == "ReceiptExist") { e.Header = Resources["receipt"].ToString(); e.DisplayIndex = 2; }
                    else if (headername == "CreditNoteExist") { e.Header = Resources["creditNote"].ToString(); e.DisplayIndex = 3; }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                    else if (headername == "TotalCurrencyId") e.Visibility = Visibility.Hidden;
                    else if (headername == "PaymentMethodId") e.Visibility = Visibility.Hidden;
                    else if (headername == "MaturityId") e.Visibility = Visibility.Hidden;
                    else if (headername == "PaymentStatusId") e.Visibility = Visibility.Hidden;
                    else if (headername == "TaxDate") e.Visibility = Visibility.Hidden;
                    else if (headername == "ReceiptId") e.Visibility = Visibility.Hidden;
                    else if (headername == "CreditNoteId") e.Visibility = Visibility.Hidden;
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
                    ExtendedOutgoingInvoiceList invoice = e as ExtendedOutgoingInvoiceList;
                    return invoice.Customer.ToLower().Contains(filter.ToLower())
                    || invoice.DocumentNumber.ToLower().Contains(filter.ToLower())
                    || invoice.IssueDate.ToShortDateString().ToLower().Contains(filter.ToLower())
                    || invoice.MaturityDate.ToShortDateString().ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(invoice.OrderNumber) && invoice.OrderNumber.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(invoice.Description) && invoice.Description.ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        public void NewRecord() {
            selectedRecord = new ExtendedOutgoingInvoiceList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (ExtendedOutgoingInvoiceList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (ExtendedOutgoingInvoiceList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.OutgoingInvoiceList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ExtendedOutgoingInvoiceList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (ExtendedOutgoingInvoiceList)DgListView.SelectedItem; }
            else { selectedRecord = new ExtendedOutgoingInvoiceList(); }
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

                selectedRecord.OrderNumber = txt_orderNumber.Text;
                selectedRecord.IssueDate = ((DateTime)dp_issueDate.Value).Date;
                selectedRecord.TaxDate = ((DateTime)dp_taxDate.Value).Date;
                selectedRecord.MaturityDate = ((DateTime)dp_maturityDate.Value).Date;
                selectedRecord.MaturityId = ((MaturityList)cb_maturity.SelectedItem).Id;
                selectedRecord.PaymentMethodId = ((PaymentMethodList)cb_paymentMethod.SelectedItem).Id;
                selectedRecord.PaymentStatusId = ((PaymentStatusList)cb_paymentStatus.SelectedItem).Id;
                selectedRecord.TotalCurrencyId = ((CurrencyList)cb_totalCurrency.SelectedItem).Id;
                selectedRecord.Storned = (bool)chb_storned.IsChecked;
                selectedRecord.TotalCurrencyId = ((CurrencyList)cb_totalCurrency.SelectedItem).Id;
                selectedRecord.TotalPriceWithVat = decimal.Parse(txt_totalPrice.Text.Split(' ')[0]);
                selectedRecord.Description = txt_description.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                selectedRecord.TotalCurrency = null;
                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.OutgoingInvoiceList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.OutgoingInvoiceList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    //Save Items
                    DocumentItemList.ForEach(item => { item.Id = 0; item.DocumentNumber = dBResult.status; item.UserId = App.UserData.Authentification.Id; });
                    dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.OutgoingInvoiceItemList, dBResult.status, App.UserData.Authentification.Token);
                    json = JsonConvert.SerializeObject(DocumentItemList); httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.OutgoingInvoiceItemList, httpContent, null, App.UserData.Authentification.Token);
                    if (dBResult.recordCount != DocumentItemList.Count())
                    {
                        await MainWindow.ShowMessage(true, Resources["itemsDBError"].ToString() + Environment.NewLine + dBResult.ErrorMessage);
                    }
                    else
                    {
                        selectedRecord = new ExtendedOutgoingInvoiceList();
                        await LoadDataList();
                        SetRecord(false);
                    }
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ExtendedOutgoingInvoiceList)DgListView.SelectedItem : new ExtendedOutgoingInvoiceList();
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

            txt_customer.Text = selectedRecord.Customer;
            txt_supplier.Text = (!string.IsNullOrWhiteSpace(selectedRecord.Supplier)) ? selectedRecord.Supplier : Supplier;
            dp_issueDate.Value = selectedRecord.IssueDate;
            dp_taxDate.Value = selectedRecord.TaxDate;
            cb_maturity.Text = (MaturityList.Count > 0 && selectedRecord.MaturityId != null) ? MaturityList.FirstOrDefault(a => a.Id == selectedRecord.MaturityId).Name : "";
            cb_paymentMethod.Text = (PaymentMethodList.Count > 0 && selectedRecord.PaymentMethodId != null) ? PaymentMethodList.FirstOrDefault(a => a.Id == selectedRecord.PaymentMethodId).Name : "";
            cb_paymentStatus.Text = (PaymentStatusList.Count > 0 && selectedRecord.PaymentStatusId != null) ? PaymentStatusList.FirstOrDefault(a => a.Id == selectedRecord.PaymentStatusId).Name : "";
            chb_storned.IsChecked = selectedRecord.Storned;
            cb_totalCurrency.Text = selectedRecord.TotalCurrency;
            txt_description.Text = selectedRecord.Description;
            txt_orderNumber.Text = selectedRecord.OrderNumber;

            if (showForm)
            {
                //Load Items and Defaults
                HideTiltButtons();
                if (App.tiltTargets == TiltTargets.OfferToInvoice.ToString() || App.tiltTargets == TiltTargets.OrderToInvoice.ToString()) { DocumentItemList = App.TiltDocItems; }
                else { DocumentItemList = await ApiCommunication.GetApiRequest<List<DocumentItemList>>(ApiUrls.OutgoingInvoiceItemList, originalDocumentNumber, App.UserData.Authentification.Token); }

                DgSubListView.ItemsSource = DocumentItemList; DgSubListView.Items.Refresh(); ClearItemsFields(); txt_totalPrice.Text = DocumentItemList.Sum(a => a.TotalPriceWithVat).ToString(documentVatPriceFormat) + ((cb_totalCurrency.SelectedItem != null) ? " " + ((CurrencyList)cb_totalCurrency.SelectedItem).Name : "");
                if (CurrencyList.Where(a => a.Default).Count() == 1 && string.IsNullOrWhiteSpace(cb_totalCurrency.Text)) { cb_totalCurrency.Text = CurrencyList.First(a => a.Default).Name; }
                if (MaturityList.Where(a => a.Default).Count() == 1 && string.IsNullOrWhiteSpace(cb_maturity.Text)) { cb_maturity.Text = MaturityList.First(a => a.Default).Name; dp_maturityDate.Value = DateTimeOffset.Now.AddDays(double.Parse(MaturityList.First(a => a.Default).Value.ToString())).Date; }
                if (PaymentMethodList.Where(a => a.Default).Count() == 1 && string.IsNullOrWhiteSpace(cb_paymentMethod.Text)) { cb_paymentMethod.Text = PaymentMethodList.First(a => a.Default).Name; }
                if (PaymentStatusList.Where(a => a.Default).Count() == 1 && string.IsNullOrWhiteSpace(cb_paymentStatus.Text)) { cb_paymentStatus.Text = PaymentStatusList.First(a => a.Default).Name; }

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
                HideTiltButtons();
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
                HideTiltButtons();
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

        private void DateChanged(object sender, RoutedPropertyChangedEventArgs<object> e) => HideTiltButtons();

        private void AddressChanged(object sender, TextChangedEventArgs e) => HideTiltButtons();

        private void VatChanged(object sender, SelectionChangedEventArgs e) {
            HideTiltButtons(); CalculateItemVatPrice();
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
            HideTiltButtons(); if (cb_notes.SelectedItem != null) { txt_description.Text = ((NotesList)cb_notes.SelectedItem).Description; cb_notes.SelectedItem = null; }
        }

        private void MaturityChanged(object sender, SelectionChangedEventArgs e) {
            if (cb_maturity.SelectedItem != null) { dp_maturityDate.Value = ((DateTime)dp_issueDate.Value).AddDays(((MaturityList)cb_maturity.SelectedItem).Value).Date; }
        }

        private void IssueDateChanged(object sender, RoutedPropertyChangedEventArgs<object> e) {
            if (cb_maturity.SelectedItem != null) { dp_taxDate.Value = dp_issueDate.Value; dp_maturityDate.Value = ((DateTime)dp_issueDate.Value).AddDays(((MaturityList)cb_maturity.SelectedItem).Value).Date; }
        }

        private void ClearItemsFields() {
            txt_partNumber.Text = txt_name.Text = cb_unit.Text = txt_totalPriceWithVat.Text = null;
            txt_count.Value = txt_pcsPrice.Value = null;
            cb_unit.SelectedItem = cb_vat.SelectedItem = null;
            lv_partNumberSearchResults.Visibility = Visibility.Hidden;
        }

        private void SetSubListsNonActiveOnNewItem(bool newItem) {
            if (newItem)
            {
                cb_totalCurrency.ItemsSource = CurrencyList.Where(a => a.Active).ToList();
                cb_notes.ItemsSource = NotesList.Where(a => a.Active).ToList();
                cb_maturity.ItemsSource = MaturityList.Where(a => a.Active).ToList();
                cb_paymentMethod.ItemsSource = PaymentMethodList.Where(a => a.Active).ToList();
                cb_paymentStatus.ItemsSource = PaymentStatusList.Where(a => a.Active).ToList();
            }
            else
            {
                cb_totalCurrency.ItemsSource = CurrencyList; cb_notes.ItemsSource = NotesList; cb_maturity.ItemsSource = MaturityList;
                cb_paymentMethod.ItemsSource = PaymentMethodList; cb_paymentStatus.ItemsSource = PaymentStatusList;
            }
        }

        private async void ImportOffer() {
            try
            {
                MainWindow.ProgressRing = Visibility.Visible;
                List<OutgoingInvoiceList> OutgoingInvoiceList = new List<OutgoingInvoiceList>();
                List<ExchangeRateList> exchangeRateList = new List<ExchangeRateList>();
                List<ExtendedOutgoingInvoiceList> extendedOutgoingInvoiceList = new List<ExtendedOutgoingInvoiceList>();
                BranchList defaultAddress = new BranchList();

                defaultAddress = await ApiCommunication.GetApiRequest<BranchList>(ApiUrls.BranchList, "Active", App.UserData.Authentification.Token);
                DocumentAdviceList = await ApiCommunication.GetApiRequest<DocumentAdviceList>(ApiUrls.DocumentAdviceList, "outgoingInvoice/" + defaultAddress.Id, App.UserData.Authentification.Token);
                if (DocumentAdviceList == null) { await MainWindow.ShowMessage(true, Resources["documentAdviceNotSet"].ToString()); }
                AddressList = (await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, null, App.UserData.Authentification.Token)).Where(a => a.AddressType == "all" || a.AddressType == "supplier").ToList();
                cb_totalCurrency.ItemsSource = CurrencyList = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.CurrencyList, null, App.UserData.Authentification.Token);
                cb_notes.ItemsSource = NotesList = await ApiCommunication.GetApiRequest<List<NotesList>>(ApiUrls.NotesList, null, App.UserData.Authentification.Token);
                cb_maturity.ItemsSource = MaturityList = await ApiCommunication.GetApiRequest<List<MaturityList>>(ApiUrls.MaturityList, null, App.UserData.Authentification.Token);
                cb_paymentMethod.ItemsSource = PaymentMethodList = await ApiCommunication.GetApiRequest<List<PaymentMethodList>>(ApiUrls.PaymentMethodList, null, App.UserData.Authentification.Token);
                cb_paymentStatus.ItemsSource = PaymentStatusList = await ApiCommunication.GetApiRequest<List<PaymentStatusList>>(ApiUrls.PaymentStatusList, null, App.UserData.Authentification.Token);

                CurrencyList.ForEach(async currency =>
                {
                    if (!currency.Fixed) { currency.ExchangeRate = (await ApiCommunication.GetApiRequest<ExchangeRateList>(ApiUrls.ExchangeRateList, currency.Name, App.UserData.Authentification.Token)).Value; }
                });

                OutgoingInvoiceList = await ApiCommunication.GetApiRequest<List<OutgoingInvoiceList>>(ApiUrls.OutgoingInvoiceList, null, App.UserData.Authentification.Token);
                OutgoingInvoiceList.ForEach(record =>
                {
                    ExtendedOutgoingInvoiceList gdItem = new ExtendedOutgoingInvoiceList()
                    {
                        Id = record.Id,
                        DocumentNumber = record.DocumentNumber,
                        Supplier = record.Supplier,
                        Customer = record.Customer,
                        IssueDate = record.IssueDate,
                        TaxDate = record.TaxDate,
                        MaturityDate = record.MaturityDate,
                        PaymentMethodId = record.PaymentMethodId,
                        MaturityId = record.MaturityId,
                        OrderNumber = record.OrderNumber,
                        Storned = record.Storned,
                        PaymentStatusId = record.PaymentStatusId,
                        TotalCurrencyId = record.TotalCurrencyId,
                        Description = record.Description,
                        UserId = record.UserId,
                        TimeStamp = record.TimeStamp,
                        TotalCurrency = CurrencyList.Where(a => a.Id == record.TotalCurrencyId).First().Name
                    };
                    extendedOutgoingInvoiceList.Add(gdItem);
                });
                DgListView.ItemsSource = extendedOutgoingInvoiceList;
                DgListView.Items.Refresh();

                ExtendedOutgoingInvoiceList item = new ExtendedOutgoingInvoiceList()
                {
                    Id = App.TiltOfferDoc.Id,
                    DocumentNumber = App.TiltOfferDoc.DocumentNumber,
                    Supplier = App.TiltOfferDoc.Supplier,
                    Customer = App.TiltOfferDoc.Customer,
                    IssueDate = DateTimeOffset.Now.Date,
                    TaxDate = DateTimeOffset.Now.Date,
                    MaturityDate = DateTimeOffset.Now.Date.AddDays(MaturityList.FirstOrDefault(a => a.Default).Value), //dopocitat z defaultu
                    PaymentMethodId = PaymentMethodList.FirstOrDefault(a => a.Default).Id,
                    MaturityId = MaturityList.FirstOrDefault(a => a.Default).Id,
                    OrderNumber = null,
                    Storned = App.TiltOfferDoc.Storned,
                    PaymentStatusId = PaymentStatusList.FirstOrDefault(a => a.Default).Id,
                    TotalCurrencyId = App.TiltOfferDoc.TotalCurrencyId,
                    Description = App.TiltOfferDoc.Description,
                    UserId = App.TiltOfferDoc.UserId,
                    TimeStamp = DateTimeOffset.Now.DateTime,
                    TotalCurrency = CurrencyList.Where(a => a.Id == App.TiltOfferDoc.TotalCurrencyId).First().Name
                };
                selectedRecord = item;
                SetRecord(true, true);
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            App.TiltOfferDoc = new OfferList(); App.TiltDocItems = new List<DocumentItemList>(); App.tiltTargets = TiltTargets.None.ToString();

            MainWindow.ProgressRing = Visibility.Hidden;
        }

        private async void ImportOrder() {
            try
            {
                MainWindow.ProgressRing = Visibility.Visible;
                List<OutgoingInvoiceList> OutgoingInvoiceList = new List<OutgoingInvoiceList>();
                List<ExchangeRateList> exchangeRateList = new List<ExchangeRateList>();
                List<ExtendedOutgoingInvoiceList> extendedOutgoingInvoiceList = new List<ExtendedOutgoingInvoiceList>();
                BranchList defaultAddress = new BranchList();

                defaultAddress = await ApiCommunication.GetApiRequest<BranchList>(ApiUrls.BranchList, "Active", App.UserData.Authentification.Token);
                DocumentAdviceList = await ApiCommunication.GetApiRequest<DocumentAdviceList>(ApiUrls.DocumentAdviceList, "outgoingInvoice/" + defaultAddress.Id, App.UserData.Authentification.Token);
                if (DocumentAdviceList == null) { await MainWindow.ShowMessage(true, Resources["documentAdviceNotSet"].ToString()); }
                AddressList = (await ApiCommunication.GetApiRequest<List<AddressList>>(ApiUrls.AddressList, null, App.UserData.Authentification.Token)).Where(a => a.AddressType == "all" || a.AddressType == "supplier").ToList();
                cb_totalCurrency.ItemsSource = CurrencyList = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.CurrencyList, null, App.UserData.Authentification.Token);
                cb_notes.ItemsSource = NotesList = await ApiCommunication.GetApiRequest<List<NotesList>>(ApiUrls.NotesList, null, App.UserData.Authentification.Token);
                cb_maturity.ItemsSource = MaturityList = await ApiCommunication.GetApiRequest<List<MaturityList>>(ApiUrls.MaturityList, null, App.UserData.Authentification.Token);
                cb_paymentMethod.ItemsSource = PaymentMethodList = await ApiCommunication.GetApiRequest<List<PaymentMethodList>>(ApiUrls.PaymentMethodList, null, App.UserData.Authentification.Token);
                cb_paymentStatus.ItemsSource = PaymentStatusList = await ApiCommunication.GetApiRequest<List<PaymentStatusList>>(ApiUrls.PaymentStatusList, null, App.UserData.Authentification.Token);

                CurrencyList.ForEach(async currency =>
                {
                    if (!currency.Fixed) { currency.ExchangeRate = (await ApiCommunication.GetApiRequest<ExchangeRateList>(ApiUrls.ExchangeRateList, currency.Name, App.UserData.Authentification.Token)).Value; }
                });

                OutgoingInvoiceList = await ApiCommunication.GetApiRequest<List<OutgoingInvoiceList>>(ApiUrls.OutgoingInvoiceList, null, App.UserData.Authentification.Token);
                OutgoingInvoiceList.ForEach(record =>
                {
                    ExtendedOutgoingInvoiceList gdItem = new ExtendedOutgoingInvoiceList()
                    {
                        Id = record.Id,
                        DocumentNumber = record.DocumentNumber,
                        Supplier = record.Supplier,
                        Customer = record.Customer,
                        IssueDate = record.IssueDate,
                        TaxDate = record.TaxDate,
                        MaturityDate = record.MaturityDate,
                        PaymentMethodId = record.PaymentMethodId,
                        MaturityId = record.MaturityId,
                        OrderNumber = record.OrderNumber,
                        Storned = record.Storned,
                        PaymentStatusId = record.PaymentStatusId,
                        TotalCurrencyId = record.TotalCurrencyId,
                        Description = record.Description,
                        UserId = record.UserId,
                        TimeStamp = record.TimeStamp,
                        TotalCurrency = CurrencyList.Where(a => a.Id == record.TotalCurrencyId).First().Name
                    };
                    extendedOutgoingInvoiceList.Add(gdItem);
                });
                DgListView.ItemsSource = extendedOutgoingInvoiceList;
                DgListView.Items.Refresh();

                ExtendedOutgoingInvoiceList item = new ExtendedOutgoingInvoiceList()
                {
                    Id = App.TiltOrderDoc.Id,
                    DocumentNumber = App.TiltOrderDoc.DocumentNumber,
                    Supplier = App.TiltOrderDoc.Supplier,
                    Customer = App.TiltOrderDoc.Customer,
                    IssueDate = DateTimeOffset.Now.Date,
                    TaxDate = DateTimeOffset.Now.Date,
                    MaturityDate = DateTimeOffset.Now.Date.AddDays(MaturityList.FirstOrDefault(a => a.Default).Value), //dopocitat z defaultu
                    PaymentMethodId = PaymentMethodList.FirstOrDefault(a => a.Default).Id,
                    MaturityId = MaturityList.FirstOrDefault(a => a.Default).Id,
                    OrderNumber = App.TiltOrderDoc.CustomerOrderNumber,
                    Storned = App.TiltOrderDoc.Storned,
                    PaymentStatusId = PaymentStatusList.FirstOrDefault(a => a.Default).Id,
                    TotalCurrencyId = App.TiltOrderDoc.TotalCurrencyId,
                    Description = App.TiltOrderDoc.Description,
                    UserId = App.TiltOrderDoc.UserId,
                    TimeStamp = DateTimeOffset.Now.DateTime,
                    TotalCurrency = CurrencyList.Where(a => a.Id == App.TiltOrderDoc.TotalCurrencyId).First().Name
                };
                selectedRecord = item;
                SetRecord(true, true);
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            App.TiltOrderDoc = new IncomingOrderList(); App.TiltDocItems = new List<DocumentItemList>(); App.tiltTargets = TiltTargets.None.ToString();
            MainWindow.ProgressRing = Visibility.Hidden;
        }

        private void HideTiltButtons() {
            if (selectedRecord.Id == 0)
            {
                btn_createCreditNote.Visibility = Visibility.Hidden;
                btn_createReceipt.Visibility = Visibility.Hidden;
                btn_showCreditNote.Visibility = Visibility.Hidden;
                btn_showReceipt.Visibility = Visibility.Hidden;
            }
            else
            {
                btn_createCreditNote.Visibility = Visibility.Hidden;
                btn_createReceipt.Visibility = Visibility.Hidden;
                btn_showCreditNote.Visibility = Visibility.Hidden;
                btn_showReceipt.Visibility = Visibility.Hidden;
                if (!string.IsNullOrWhiteSpace(selectedRecord.CreditNoteId.ToString())) { btn_showCreditNote.Visibility = Visibility.Visible; } else { btn_createCreditNote.Visibility = Visibility.Visible; }
                if (!string.IsNullOrWhiteSpace(selectedRecord.ReceiptId.ToString())) { btn_showReceipt.Visibility = Visibility.Visible; } else { btn_createReceipt.Visibility = Visibility.Visible; }
            }
        }

        private async void CreateReceipt_Click(object sender, RoutedEventArgs e) {
            App.TiltInvoiceDoc = selectedRecord; App.TiltDocItems = DocumentItemList; App.tiltTargets = TiltTargets.InvoiceToReceipt.ToString(); await MainWindow.TiltOpenForm(Resources["receiptList"].ToString()); SetRecord(false);
        }

        private async void ShowReceipt_Click(object sender, RoutedEventArgs e) {
            ReceiptList receiptList = await ApiCommunication.GetApiRequest<ReceiptList>(ApiUrls.ReceiptList, selectedRecord.ReceiptId.ToString(), App.UserData.Authentification.Token);
            ExtendedReceiptList extendedReceiptList = new ExtendedReceiptList()
            {
                Id = receiptList.Id,
                DocumentNumber = receiptList.DocumentNumber,
                Supplier = receiptList.Supplier,
                Customer = receiptList.Customer,
                IssueDate = receiptList.IssueDate,
                InvoiceNumber = receiptList.InvoiceNumber,
                Storned = receiptList.Storned,
                TotalCurrencyId = receiptList.TotalCurrencyId,
                Description = receiptList.Description,
                TotalPriceWithVat = receiptList.TotalPriceWithVat,
                UserId = receiptList.UserId,
                TimeStamp = receiptList.TimeStamp,
                TotalCurrency = CurrencyList.Where(a => a.Id == receiptList.TotalCurrencyId).First().Name
            };

            App.TiltReceiptDoc = extendedReceiptList;
            App.tiltTargets = TiltTargets.ShowReceipt.ToString(); await MainWindow.TiltOpenForm(Resources["receiptList"].ToString()); SetRecord(false);
        }

        private async void CreateCreditNote_Click(object sender, RoutedEventArgs e) {
            App.TiltInvoiceDoc = selectedRecord; App.TiltDocItems = DocumentItemList; App.tiltTargets = TiltTargets.InvoiceToCredit.ToString(); await MainWindow.TiltOpenForm(Resources["creditNoteList"].ToString()); SetRecord(false);
        }

        private async void ShowCreditNote_Click(object sender, RoutedEventArgs e) {
            CreditNoteList creditNoteList = await ApiCommunication.GetApiRequest<CreditNoteList>(ApiUrls.CreditNoteList, selectedRecord.CreditNoteId.ToString(), App.UserData.Authentification.Token);
            ExtendedCreditNoteList extendedCreditNoteList = new ExtendedCreditNoteList()
            {
                Id = creditNoteList.Id,
                DocumentNumber = creditNoteList.DocumentNumber,
                Supplier = creditNoteList.Supplier,
                Customer = creditNoteList.Customer,
                IssueDate = creditNoteList.IssueDate,
                InvoiceNumber = creditNoteList.InvoiceNumber,
                Storned = creditNoteList.Storned,
                TotalCurrencyId = creditNoteList.TotalCurrencyId,
                Description = creditNoteList.Description,
                TotalPriceWithVat = creditNoteList.TotalPriceWithVat,
                UserId = creditNoteList.UserId,
                TimeStamp = creditNoteList.TimeStamp,
                TotalCurrency = CurrencyList.Where(a => a.Id == creditNoteList.TotalCurrencyId).First().Name
            };

            App.TiltCreditDoc = extendedCreditNoteList;
            App.tiltTargets = TiltTargets.ShowCredit.ToString(); await MainWindow.TiltOpenForm(Resources["creditNoteList"].ToString()); SetRecord(false);
        }
    }
}