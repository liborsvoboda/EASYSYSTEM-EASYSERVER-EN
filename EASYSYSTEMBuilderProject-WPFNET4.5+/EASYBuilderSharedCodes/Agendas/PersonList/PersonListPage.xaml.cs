using Newtonsoft.Json;
using PRUVODKY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ComponentModel;
using MahApps.Metro.Controls.Dialogs;
using SharpDX;
using System.Threading.Tasks;

namespace PRUVODKY
{
    public partial class PersonListPage : UserControl//, INotifyPropertyChanged
    {
        public DataViewSupport dataViewSupport = new DataViewSupport();
        public PersonList selectedRecord = new PersonList();

        private List<GroupList> GroupList = new List<GroupList>();
        private string LastCorrectSearch = "";
        private bool messageShown = false;

        public PersonListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_group.Content = Resources["group"].ToString();
            lbl_personalNumber.Content = Resources["personalNumber"].ToString();
            lbl_name.Content = Resources["name"].ToString();
            lbl_surname.Content = Resources["surname"].ToString();

            btn_saveNext.Content = Resources["btn_saveNext"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            try { if (MainWindow.serviceRunning) GroupList = await ApiCommunication.GetApiRequest<List<GroupList>>(ApiUrls.PRUVODKYGroupList, null, App.UserData.Authentification.Token); }
            catch { }

            List<PersonList> data = new List<PersonList>();
            try { if (MainWindow.serviceRunning) data = await ApiCommunication.GetApiRequest<List<PersonList>>(ApiUrls.PRUVODKYPersonList, null, App.UserData.Authentification.Token); }
            catch { }

            List<ExtendedPersonList> extendedData = new List<ExtendedPersonList>();
            data.ForEach(record => {
                extendedData.Add(new ExtendedPersonList()
                {
                    Id = record.Id,
                    Group = GroupList.Where(a => a.Id == record.GroupId).First().Name,
                    PersonalNumber = record.PersonalNumber,
                    Name = record.Name,
                    SurName = record.SurName,
                    Timestamp = record.Timestamp,
                    UserId = record.UserId,
                    GroupId = record.GroupId

                });
            });
            DgListView.ItemsSource = extendedData;
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }


        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Name") e.Header = Resources["name"].ToString();
                else if (headername == "Group") e.Header = Resources["group"].ToString();
                else if (headername == "PersonalNumber") e.Header = Resources["personalNumber"].ToString();
                else if (headername == "Surname") e.Header = Resources["surname"].ToString();
                else if (headername == "Timestamp") e.Header = Resources["timestamp"].ToString();

                //Hide System Columns
                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "GroupId") e.Visibility = Visibility.Hidden;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
            });
        }


        //change filter fields
        public void Filter(string filter)
        {
            try {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) => {
                    ExtendedPersonList data = e as ExtendedPersonList;
                    return data.PersonalNumber.ToString().ToLower().Contains(filter.ToLower())
                    || data.Group.ToString().ToLower().Contains(filter.ToLower())
                    || data.Name.ToString().ToLower().Contains(filter.ToLower())
                    || data.SurName.ToString().ToLower().Contains(filter.ToLower());
                };
            } catch { }
        }

        public void NewRecord()
        {
            selectedRecord = new PersonList();
            SetRecord(true);
        }

        public void EditRecord()
        {
            selectedRecord = (PersonList)DgListView.SelectedItem;
            SetRecord(true);
        }

        public void DeleteRecord()
        {
            selectedRecord = (PersonList)DgListView.SelectedItem;
            SetRecord(false);
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (PersonList)DgListView.SelectedItem;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (PersonList)DgListView.SelectedItem;
                SetRecord(false);
            } else
            {
                selectedRecord = new PersonList();
                SetRecord(false);
            }
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.GroupId = GroupList.Where(a=> a.Name == tb_group.Text).FirstOrDefault().Id;
                selectedRecord.PersonalNumber = (int)txt_personalNumber.Value;
                selectedRecord.Name = tb_name.Text;
                selectedRecord.SurName = tb_surname.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.PRUVODKYPersonList, httpContent, null, App.UserData.Authentification.Token);;
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.PRUVODKYPersonList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new PersonList();
                    await LoadDataList();
                    SetRecord(false);
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private async void BtnSaveNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.GroupId = GroupList.Where(a => a.Name == tb_group.Text).FirstOrDefault().Id;
                selectedRecord.PersonalNumber = (int)txt_personalNumber.Value;
                selectedRecord.Name = tb_name.Text;
                selectedRecord.SurName = tb_surname.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.PRUVODKYPersonList, httpContent, null, App.UserData.Authentification.Token); ; }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.PRUVODKYPersonList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new PersonList();
                    await LoadDataList();
                    SetRecord(true);
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (PersonList)DgListView.SelectedItem : new PersonList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm)
        {
            txt_id.Value = selectedRecord.Id;
            tb_group.Text = selectedRecord.GroupId > 0 ? GroupList.Where(a => a.Id == selectedRecord.GroupId).FirstOrDefault().Name : null;
            txt_personalNumber.Value = selectedRecord.PersonalNumber;
            tb_name.Text = selectedRecord.Name;
            tb_surname.Text = selectedRecord.SurName;

            if (showForm) {
                MainWindow.DataGridSelected = MainWindow.DataGridSelectedId = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
                if (selectedRecord.Id == 0) { txt_personalNumber.Value = null; } tb_group.Focus();
            } else {
                MainWindow.DataGridSelectedId = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DataGridSelected = true; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        //Searched Items Part
        private void Tb_group_GotFocus(object sender, RoutedEventArgs e) => UpdateSearchResults();
        private async void UpdateSearchResults()
        {
            try
            {
                lv_groupSearchResults.Visibility = Visibility.Visible;
                List<GroupList> tempGroupList = GroupList.Where(a => a.Name.ToLower().Contains(!string.IsNullOrWhiteSpace(tb_group.Text) ? tb_group.Text.ToLower() : "")).ToList();
                if (tempGroupList.Count() == 0 && !messageShown )
                {
                    messageShown = true;
                    var result = await MainWindow.ShowMessage(true, Resources["groupNotExist"].ToString());
                    if (result == MessageDialogResult.Affirmative) { messageShown = false; }
                    tb_group.Text = LastCorrectSearch; tb_group.CaretIndex = tb_group.Text.Length;
                }
                else
                {
                    lv_groupSearchResults.ItemsSource = tempGroupList;
                    if (lv_groupSearchResults.Items.Count == 1)
                    {
                        tb_group.Text = ((GroupList)lv_groupSearchResults.Items[0]).Name;
                        lv_groupSearchResults.Visibility = Visibility.Hidden; txt_personalNumber.Focus(); txt_personalNumber.SelectAll();
                    }
                    else { lv_groupSearchResults.Visibility = Visibility.Visible; }
                    LastCorrectSearch = tb_group.Text;
                }
            } catch { }
        }
        private void PersonListPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up && lv_groupSearchResults.Visibility == Visibility.Visible) { lv_groupSearchResults.Focus(); }
            if (e.Key == Key.Down && lv_groupSearchResults.Visibility == Visibility.Visible) { lv_groupSearchResults.Focus(); }
            if (e.Key != Key.Down && e.Key != Key.Up && e.Key != Key.Enter && lv_groupSearchResults.Visibility == Visibility.Visible) { tb_group.Focus(); }
        }
        private void SelectGroup_Enter(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Enter) && lv_groupSearchResults.Visibility == Visibility.Visible)
            {
                tb_group.Text = lv_groupSearchResults.SelectedIndex == -1 ? null : ((GroupList)lv_groupSearchResults.SelectedItem).Name;
                lv_groupSearchResults.Visibility = Visibility.Hidden; txt_personalNumber.Focus(); txt_personalNumber.SelectAll();
            }
        }
        private void MouseSelectGroup_Click(object sender, MouseButtonEventArgs e)
        {
            tb_group.Text = lv_groupSearchResults.SelectedIndex == -1 ? null : ((GroupList)lv_groupSearchResults.SelectedItem).Name;
            lv_groupSearchResults.Visibility = Visibility.Hidden; txt_personalNumber.Focus(); txt_personalNumber.SelectAll();
        }
    }
}