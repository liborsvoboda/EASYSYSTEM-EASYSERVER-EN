using Newtonsoft.Json;
using PRUVODKY.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Web;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace PRUVODKY
{
    public partial class GroupListPage : UserControl
    {
        public DataViewSupport dataViewSupport = new DataViewSupport();
        public GroupList selectedRecord = new GroupList();

        public GroupListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_name.Content = Resources["fname"].ToString();

            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;

            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<GroupList>>(ApiUrls.PRUVODKYGroupList, null, App.UserData.Authentification.Token); }
            catch { }

            MainWindow.ProgressRing = Visibility.Hidden;return true;
        }


        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Name") e.Header = Resources["name"].ToString();
                else if (headername == "Timestamp") e.Header = Resources["timestamp"].ToString();

                //Hide System Columns
                else if (headername == "Id") e.DisplayIndex = 0;
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
                    GroupList data = e as GroupList;
                    return data.Name.ToLower().Contains(filter.ToLower())
                    || data.Id.ToString().ToLower().Contains(filter.ToLower());
                };
            } catch { }
        }

        public void NewRecord()
        {
            selectedRecord = new GroupList();
            SetRecord(true);
        }

        public void EditRecord()
        {
            selectedRecord = (GroupList)DgListView.SelectedItem;
            SetRecord(true);
        }

        public void DeleteRecord()
        {
            selectedRecord = (GroupList)DgListView.SelectedItem;
            SetRecord(false);
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (GroupList)DgListView.SelectedItem;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (GroupList)DgListView.SelectedItem;
                SetRecord(false);
            } else
            {
                selectedRecord = new GroupList();
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
                selectedRecord.Name = tb_name.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;
                //selectedRecord.Role = roles.Where(a => a.Id == selectedRecord.RoleId).First();

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.PRUVODKYGroupList, httpContent, null, App.UserData.Authentification.Token);
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.PRUVODKYGroupList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new GroupList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (GroupList)DgListView.SelectedItem : new GroupList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm)
        {
            txt_id.Value = selectedRecord.Id;
            tb_name.Text = selectedRecord.Name;

            if (showForm) {
                MainWindow.DataGridSelected = MainWindow.DataGridSelectedId = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
            } else {
                MainWindow.DataGridSelectedId = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DataGridSelected = true; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }
     
    }
}