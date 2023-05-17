using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalClasses;
using GlobalNET.GlobalOperations;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace GlobalNET.Pages {

    public partial class ReportListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ReportList selectedRecord = new ReportList();

        private List<TranslatedApiList> translatedApiList = new List<TranslatedApiList>();
        private List<ReportList> reportList = new List<ReportList>();
        private bool reportSupportForListOnly = true;

        public ReportListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            try
            {
                //translate fields in detail form
                lbl_id.Content = Resources["id"].ToString();
                lbl_pageName.Content = Resources["dataView"].ToString();
                lbl_systemName.Content = Resources["systemName"].ToString();
                lbl_joinedId.Content = Resources["joinedId"].ToString();
                lbl_description.Content = Resources["description"].ToString();
                lbl_reportPath.Content = Resources["reportPath"].ToString();
                lbl_timestamp.Content = Resources["timestamp"].ToString();
                lbl_default.Content = Resources["default"].ToString();

                btn_export.Content = Resources["export"].ToString();
                btn_browse.Content = Resources["browse"].ToString();
                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();

                LoadParameters();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            _ = LoadDataList();
            SetRecord(false);
        }

        private async void LoadParameters() {
            reportSupportForListOnly = bool.Parse(await DataOperations.ParameterCheck("ReportSupportForListOnly"));
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            try
            {
                reportList = await ApiCommunication.GetApiRequest<List<ReportList>>(ApiUrls.ReportList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
                cb_pageName.ItemsSource = translatedApiList = await DataOperations.GetTranslatedApiList(reportSupportForListOnly);

                reportList.ForEach(async report =>
                {
                    report.Translation = await DBOperations.DBTranslation(report.SystemName);
                    report.PageTranslation = translatedApiList.FirstOrDefault(a => a.ApiTableName == report.PageName).Translate;
                });

                DgListView.ItemsSource = reportList;
                DgListView.Items.Refresh();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }

            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "SystemName") { e.Header = Resources["systemName"].ToString(); e.DisplayIndex = 1; }
                else if (headername == "Translation") { e.Header = Resources["translation"].ToString(); e.DisplayIndex = 2; }
                else if (headername == "PageTranslation") { e.Header = Resources["tableName"].ToString(); e.DisplayIndex = 3; }
                else if (headername == "JoinedId") e.Header = Resources["joinedId"].ToString();
                else if (headername == "Description") e.Header = Resources["description"].ToString();
                else if (headername == "Default") { e.Header = Resources["default"].ToString(); e.DisplayIndex = DgListView.Columns.Count - 3; }
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "ReportPath") e.Visibility = Visibility.Hidden;
                else if (headername == "File") e.Visibility = Visibility.Hidden;
                else if (headername == "MimeType") e.Visibility = Visibility.Hidden;
                else if (headername == "PageName") e.Visibility = Visibility.Hidden;
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
                    ReportList report = e as ReportList;
                    return report.PageName.ToLower().Contains(filter.ToLower())
                    || report.SystemName.ToLower().Contains(filter.ToLower())
                    || report.PageTranslation.ToLower().Contains(filter.ToLower())
                    || report.Translation.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(report.Description) && report.Description.ToLower().Contains(filter.ToLower())
                    ;
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void NewRecord() {
            selectedRecord = new ReportList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (ReportList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (ReportList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.ReportList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ReportList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (ReportList)DgListView.SelectedItem;
            }
            else { selectedRecord = new ReportList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.PageName = ((TranslatedApiList)cb_pageName.SelectedItem).ApiTableName;
                selectedRecord.SystemName = txt_systemName.Text;
                selectedRecord.JoinedId = (bool)chb_joinedId.IsChecked;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.Default = (bool)chb_default.IsChecked;

                if (!string.IsNullOrWhiteSpace(txt_reportPath.Text))
                {
                    selectedRecord.ReportPath = txt_reportPath.Text;
                    selectedRecord.MimeType = MimeMapping.GetMimeMapping(txt_reportPath.Text);
                    selectedRecord.File = System.IO.File.ReadAllBytes(txt_reportPath.Text);
                }

                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.ReportList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.ReportList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new ReportList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ReportList)DgListView.SelectedItem : new ReportList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false) {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            cb_pageName.Text = (selectedRecord.Id == 0) ? null : selectedRecord.PageTranslation;
            txt_systemName.Text = selectedRecord.SystemName;

            chb_joinedId.IsChecked = selectedRecord.JoinedId;
            txt_reportPath.Text = null;
            txt_description.Text = selectedRecord.Description;
            chb_default.IsChecked = selectedRecord.Default;
            dp_timestamp.Value = selectedRecord.Timestamp;

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

        private void BtnBrowse_Click(object sender, RoutedEventArgs e) {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog
                {
                    DefaultExt = ".rdl",
                    Filter = "Report files |*.rdl",
                    Title = Resources["fileOpenDescription"].ToString()
                };
                if (dlg.ShowDialog() == true)
                {
                    txt_reportPath.Text = dlg.FileName;
                    selectedRecord.MimeType = MimeMapping.GetMimeMapping(dlg.FileName);
                    selectedRecord.File = System.IO.File.ReadAllBytes(dlg.FileName);
                }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e) {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog
                { DefaultExt = ".rdl", Filter = "Report files |*.rdl", Title = Resources["fileOpenDescription"].ToString() };
                if (dlg.ShowDialog() == true) { FileOperations.ByteArrayToFile(dlg.FileName, selectedRecord.File); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }
    }
}