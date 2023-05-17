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

    public partial class WorkListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ExtendedWorkList selectedRecord = new ExtendedWorkList();

        private List<PersonalList> PersonalList = new List<PersonalList>();
        private List<WorkPlaceList> WorkPlaceList = new List<WorkPlaceList>();
        private List<OperationList> OperationList = new List<OperationList>();
        private List<ExtendedWorkList> ExtendedWorkList = new List<ExtendedWorkList>();

        private string LastPersonalNumberCorrectSearch, LastWorkPlaceCorrectSearch = null;
        private decimal? Amount, WorkPower = null;
        private string StdPerHour = null;
        private bool messageShown = false;

        public WorkListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lb_date.Content = Resources["date"].ToString();
            dp_date.Value = DateTime.Now;
            lbl_personalNumber.Content = Resources["personalNumber"].ToString();
            lbl_workPlace.Content = Resources["workPlace"].ToString();
            lbl_operationNumber.Content = Resources["operationNumber"].ToString();

            lb_workTime.Content = Resources["workTime"].ToString();
            lbl_pcs.Content = Resources["pcs"].ToString();

            btn_saveNext.Content = Resources["btn_saveNext"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            List<PersonList> tempPersonList = new List<PersonList>();
            try
            {
                if (MainWindow.serviceRunning) tempPersonList = await ApiCommunication.GetApiRequest<List<PersonList>>(ApiUrls.PersonList, null, App.UserData.Authentification.Token);
                PersonalList.Clear();
                tempPersonList.ForEach(record =>
                {
                    PersonalList.Add(new PersonalList() { PersonalNumber = record.PersonalNumber, FullName = record.SurName + " " + record.Name, FullInfo = record.PersonalNumber + " / " + record.SurName + " " + record.Name });
                });

                OperationList = await ApiCommunication.GetApiRequest<List<OperationList>>(ApiUrls.OperationList, null, App.UserData.Authentification.Token);
                WorkPlaceList.Clear();
                string tempPrewWorkPlaceValue = null;
                OperationList.ForEach(record =>
                {
                    if (record.WorkPlace.ToString() + " | " + record.PartNumber + " | " + record.OperationNumber != tempPrewWorkPlaceValue)
                    {
                        WorkPlaceList.Add(new WorkPlaceList() { WorkPlace = record.WorkPlace, WorkPlacePartNumberOperation = record.WorkPlace.ToString() + " | " + record.PartNumber + " | " + record.OperationNumber }); tempPrewWorkPlaceValue = record.WorkPlace.ToString() + " | " + record.PartNumber + " | " + record.OperationNumber;
                    }
                });

                List<WorkList> tempWorkList = new List<WorkList>();
                tempWorkList = await ApiCommunication.GetApiRequest<List<WorkList>>(ApiUrls.WorkList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);

                ExtendedWorkList.Clear();
                tempWorkList.ForEach(record =>
                {
                    ExtendedWorkList.Add(new ExtendedWorkList()
                    {
                        Id = record.Id,
                        Date = record.Date,
                        PersonalNumber = record.PersonalNumber,
                        WorkPlace = record.WorkPlace,
                        OperationNumber = record.OperationNumber,
                        WorkTime = record.WorkTime,
                        Pcs = record.Pcs,
                        Amount = record.Amount,
                        WorkPower = record.WorkPower,
                        FullName = tempPersonList.Where(a => a.PersonalNumber == record.PersonalNumber).Select(b => (b.SurName + " " + b.Name).ToString()).FirstOrDefault(),
                        Timestamp = record.Timestamp
                    });
                });
                DgListView.ItemsSource = ExtendedWorkList;
                DgListView.Items.Refresh();
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, ex.StackTrace + Environment.NewLine + ex.Message); }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "WorkPlace") { e.Header = Resources["workPlace"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "PersonalNumber") e.Header = Resources["personalNumber"].ToString();
                else if (headername == "OperationNumber") { e.Header = Resources["operationNumber"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Date") e.Header = Resources["date"].ToString();
                else if (headername == "WorkTime") { e.Header = Resources["workTime"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Pcs") { e.Header = Resources["pcs"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Amount") { e.Header = Resources["amount"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "FullName") { e.DisplayIndex = 3; e.Header = Resources["fullName"].ToString(); }
                else if (headername == "WorkPower") { e.DisplayIndex = 9; e.Header = Resources["workPower"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
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
                    ExtendedWorkList data = e as ExtendedWorkList;
                    return data.Id.ToString().ToLower().Contains(filter.ToLower())
                    || data.WorkPlace.ToString().ToLower().Contains(filter.ToLower())
                    || data.Date.ToString().ToLower().Contains(filter.ToLower())
                    || data.PersonalNumber.ToString().ToLower().Contains(filter.ToLower())
                    || data.FullName.ToString().ToLower().Contains(filter.ToLower())
                    ;
                };
            }
            catch { }
        }

        public void NewRecord() {
            selectedRecord = new ExtendedWorkList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (ExtendedWorkList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (ExtendedWorkList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.WorkList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
            SetRecord(false);
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            selectedRecord = (ExtendedWorkList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (ExtendedWorkList)DgListView.SelectedItem;
            }
            else { selectedRecord = new ExtendedWorkList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.Date = ((DateTime)dp_date.Value).Date;
                selectedRecord.PersonalNumber = int.Parse(txt_personalNumber.Text);
                selectedRecord.WorkPlace = int.Parse(txt_workPlace.Text);
                selectedRecord.OperationNumber = (int)txt_operationNumber.Value;
                selectedRecord.WorkTime = (TimeSpan)dp_workTime.Value;
                selectedRecord.Pcs = (int)txt_pcs.Value;
                selectedRecord.Amount = (decimal)Amount;
                selectedRecord.WorkPower = (decimal)WorkPower;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.WorkList, httpContent, null, App.UserData.Authentification.Token); ;
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.WorkList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, ex.StackTrace + Environment.NewLine + ex.Message); }
        }

        private async void BtnSaveNext_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.Date = ((DateTime)dp_date.Value).Date;
                selectedRecord.PersonalNumber = int.Parse(txt_personalNumber.Text);
                selectedRecord.WorkPlace = int.Parse(txt_workPlace.Text);
                selectedRecord.OperationNumber = (int)txt_operationNumber.Value;
                selectedRecord.WorkTime = (TimeSpan)dp_workTime.Value;
                selectedRecord.Pcs = (int)txt_pcs.Value;
                selectedRecord.Amount = (decimal)Amount;
                selectedRecord.WorkPower = (decimal)WorkPower;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.WorkList, httpContent, null, App.UserData.Authentification.Token); ; ;
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.WorkList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    int previousPerson = selectedRecord.PersonalNumber;
                    selectedRecord = new ExtendedWorkList();
                    await LoadDataList();
                    SetRecord(true);
                    selectedRecord.PersonalNumber = previousPerson;
                    txt_personalNumber.Text = selectedRecord.PersonalNumber.ToString();
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, ex.StackTrace + Environment.NewLine + ex.Message); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ExtendedWorkList)DgListView.SelectedItem : new ExtendedWorkList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false) {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            dp_date.Value = (selectedRecord.Id == 0) ? DateTime.Now : selectedRecord.Date;
            txt_personalNumber.Text = (selectedRecord.Id == 0) ? null : selectedRecord.PersonalNumber.ToString();
            txt_workPlace.Text = (selectedRecord.Id == 0) ? null : selectedRecord.WorkPlace.ToString();
            txt_operationNumber.Value = (selectedRecord.Id == 0) ? (double?)null : selectedRecord.OperationNumber;
            dp_workTime.Value = (selectedRecord.Id == 0) ? TimeSpan.FromHours(1) : selectedRecord.WorkTime;
            txt_pcs.Value = (selectedRecord.Id == 0) ? (double?)null : selectedRecord.Pcs;
            lbl_amount.Content = (selectedRecord.Id == 0) ? (decimal?)null : selectedRecord.Amount;
            lbl_workPower.Content = (selectedRecord.Id == 0) ? (decimal?)null : selectedRecord.WorkPower;
            lbl_fullName.Content = (selectedRecord.Id == 0) ? null : selectedRecord.FullName;

            if (showForm)
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
                if (selectedRecord.Id == 0) { dp_date.Focus(); } else { dp_workTime.Focus(); }
            }
            else
            {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        //Whisper Selections
        private void Tb_PersonalNumber_GotFocus(object sender, RoutedEventArgs e) => UpdatePersonalNumberSearchResults();

        private void SelectPersonalNumber_Enter(object sender, KeyEventArgs e) {
            if ((e.Key == Key.Enter) && lv_personalNumberSearchResults.Visibility == Visibility.Visible)
            {
                txt_personalNumber.Text = lv_personalNumberSearchResults.SelectedIndex == -1 ? null : ((PersonalList)lv_personalNumberSearchResults.SelectedItem).PersonalNumber.ToString();
                lbl_fullName.Content = lv_personalNumberSearchResults.SelectedIndex == -1 ? null : ((PersonalList)lv_personalNumberSearchResults.SelectedItem).FullName;
                LastPersonalNumberCorrectSearch = null;
                lv_personalNumberSearchResults.Visibility = Visibility.Hidden; txt_workPlace.Focus(); txt_workPlace.SelectAll();
            }
        }

        private void MousePersonalNumber_Click(object sender, MouseButtonEventArgs e) {
            txt_personalNumber.Text = lv_personalNumberSearchResults.SelectedIndex == -1 ? null : ((PersonalList)lv_personalNumberSearchResults.SelectedItem).PersonalNumber.ToString();
            lbl_fullName.Content = lv_personalNumberSearchResults.SelectedIndex == -1 ? null : ((PersonalList)lv_personalNumberSearchResults.SelectedItem).FullName;
            LastPersonalNumberCorrectSearch = null;
            lv_personalNumberSearchResults.Visibility = Visibility.Hidden; txt_workPlace.Focus(); txt_workPlace.SelectAll();
        }

        private void PersonalNumber_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Up && lv_personalNumberSearchResults.Visibility == Visibility.Visible) { lv_personalNumberSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_personalNumberSearchResults.Visibility == Visibility.Visible) { lv_personalNumberSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_personalNumberSearchResults.Visibility == Visibility.Visible) { txt_personalNumber.Focus(); }
        }

        private async void UpdatePersonalNumberSearchResults() {
            LastWorkPlaceCorrectSearch = null; lv_workPlaceSearchResults.Visibility = Visibility.Hidden;
            if (dataViewSupport.FormShown)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(txt_personalNumber.Text))
                    {
                        List<PersonalList> tempPersonalList = PersonalList.Where(a => a.PersonalNumber.ToString().StartsWith(txt_personalNumber.Text)).ToList();
                        if (tempPersonalList.Count == 0 && !messageShown && txt_personalNumber.Text != LastPersonalNumberCorrectSearch)
                        {
                            messageShown = true;
                            var result = await MainWindow.ShowMessage(true, Resources["workPlaceNotExist"].ToString());
                            if (result == MessageDialogResult.Affirmative) { messageShown = false; }
                            txt_personalNumber.Text = LastPersonalNumberCorrectSearch; txt_personalNumber.Focus(); txt_personalNumber.SelectAll();
                        }
                        if (tempPersonalList.Count > 0)
                        {
                            lv_personalNumberSearchResults.ItemsSource = tempPersonalList;
                            if (lv_personalNumberSearchResults.Items.Count == 1)
                            {
                                txt_personalNumber.Text = ((PersonalList)lv_personalNumberSearchResults.Items[0]).PersonalNumber.ToString();
                                lbl_fullName.Content = ((PersonalList)lv_personalNumberSearchResults.Items[0]).FullName;
                                LastPersonalNumberCorrectSearch = null;
                                lv_personalNumberSearchResults.Visibility = Visibility.Hidden; txt_workPlace.Focus(); txt_workPlace.SelectAll();
                            }
                            else { lv_personalNumberSearchResults.Visibility = Visibility.Visible; }
                            LastPersonalNumberCorrectSearch = txt_personalNumber.Text;
                        }
                    }
                }
                catch { }
            }
        }

        private void Tb_WorkPlace_GotFocus(object sender, RoutedEventArgs e) => UpdateWorkPlaceSearchResults();

        private void WorkPlace_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Up && lv_workPlaceSearchResults.Visibility == Visibility.Visible) { lv_workPlaceSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_workPlaceSearchResults.Visibility == Visibility.Visible) { lv_workPlaceSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_workPlaceSearchResults.Visibility == Visibility.Visible) { txt_workPlace.Focus(); }
        }

        private void SelectWorkPlace_Enter(object sender, KeyEventArgs e) {
            if ((e.Key == Key.Enter) && lv_workPlaceSearchResults.Visibility == Visibility.Visible)
            {
                txt_workPlace.Text = lv_workPlaceSearchResults.SelectedIndex == -1 ? null : ((WorkPlaceList)lv_workPlaceSearchResults.SelectedItem).WorkPlace.ToString();
                txt_operationNumber.Value = lv_workPlaceSearchResults.SelectedIndex == -1 ? (double?)null : double.Parse(((WorkPlaceList)lv_workPlaceSearchResults.SelectedItem).WorkPlacePartNumberOperation.Split('|')[2].Replace(" ", ""));
                lv_workPlaceSearchResults.Visibility = Visibility.Hidden; dp_workTime.Focus();
            }
        }

        private void MouseWorkPlace_Click(object sender, MouseButtonEventArgs e) {
            txt_workPlace.Text = lv_workPlaceSearchResults.SelectedIndex == -1 ? null : ((WorkPlaceList)lv_workPlaceSearchResults.SelectedItem).WorkPlace.ToString();
            txt_operationNumber.Value = lv_workPlaceSearchResults.SelectedIndex == -1 ? (double?)null : double.Parse(((WorkPlaceList)lv_workPlaceSearchResults.SelectedItem).WorkPlacePartNumberOperation.Split('|')[2].Replace(" ", ""));
            lv_workPlaceSearchResults.Visibility = Visibility.Hidden; dp_workTime.Focus();
        }

        private async void UpdateWorkPlaceSearchResults() {
            if (dataViewSupport.FormShown)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(txt_workPlace.Text) && txt_workPlace.Text != null)
                    {
                        List<WorkPlaceList> tempPartList = WorkPlaceList.Where(a => a.WorkPlace.ToString().StartsWith(txt_workPlace.Text)).ToList();

                        if (tempPartList.Count == 0 && !messageShown && txt_workPlace.Text != LastWorkPlaceCorrectSearch)
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
                                txt_operationNumber.Value = double.Parse(((WorkPlaceList)lv_workPlaceSearchResults.Items[0]).WorkPlacePartNumberOperation.Split('|')[2].Replace(" ", ""));
                                lv_workPlaceSearchResults.Visibility = Visibility.Hidden; dp_workTime.Focus();// dp_workTime.SelectAll();
                            }
                            else { lv_workPlaceSearchResults.Visibility = Visibility.Visible; }
                            LastWorkPlaceCorrectSearch = txt_workPlace.Text;
                        }
                    }
                    else { txt_operationNumber.Value = null; }
                }
                catch { }
            }
        }

        private void Pcs_SelectAll(object sender, RoutedEventArgs e) => txt_pcs.SelectAll();

        private void txt_Calculation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e) => Recalculate_Result();

        private void dp_Calculation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e) => Recalculate_Result();

        private async void Recalculate_Result() {
            try
            {
                if (lbl_amount != null)
                {
                    StdPerHour = Resources["notSelected"].ToString(); Amount = 0; WorkPower = 0;
                    List<OperationList> tempNormPrice = new List<OperationList>();

                    //Standard Per Hour
                    if (txt_workPlace.Text != null && txt_operationNumber.Value != null)
                    {
                        tempNormPrice = OperationList.Where(a => a.WorkPlace == int.Parse(txt_workPlace.Text) && a.OperationNumber == txt_operationNumber.Value).ToList();
                        if (tempNormPrice.Count == 1) { StdPerHour = tempNormPrice[0].PcsPerHour.ToString(); }
                    }

                    //Calculate Norm Price
                    if (tempNormPrice.Count == 1 && txt_pcs.Value != null)
                    {
                        Amount = decimal.Parse(txt_pcs.Value.ToString()); Amount = Math.Round(decimal.Parse(Amount.ToString()) * tempNormPrice[0].KcPerKs, 2);
                    }

                    //Calculate WorkPower
                    if (tempNormPrice.Count == 1 && txt_pcs.Value != null && dp_workTime.Value != null && dp_workTime.Value.Value.TotalSeconds > 0 && tempNormPrice[0].PcsPerHour != 0)
                    {
                        decimal stdKsTime = decimal.Parse((decimal.Parse(60.ToString()) / decimal.Parse(tempNormPrice[0].PcsPerHour.ToString())).ToString());
                        decimal stdVyrTime = decimal.Parse((stdKsTime * decimal.Parse(txt_pcs.Value.ToString())).ToString());
                        WorkPower = Math.Round((stdVyrTime / decimal.Parse(dp_workTime.Value.Value.TotalMinutes.ToString())) * 100, 2);
                    }

                    lbl_amount.Content = Resources["amount"].ToString() + ": " + Amount.ToString() + " Kč"; lbl_amount.Width = Math.Round(workResult.ActualWidth / 3, 0);
                    lbl_normPerHour.Content = Resources["standardPerHour"].ToString() + ": " + StdPerHour; lbl_normPerHour.Width = Math.Round(workResult.ActualWidth / 3, 0);
                    lbl_workPower.Content = Resources["workPower"].ToString() + ": " + WorkPower.ToString() + " %"; lbl_workPower.Width = Math.Round(workResult.ActualWidth / 3, 0);
                }
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, ex.StackTrace + Environment.NewLine + ex.Message); }
        }
    }
}