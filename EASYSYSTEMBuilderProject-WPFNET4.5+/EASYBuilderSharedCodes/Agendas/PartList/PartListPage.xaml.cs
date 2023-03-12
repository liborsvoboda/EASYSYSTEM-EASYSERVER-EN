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
using System.Threading.Tasks;

namespace PRUVODKY
{
    public partial class PartListPage : UserControl
    {
        public DataViewSupport dataViewSupport = new DataViewSupport();
        public PartList selectedRecord = new PartList();

        public PartListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_workPlace.Content = Resources["workPlace"].ToString();
            lbl_partNumber.Content = Resources["partNumber"].ToString();
            lbl_name.Content = Resources["fname"].ToString();

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
            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<PartList>>(ApiUrls.PRUVODKYPartList, null, App.UserData.Authentification.Token); }
            catch { }
            
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }


        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Name") e.Header = Resources["fname"].ToString();
                else if (headername == "WorkPlace") e.Header = Resources["workPlace"].ToString();
                else if (headername == "Number") e.Header = Resources["partNumber"].ToString();
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
                    PartList data = e as PartList;
                    return data.WorkPlace.ToString().ToLower().Contains(filter.ToLower())
                    || data.Number.ToString().ToLower().Contains(filter.ToLower())
                    || data.Name.ToString().ToLower().Contains(filter.ToLower());
                };
            } catch { }
        }

        public void NewRecord()
        {
            selectedRecord = new PartList();
            SetRecord(true);
        }

        public void EditRecord()
        {
            selectedRecord = (PartList)DgListView.SelectedItem;
            SetRecord(true);
        }

        public void DeleteRecord()
        {
            selectedRecord = (PartList)DgListView.SelectedItem;
            SetRecord(false);
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (PartList)DgListView.SelectedItem;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (PartList)DgListView.SelectedItem;
                SetRecord(false);
            } else
            {
                selectedRecord = new PartList();
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
                selectedRecord.WorkPlace = (int)txt_workPlace.Value;
                selectedRecord.Number = tb_partNumber.Text;
                selectedRecord.Name = tb_name.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.PRUVODKYPartList, httpContent, null, App.UserData.Authentification.Token);;
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.PRUVODKYPartList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new PartList();
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
                selectedRecord.WorkPlace = (int)txt_workPlace.Value;
                selectedRecord.Number = tb_partNumber.Text;
                selectedRecord.Name = tb_name.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.PRUVODKYPartList, httpContent, null, App.UserData.Authentification.Token); ; ;
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.PRUVODKYPartList, httpContent, null, App.UserData.Authentification.Token); ; }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new PartList();
                    await LoadDataList();
                    SetRecord(true);
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (PartList)DgListView.SelectedItem : new PartList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm)
        {
            txt_id.Value = selectedRecord.Id;
            txt_workPlace.Value = selectedRecord.WorkPlace;
            tb_partNumber.Text = selectedRecord.Number;
            tb_name.Text = selectedRecord.Name;

            if (showForm) {
                MainWindow.DataGridSelected = MainWindow.DataGridSelectedId = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
                if (selectedRecord.Id == 0) { txt_workPlace.Value = null; txt_workPlace.Focus(); }
            } else {
                MainWindow.DataGridSelectedId = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DataGridSelected = true; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }
    }
}