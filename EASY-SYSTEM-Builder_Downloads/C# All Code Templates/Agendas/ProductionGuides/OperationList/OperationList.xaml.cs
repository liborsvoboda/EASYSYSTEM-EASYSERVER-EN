using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GlobalNET.Pages {

    public partial class OperationListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static OperationList selectedRecord = new OperationList();

        private List<WorkPlaceList> WorkPlaceList = new List<WorkPlaceList>();
        private List<PartNumberList> PartNumberList = new List<PartNumberList>();
        private List<OperationList> OperationList = new List<OperationList>();
        private string LastWorkPlaceCorrectSearch = null;
        private string LastPartNumberCorrectSearch = null;
        private bool messageShown = false;

        public OperationListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_workPlace.Content = Resources["workPlace"].ToString();
            lbl_partNumber.Content = Resources["partNumber"].ToString();
            lbl_operationNumber.Content = Resources["operationNumber"].ToString();
            lbl_note.Content = Resources["description"].ToString();
            lbl_pcsPerHour.Content = Resources["pcsPerHour"].ToString();
            txt_workPlace.Text = LastWorkPlaceCorrectSearch;

            lbl_kcPerKs.Content = Resources["kcPerKs"].ToString();
            txt_kcPerKs.StringFormat = "00.0000";

            btn_saveNext.Content = Resources["btn_saveNext"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            List<PartList> tempPartList = new List<PartList>();
            try { if (MainWindow.serviceRunning) tempPartList = await ApiCommunication.GetApiRequest<List<PartList>>(ApiUrls.PartList, null, App.UserData.Authentification.Token); }
            catch { }

            WorkPlaceList.Clear(); PartNumberList.Clear();
            double? tempPrewWorkPlaceValue = null;
            tempPartList.ForEach(record =>
            {
                if (record.WorkPlace != tempPrewWorkPlaceValue) { WorkPlaceList.Add(new WorkPlaceList() { WorkPlace = record.WorkPlace }); tempPrewWorkPlaceValue = record.WorkPlace; }
                PartNumberList.Add(new PartNumberList() { WorkPlace = record.WorkPlace, PartNumber = record.Number, Name = record.Name });
            });

            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = OperationList = await ApiCommunication.GetApiRequest<List<OperationList>>(ApiUrls.OperationList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token); }
            catch { }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "WorkPlace") e.Header = Resources["workPlace"].ToString();
                else if (headername == "PartNumber") e.Header = Resources["partNumber"].ToString();
                else if (headername == "OperationNumber") { e.Header = Resources["operationNumber"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Note") e.Header = Resources["description"].ToString();
                else if (headername == "PcsPerHour") { e.Header = Resources["pcsPerHour"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "KcPerKs") { e.Header = Resources["kcPerKs"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }

                //Hide System Columns
                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
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
                    OperationList data = e as OperationList;
                    return data.WorkPlace.ToString().ToLower().Contains(filter.ToLower())
                    || data.PartNumber.ToString().ToLower().Contains(filter.ToLower())
                    || data.OperationNumber.ToString().ToLower().Contains(filter.ToLower())
                    || data.Note.ToLower().Contains(filter.ToLower())
                    || data.PcsPerHour.ToString().ToLower().Contains(filter.ToLower())
                    || data.KcPerKs.ToString().ToLower().Contains(filter.ToLower())
                    ;
                };
            }
            catch { }
        }

        public void NewRecord() {
            selectedRecord = new OperationList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (OperationList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (OperationList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.OperationList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
            SetRecord(false);
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            selectedRecord = (OperationList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (OperationList)DgListView.SelectedItem;
            }
            else { selectedRecord = new OperationList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.WorkPlace = int.Parse(txt_workPlace.Text);
                selectedRecord.PartNumber = tb_partNumber.Text;
                selectedRecord.OperationNumber = (int)txt_operationNumber.Value;
                selectedRecord.Note = tb_note.Text;
                selectedRecord.PcsPerHour = (int)txt_pcsPerHour.Value;
                selectedRecord.KcPerKs = (decimal)txt_kcPerKs.Value;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.OperationList, httpContent, null, App.UserData.Authentification.Token); ;
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.OperationList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new OperationList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private async void BtnSaveNext_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.WorkPlace = int.Parse(txt_workPlace.Text);
                selectedRecord.PartNumber = tb_partNumber.Text;
                selectedRecord.OperationNumber = (int)txt_operationNumber.Value;
                selectedRecord.Note = tb_note.Text;
                selectedRecord.PcsPerHour = (int)txt_pcsPerHour.Value;
                selectedRecord.KcPerKs = (decimal)txt_kcPerKs.Value;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.OperationList, httpContent, null, App.UserData.Authentification.Token); ; ;
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.OperationList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new OperationList();
                    await LoadDataList();
                    SetRecord(true);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (OperationList)DgListView.SelectedItem : new OperationList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false) {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            txt_workPlace.Text = selectedRecord.WorkPlace.ToString();
            tb_partNumber.Text = selectedRecord.PartNumber;
            txt_operationNumber.Value = selectedRecord.OperationNumber;
            lbl_partName.Content = (selectedRecord.Id == 0) ? null : PartNumberList.Where(a => a.WorkPlace == selectedRecord.WorkPlace && a.PartNumber.ToLower() == selectedRecord.PartNumber.ToLower()).ToList().FirstOrDefault().Name;
            tb_note.Text = selectedRecord.Note;
            txt_pcsPerHour.Value = selectedRecord.PcsPerHour;
            txt_kcPerKs.Value = (double)selectedRecord.KcPerKs;

            if (showForm)
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
                if (selectedRecord.Id == 0) { txt_workPlace.Text = null; txt_operationNumber.Value = null; txt_workPlace.Focus(); } else { txt_operationNumber.Focus(); }
            }
            else
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        private void Tb_WorkPlace_GotFocus(object sender, RoutedEventArgs e) => UpdateWorkPlaceSearchResults();

        private async void UpdateWorkPlaceSearchResults() {
            if (dataViewSupport.FormShown)
            {
                LastPartNumberCorrectSearch = null; lv_partNumberSearchResults.Visibility = Visibility.Hidden;
                try
                {
                    List<WorkPlaceList> tempPartList = WorkPlaceList.Where(a => a.WorkPlace.ToString().StartsWith(!string.IsNullOrWhiteSpace(txt_workPlace.Text) ? txt_workPlace.Text : "")).ToList();

                    if (tempPartList.Count == 0 && !messageShown && txt_workPlace.Text != null)
                    {
                        messageShown = true;
                        var result = await MainWindow.ShowMessage(true, Resources["workPlaceNotExist"].ToString());
                        if (result == MessageDialogResult.Affirmative) { messageShown = false; }
                        txt_workPlace.Text = LastWorkPlaceCorrectSearch; txt_workPlace.Focus(); txt_workPlace.SelectAll();
                    }
                    else if (tempPartList.Count > 0)
                    {
                        lv_workPlaceSearchResults.ItemsSource = tempPartList;
                        if (lv_workPlaceSearchResults.Items.Count == 1)
                        {
                            txt_workPlace.Text = ((WorkPlaceList)lv_workPlaceSearchResults.Items[0]).WorkPlace.ToString();
                            lv_workPlaceSearchResults.Visibility = Visibility.Hidden; tb_partNumber.Focus();
                            tb_partNumber.CaretIndex = (!string.IsNullOrWhiteSpace(tb_partNumber.Text)) ? tb_partNumber.Text.Length : 0;
                        }
                        else { lv_workPlaceSearchResults.Visibility = Visibility.Visible; }
                        LastWorkPlaceCorrectSearch = txt_workPlace.Text;
                    }
                }
                catch { }
            }
        }

        private void WorkPlace_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Up && lv_workPlaceSearchResults.Visibility == Visibility.Visible) { lv_workPlaceSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_workPlaceSearchResults.Visibility == Visibility.Visible) { lv_workPlaceSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_workPlaceSearchResults.Visibility == Visibility.Visible) { txt_workPlace.Focus(); }
        }

        private void SelectWorkPlace_Enter(object sender, KeyEventArgs e) {
            if ((e.Key == Key.Enter) && lv_workPlaceSearchResults.Visibility == Visibility.Visible)
            {
                txt_workPlace.Text = lv_workPlaceSearchResults.SelectedIndex == -1 ? null : ((WorkPlaceList)lv_workPlaceSearchResults.SelectedItem).WorkPlace.ToString();
                lv_workPlaceSearchResults.Visibility = Visibility.Hidden; tb_partNumber.Focus();
                tb_partNumber.CaretIndex = (!string.IsNullOrWhiteSpace(tb_partNumber.Text)) ? tb_partNumber.Text.Length : 0;
            }
        }

        private void MouseSelectWorkPlace_Click(object sender, MouseButtonEventArgs e) {
            txt_workPlace.Text = lv_workPlaceSearchResults.SelectedIndex == -1 ? null : ((WorkPlaceList)lv_workPlaceSearchResults.SelectedItem).WorkPlace.ToString();
            lv_workPlaceSearchResults.Visibility = Visibility.Hidden; tb_partNumber.Focus();
            tb_partNumber.CaretIndex = (!string.IsNullOrWhiteSpace(tb_partNumber.Text)) ? tb_partNumber.Text.Length : 0;
        }

        private void Tb_PartNumber_GotFocus(object sender, RoutedEventArgs e) => UpdatePartNumberSearchResults();

        private void PartNumber_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Up && lv_partNumberSearchResults.Visibility == Visibility.Visible) { lv_partNumberSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_partNumberSearchResults.Visibility == Visibility.Visible) { lv_partNumberSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_partNumberSearchResults.Visibility == Visibility.Visible) { txt_workPlace.Focus(); }
        }

        private async void UpdatePartNumberSearchResults() {
            if (dataViewSupport.FormShown && !string.IsNullOrEmpty(txt_workPlace.Text))
            {
                try
                {
                    List<PartNumberList> tempPartNumberList = PartNumberList.Where(a => a.WorkPlace == int.Parse(txt_workPlace.Text) && a.PartNumber.ToString().ToLower().Contains((!string.IsNullOrWhiteSpace(tb_partNumber.Text) ? tb_partNumber.Text.ToLower() : ""))).ToList();

                    if (!string.IsNullOrWhiteSpace(tb_partNumber.Text) && !messageShown && tempPartNumberList.Count == 0 && !string.IsNullOrWhiteSpace(LastPartNumberCorrectSearch))
                    {
                        messageShown = true;
                        var result = await MainWindow.ShowMessage(true, Resources["partNumberNotExist"].ToString());
                        if (result == MessageDialogResult.Affirmative) { messageShown = false; }
                        tb_partNumber.Text = LastPartNumberCorrectSearch; tb_partNumber.CaretIndex = tb_partNumber.Text.Length;
                    }
                    else if (!string.IsNullOrWhiteSpace(tb_partNumber.Text) && tempPartNumberList.Count == 0) { tb_partNumber.Text = null; }
                    else if (tempPartNumberList.Count > 0)
                    {
                        lv_partNumberSearchResults.ItemsSource = tempPartNumberList;
                        if (lv_partNumberSearchResults.Items.Count == 1)
                        {
                            tb_partNumber.Text = ((PartNumberList)lv_partNumberSearchResults.Items[0]).PartNumber;
                            lbl_partName.Content = ((PartNumberList)lv_partNumberSearchResults.Items[0]).Name;
                            //txt_operationNumber.Value = OperationList.Where(a => a.WorkPlace == txt_workPlace.Value).Max(x => x.OperationNumber) + 10;

                            lv_partNumberSearchResults.Visibility = Visibility.Hidden; txt_operationNumber.Focus(); //txt_operationNumber.SelectAll();
                        }
                        else { lv_partNumberSearchResults.Visibility = Visibility.Visible; }
                        LastPartNumberCorrectSearch = tb_partNumber.Text;
                    }
                    else { lbl_partName.Content = null; }
                }
                catch { }
            }
        }

        private void SelectPartNumber_Enter(object sender, KeyEventArgs e) {
            if ((e.Key == Key.Enter) && lv_partNumberSearchResults.Visibility == Visibility.Visible)
            {
                tb_partNumber.Text = lv_partNumberSearchResults.SelectedIndex == -1 ? null : ((PartNumberList)lv_partNumberSearchResults.SelectedItem).PartNumber;
                lbl_partName.Content = lv_partNumberSearchResults.SelectedIndex == -1 ? null : ((PartNumberList)lv_partNumberSearchResults.SelectedItem).Name;
                //txt_operationNumber.Value = OperationList.Where(a => a.WorkPlace == txt_workPlace.Value).Max(x => x.OperationNumber) + 10;

                lv_partNumberSearchResults.Visibility = Visibility.Hidden; txt_operationNumber.Focus(); txt_operationNumber.SelectAll();
            }
        }

        private void MouseSelectPartNumber_Click(object sender, MouseButtonEventArgs e) {
            tb_partNumber.Text = lv_partNumberSearchResults.SelectedIndex == -1 ? null : ((PartNumberList)lv_partNumberSearchResults.SelectedItem).PartNumber;
            lv_partNumberSearchResults.Visibility = Visibility.Hidden; txt_operationNumber.Focus();
            tb_partNumber.CaretIndex = (!string.IsNullOrWhiteSpace(tb_partNumber.Text)) ? tb_partNumber.Text.Length : 0;
        }

        private void KcPerKs_SelectAll(object sender, RoutedEventArgs e) => txt_kcPerKs.SelectAll();

        private void PcsPerHour_SelectAll(object sender, RoutedEventArgs e) => txt_pcsPerHour.SelectAll();
    }
}