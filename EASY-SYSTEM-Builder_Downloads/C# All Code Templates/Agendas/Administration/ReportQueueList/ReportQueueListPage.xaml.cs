﻿using EASYTools.SqlConnectionDialog;
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
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

// This is Template ListView + UserForm
namespace GlobalNET.Pages {

    public partial class ReportQueueListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ReportQueueList selectedRecord = new ReportQueueList();

        private string connectionString = null;
        private List<TranslatedApiList> translatedApiList = new List<TranslatedApiList>();
        private List<ReportQueueList> reportQueueList = new List<ReportQueueList>();
        private bool reportSupportForListOnly = true;

        public ReportQueueListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            try
            {
                lbl_id.Content = Resources["id"].ToString();
                lbl_name.Content = Resources["fname"].ToString();
                lbl_sequence.Content = Resources["sequence"].ToString();
                lbl_sql.Content = Resources["sqlWithoutWherePart"].ToString();
                lbl_tableName.Content = Resources["tableName"].ToString();
                lbl_searchColumnList.Content = Resources["searchColumnList"].ToString();
                lbl_searchFilterIgnore.Content = Resources["searchFilterIgnore"].ToString();
                lbl_recIdFilterIgnore.Content = Resources["recIdFilterIgnore"].ToString();

                btn_connect.Content = Resources["connectSql"].ToString();
                btn_execute.Content = Resources["execute"].ToString();
                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }

            LoadParameters();
            _ = LoadDataList();
            SetRecord(false);
        }

        private async void LoadParameters() {
            DgListView.RowHeight = double.Parse(await DataOperations.ParameterCheck("ReportSqlRowHeight"));
            reportSupportForListOnly = bool.Parse(await DataOperations.ParameterCheck("ReportSupportForListOnly"));
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            try
            {
                reportQueueList = await ApiCommunication.GetApiRequest<List<ReportQueueList>>(ApiUrls.ReportQueueList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
                translatedApiList = await DataOperations.GetTranslatedApiList(reportSupportForListOnly);
                reportQueueList.ForEach(rq => { rq.TranslatedTableName = translatedApiList.First(a => a.ApiTableName == rq.TableName).Translate; });

                cb_tableName.ItemsSource = translatedApiList;

                DgListView.ItemsSource = reportQueueList;
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
                    if (headername == "Name") { e.Header = Resources["fname"].ToString(); e.DisplayIndex = 1; }
                    else if (headername == "TranslatedTableName") { e.Header = Resources["tableName"].ToString(); e.DisplayIndex = 2; }
                    else if (headername == "Sequence") { e.Header = Resources["sequence"].ToString(); e.DisplayIndex = 3; }
                    else if (headername == "Sql") e.Header = Resources["sqlCommand"].ToString();
                    else if (headername == "SearchColumnList") e.Header = Resources["searchColumnList"].ToString();
                    else if (headername == "SearchFilterIgnore") { e.Header = Resources["searchFilterIgnore"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                    else if (headername == "RecIdFilterIgnore") { e.Header = Resources["recIdFilterIgnore"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "Filter") e.Visibility = Visibility.Hidden;
                    else if (headername == "Search") e.Visibility = Visibility.Hidden;
                    else if (headername == "RecId") e.Visibility = Visibility.Hidden;
                    else if (headername == "TableName") e.Visibility = Visibility.Hidden;
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
                    ReportQueueList user = e as ReportQueueList;
                    return user.Name.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Sql) && user.Sql.ToLower().Contains(filter.ToLower())
                    || user.TranslatedTableName.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.SearchColumnList) && user.SearchColumnList.ToLower().Contains(filter.ToLower())
                    ;
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        public void NewRecord() {
            selectedRecord = new ReportQueueList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy) {
            selectedRecord = (ReportQueueList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord() {
            selectedRecord = (ReportQueueList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.ReportQueueList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ReportQueueList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (ReportQueueList)DgListView.SelectedItem;
                dataViewSupport.SelectedRecordId = selectedRecord.Id;
                SetRecord(false);
            }
            else
            {
                selectedRecord = new ReportQueueList();
                SetRecord(false);
            }
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e) {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.Name = txt_name.Text;
                selectedRecord.Sequence = int.Parse(txt_sequence.Value.ToString());
                selectedRecord.Sql = txt_sql.Text;
                selectedRecord.TableName = ((TranslatedApiList)cb_tableName.SelectedItem).ApiTableName;
                selectedRecord.SearchColumnList = txt_searchColumnList.Text;
                selectedRecord.SearchFilterIgnore = (bool)chb_searchFilterIgnore.IsChecked;
                selectedRecord.RecIdFilterIgnore = (bool)chb_recIdFilterIgnore.IsChecked;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.ReportQueueList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.ReportQueueList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new ReportQueueList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e) {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ReportQueueList)DgListView.SelectedItem : new ReportQueueList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false) {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            txt_name.Text = selectedRecord.Name;
            txt_sequence.Value = selectedRecord.Sequence;
            txt_sql.Text = selectedRecord.Sql;

            cb_tableName.Text = (selectedRecord.Id == 0) ? null : selectedRecord.TranslatedTableName;
            txt_searchColumnList.Text = selectedRecord.SearchColumnList;
            chb_searchFilterIgnore.IsChecked = selectedRecord.SearchFilterIgnore;
            chb_recIdFilterIgnore.IsChecked = selectedRecord.RecIdFilterIgnore;

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

        private void Connect_Click(object sender, RoutedEventArgs e) {
            var factory = new ConnectionStringFactory();
            connectionString = factory.BuildConnectionString();

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                btn_execute.IsEnabled = true;
            }
        }

        private void Connection_StateChange(object sender, StateChangeEventArgs e) {
            if (e.CurrentState == ConnectionState.Open)
            {
                btn_connect.Content = Resources["disconnect"].ToString(); btn_execute.IsEnabled = true;
            }
            else { btn_connect.Content = Resources["connectSql"].ToString(); }
        }

        private async void Execute_Click(object sender, RoutedEventArgs e) {
            MainWindow.ProgressRing = Visibility.Visible;
            try
            {
                SqlCommand cmd;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    cmd = new SqlCommand(txt_sql.Text, connection);
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    table.Load(cmd.ExecuteReader());
                    DgSubListView.ItemsSource = table.DefaultView;
                    DgSubListView.Items.Refresh();
                }
                MainWindow.ProgressRing = Visibility.Visible;
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, ex.Message + Environment.NewLine + ex.StackTrace); }
            finally { MainWindow.ProgressRing = Visibility.Hidden; }
        }
    }
}