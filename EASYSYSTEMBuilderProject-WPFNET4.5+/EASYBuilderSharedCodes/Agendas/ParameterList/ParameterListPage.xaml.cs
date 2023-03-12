using Newtonsoft.Json;
using GlobalNET.Classes;
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
using GlobalNET;
using Org.BouncyCastle.Asn1.X509;
using System.Threading.Tasks;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;

namespace GlobalNET.Pages
{
    public partial class ParameterListPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ParameterList selectedRecord = new ParameterList();

        private ObservableCollection<ReportSelection> ParamTypes = new ObservableCollection<ReportSelection>() {
                                                               new ReportSelection() { Name = "bit" },
                                                               new ReportSelection() { Name = "string" },
                                                               new ReportSelection() { Name = "int" },
                                                               new ReportSelection() { Name = "numeric" },
                                                               new ReportSelection() { Name = "date" },
                                                               new ReportSelection() { Name = "time" },
                                                               new ReportSelection() { Name = "datetime" },
                                                             };
        public ParameterListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_parameter.Content = Resources["parameter"].ToString();
            lbl_value.Content = Resources["value"].ToString();
            lbl_type.Content = Resources["type"].ToString();
            lbl_description.Content = Resources["description"].ToString();
            lbl_active.Content = Resources["active"].ToString();
            lbl_timestamp.Content = Resources["timestamp"].ToString();

            btn_check.Content = Resources["check"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();


            cb_type.ItemsSource = ParamTypes;

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            try { if (MainWindow.serviceRunning) DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<ParameterList>>(ApiUrls.GlobalNETParameterList, App.UserData.Authentification.Id.ToString(), App.UserData.Authentification.Token); }
            catch { }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }


        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Parameter") e.Header = Resources["parameter"].ToString();
                else if (headername == "Value") { e.Header = Resources["value"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Type") { e.Header = Resources["type"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Description") { e.Header = Resources["description"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

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
                    ParameterList param = e as ParameterList;
                    return param.Parameter.ToLower().Contains(filter.ToLower())
                    || param.Value.ToLower().Contains(filter.ToLower())
                    || param.Type.ToLower().Contains(filter.ToLower())
                    || param.Type.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(param.Description) && param.Description.ToLower().Contains(filter.ToLower())
                    ;
                };
            } catch { }
        }

        public void NewRecord()
        {
            selectedRecord = new ParameterList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy)
        {
            selectedRecord = (ParameterList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord()
        {
            selectedRecord = (ParameterList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETParameterList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedRecord = (ParameterList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (ParameterList)DgListView.SelectedItem;
            } else { selectedRecord = new ParameterList(); }
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
                selectedRecord.Parameter = txt_parameter.Text;
                selectedRecord.Value = txt_value.Text;
                selectedRecord.Type = ((ReportSelection)cb_type.SelectedItem).Name;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETParameterList, httpContent, null, App.UserData.Authentification.Token);
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETParameterList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    // Refresh Param in memory
                    if (App.Parameters.Where(a => a.Parameter == selectedRecord.Parameter).Count() == 0)
                    { App.Parameters.Add(new Parameters() { Parameter = selectedRecord.Parameter, Value = selectedRecord.Value }); }
                    else { App.Parameters.Where(a => a.Parameter == selectedRecord.Parameter).First().Value = selectedRecord.Value; }

                    selectedRecord = new ParameterList();
                    await LoadDataList();
                    SetRecord(false);
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch { }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ParameterList)DgListView.SelectedItem : new ParameterList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false)
        {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            txt_parameter.Text = selectedRecord.Parameter;
            txt_value.Text = selectedRecord.Value;
            cb_type.Text = selectedRecord.Type;
            txt_description.Text = selectedRecord.Description;
            chb_active.IsChecked = selectedRecord.Active;

            if (showForm) {
                MainWindow.DataGridSelected = MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
            } else {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        private void Value_TextChanged(object sender, TextChangedEventArgs e) => btn_save.IsEnabled = false;
        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e) => btn_save.IsEnabled = false;


        private void Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                btn_save.IsEnabled = false;
                switch ((string)cb_type.SelectedValue)
                {
                    case "bit":
                        bool.Parse(txt_value.Text);
                        break;
                    case "int":
                        int.Parse(txt_value.Text);
                        break;
                    case "numeric":
                        double.Parse(txt_value.Text);
                        break;
                    case "date":
                        DateTime.Parse(txt_value.Text);
                        break;
                    case "time":
                        TimeSpan.Parse(txt_value.Text);
                        break;
                    case "datetime":
                        DateTime.Parse(txt_value.Text);
                        break;
                }
                btn_save.IsEnabled = true;
            }
            catch { }
        }

    }
}