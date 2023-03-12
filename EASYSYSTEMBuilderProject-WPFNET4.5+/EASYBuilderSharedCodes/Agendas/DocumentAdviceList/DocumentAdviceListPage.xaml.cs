using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using System.Net;

namespace GlobalNET.Pages
{
    public partial class DocumentAdviceListPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ExtendedDocumentAdviceList selectedRecord = new ExtendedDocumentAdviceList();

        List<BranchList> BranchList = new List<BranchList>();
        public DocumentAdviceListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            ObservableCollection<UpdateVariant> documentType = new ObservableCollection<UpdateVariant>() {
                                                        new UpdateVariant() { Name = Resources["offer"].ToString(), Value = "offer" },
                                                        new UpdateVariant() { Name = Resources["incomingOrder"].ToString(), Value = "incomingOrder" },
                                                        new UpdateVariant() { Name = Resources["outgoingOrder"].ToString(), Value = "outgoingOrder" },
                                                        new UpdateVariant() { Name = Resources["incomingInvoice"].ToString(), Value = "incomingInvoice" },
                                                        new UpdateVariant() { Name = Resources["outgoingInvoice"].ToString(), Value = "outgoingInvoice" },
                                                        new UpdateVariant() { Name = Resources["creditNote"].ToString(), Value = "creditNote" },
                                                        new UpdateVariant() { Name = Resources["receipt"].ToString(), Value = "receipt" }
                                                  };

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_branch.Content = Resources["branch"].ToString();
            lbl_documentType.Content = Resources["documentType"].ToString();
            lbl_prefix.Content = Resources["prefix"].ToString();
            lbl_number.Content = Resources["number"].ToString();
            lb_startDate.Content = Resources["startDate"].ToString();
            dp_startDate.Value = DateTime.Now;
            lb_endDate.Content = Resources["endDate"].ToString();
            dp_endDate.Value = DateTime.Now;
            lbl_active.Content = Resources["active"].ToString();

            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            cb_documentType.ItemsSource = documentType;

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            List<DocumentAdviceList> documentAdviceList = new List<DocumentAdviceList>();
            List<ExtendedDocumentAdviceList> extendedDocumentAdviceList = new List<ExtendedDocumentAdviceList>();
            try
            {
                cb_branch.ItemsSource = BranchList = await ApiCommunication.GetApiRequest<List<BranchList>>(ApiUrls.GlobalNETBranchList, null, App.UserData.Authentification.Token);
                documentAdviceList = await ApiCommunication.GetApiRequest<List<DocumentAdviceList>>(ApiUrls.GlobalNETDocumentAdviceList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);

                documentAdviceList.ForEach(record =>
                {
                    ExtendedDocumentAdviceList item = new ExtendedDocumentAdviceList()
                    {
                        Id = record.Id,
                        BranchId = record.BranchId,
                        DocumentType = record.DocumentType,
                        Prefix = record.Prefix,
                        Number = record.Number,
                        StartDate = record.StartDate,
                        EndDate = record.EndDate,
                        UserId = record.UserId,
                        Active = record.Active,
                        TimeStamp = record.TimeStamp,
                        Branch = BranchList.First(a => a.Id == record.BranchId).CompanyName
                    };
                    extendedDocumentAdviceList.Add(item);
                });
                DgListView.ItemsSource = extendedDocumentAdviceList;
                DgListView.Items.Refresh();
            } catch { }

            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "DocumentType") e.Header = Resources["documentType"].ToString();
                else if (headername == "Branch") { e.Header = Resources["branch"].ToString(); e.DisplayIndex = 1; }
                else if (headername == "Prefix") e.Header = Resources["prefix"].ToString();
                else if (headername == "Number") e.Header = Resources["number"].ToString();
                else if (headername == "StartDate") { e.Header = Resources["startDate"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy"; e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "EndDate") { e.Header = Resources["endDate"].ToString(); (e as DataGridTextColumn).Binding.StringFormat = "dd.MM.yyyy"; e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "BranchId") e.Visibility = Visibility.Hidden;
            });
        }

        //change filter fields
        public void Filter(string filter)
        {
            try
            {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) => {
                    ExtendedDocumentAdviceList report = e as ExtendedDocumentAdviceList;
                    return report.DocumentType.ToLower().Contains(filter.ToLower())
                    || report.Branch.ToLower().Contains(filter.ToLower())
                    || report.Prefix.ToLower().Contains(filter.ToLower())
                    || report.Number.ToLower().Contains(filter.ToLower());
                };
            }
            catch { }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void NewRecord()
        {
            selectedRecord = new ExtendedDocumentAdviceList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy)
        {
            selectedRecord = (ExtendedDocumentAdviceList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord()
        {
            selectedRecord = (ExtendedDocumentAdviceList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETDocumentAdviceList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (ExtendedDocumentAdviceList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (ExtendedDocumentAdviceList)DgListView.SelectedItem;
            } else { selectedRecord = new ExtendedDocumentAdviceList(); }
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
                selectedRecord.BranchId = ((BranchList)cb_branch.SelectedItem).Id;
                selectedRecord.DocumentType = ((UpdateVariant)cb_documentType.SelectedItem).Value;
                selectedRecord.Prefix = txt_prefix.Text;
                selectedRecord.Number = txt_number.Text;
                selectedRecord.StartDate = (DateTime)dp_startDate.Value;
                selectedRecord.EndDate = (DateTime)dp_endDate.Value;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETDocumentAdviceList, httpContent, null, App.UserData.Authentification.Token);
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETDocumentAdviceList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new ExtendedDocumentAdviceList();
                    await LoadDataList();
                    SetRecord(false);
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ExtendedDocumentAdviceList)DgListView.SelectedItem : new ExtendedDocumentAdviceList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false)
        {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            cb_branch.Text = selectedRecord.Branch;
            cb_documentType.Text = (string.IsNullOrWhiteSpace(selectedRecord.DocumentType)) ? null : Resources[selectedRecord.DocumentType].ToString();
            txt_prefix.Text = selectedRecord.Prefix;
            txt_number.Text = selectedRecord.Number;
            dp_startDate.Value = (selectedRecord.Id == 0) ? (DateTime)dp_startDate.Value : selectedRecord.StartDate;
            dp_endDate.Value = (selectedRecord.Id == 0) ? (DateTime)dp_endDate.Value : selectedRecord.EndDate;
            chb_active.IsChecked = selectedRecord.Active;

            if (showForm)
            {
                MainWindow.DataGridSelected = MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true; 
            } else {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

    }
}