﻿using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading.Tasks;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using GlobalNET.GlobalFunctions;
using MahApps.Metro.Controls.Dialogs;
using System.Net;
using GlobalNET.GlobalClasses;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace GlobalNET.Pages
{
    public partial class AccessRoleListPage : UserControl
    {

        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static AccessRoleList selectedRecord = new AccessRoleList();



        private ObservableCollection<UpdateVariant> ApiTables = new ObservableCollection<UpdateVariant>() {
            //  new UpdateVariant() { Name = "SomeName", Value = someView },
        };
        private List<UserRoleList> userRoleList = new List<UserRoleList>();
        private List<AccessRoleList> accessRoleLists = new List<AccessRoleList>();  

        public AccessRoleListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            try
            {
                lbl_id.Content = Resources["id"].ToString();
                lbl_tableName.Content = Resources["tableName"].ToString();
                lbl_accessRole.Content = Resources["accessRole"].ToString();
                
                btn_save.Content = Resources["btn_save"].ToString();
                btn_cancel.Content = Resources["btn_cancel"].ToString();
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}

            _ = LoadDataList();
            SetRecord(false);
        }


        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            try { 

                accessRoleLists = await ApiCommunication.GetApiRequest<List<AccessRoleList>>(ApiUrls.AccessRoleList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
                accessRoleLists.ForEach(access => { access.Translation = SystemFunctions.DBTranslation(access.TableName); });

                DgListView.ItemsSource = accessRoleLists;
                DgListView.Items.Refresh();

                //Prepare Table List from ApiList and Local dictionary
                ApiTables.Clear();
                foreach (ApiUrls apiUrl in (ApiUrls[])Enum.GetValues(typeof(ApiUrls)))
                {
                    if (apiUrl.ToString().EndsWith("List")){
                        try {
                            ApiTables.Add(new UpdateVariant() { Name = Resources[$"{apiUrl.ToString().Replace(GetType().Namespace.Replace(".Pages", ""), "").FirstOrDefault().ToString().ToLower()}{apiUrl.ToString().Replace(GetType().Namespace.Replace(".Pages", ""), "").Substring(1)}"].ToString(), Value = apiUrl.ToString().Replace(GetType().Namespace.Replace(".Pages", ""), "") });
                        }catch {}
                    }

                } cb_tableName.ItemsSource = ApiTables.OrderBy(a => a.Name);

                userRoleList = await ApiCommunication.GetApiRequest<List<UserRoleList>>(ApiUrls.UserRoleList, null, App.UserData.Authentification.Token);
                userRoleList.ForEach(role => { role.Translation = SystemFunctions.DBTranslation(role.SystemName); });
                cb_accessRole.ItemsSource = userRoleList;
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
            MainWindow.ProgressRing = Visibility.Hidden;return true;
        }

        private void DgListView_Translate(object sender, EventArgs ex)
        {
            try { 
                ((DataGrid)sender).Columns.ToList().ForEach(e => {
                    string headername = e.Header.ToString();
                    if (headername == "TableName") { e.Header = Resources["tableName"].ToString(); e.DisplayIndex = 1; }
                    else if (headername == "Translation") { e.Header = Resources["translation"].ToString(); e.DisplayIndex = 2; }
                    else if (headername == "AccessRole") e.Header = Resources["accessRole"].ToString();
                    else if (headername == "TimeStamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                });
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        public void Filter(string filter)
        {
            try {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) => {
                    AccessRoleList user = e as AccessRoleList;
                    return user.TableName.ToLower().Contains(filter.ToLower())
                    || user.AccessRole.ToLower().Contains(filter.ToLower());
                };
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }


        public void NewRecord()
        {
            selectedRecord = new AccessRoleList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }


        public void EditRecord(bool copy)
        {
            selectedRecord = (AccessRoleList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }


        public async void DeleteRecord()
        {
            selectedRecord = (AccessRoleList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.AccessRoleList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                await LoadDataList(); SetRecord(false);
            }
        }


        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (AccessRoleList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }


        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (AccessRoleList)DgListView.SelectedItem; }
            else { selectedRecord = new AccessRoleList(); }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }


        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.TableName = ((UpdateVariant)cb_tableName.SelectedItem).Value;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;

                selectedRecord.AccessRole = "";
                for (int i = 0; i < cb_accessRole.SelectedItems.Count; i++)
                { selectedRecord.AccessRole += ((UserRoleList)cb_accessRole.SelectedItems[i]).SystemName + ","; }
                

                selectedRecord.Translation = null;
                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.AccessRoleList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.AccessRoleList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new AccessRoleList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }


        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (AccessRoleList)DgListView.SelectedItem : new AccessRoleList();
            SetRecord(false);
        }


        private void SetRecord(bool showForm, bool copy = false)
        {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;
            cb_tableName.Text = selectedRecord.TableName != null ? Resources[selectedRecord.TableName.FirstOrDefault().ToString().ToLower() + selectedRecord.TableName.Substring(1)].ToString() : null;

            cb_accessRole.SelectedItems.Clear();
            if (!string.IsNullOrWhiteSpace(selectedRecord.AccessRole))
                selectedRecord.AccessRole.Split(',').ToList().ForEach(role => { if (!string.IsNullOrEmpty(role)) cb_accessRole.SelectedItems.Add(userRoleList.First(a=> a.SystemName == role)); });
            

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

    }
}