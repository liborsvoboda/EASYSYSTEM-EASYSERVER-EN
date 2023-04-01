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
using System.Threading.Tasks;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using System.Net;

namespace GlobalNET.Pages
{
    public partial class UserListPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static UserList selectedRecord = new UserList();

        private List<UserList> userList = new List<UserList>();
        private List<UserRoleList> userRoleList = new List<UserRoleList>();

        public UserListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_roleId.Content = Resources["role"].ToString();
            lbl_userName.Content = Resources["userName"].ToString();
            lbl_password.Content = Resources["password"].ToString();
            lbl_name.Content = Resources["name"].ToString();
            lbl_surname.Content = Resources["surname"].ToString();
            lbl_description.Content = Resources["description"].ToString();
            lbl_active.Content = Resources["active"].ToString();
            lbl_timestamp.Content = Resources["timestamp"].ToString();
            lbl_token.Content = Resources["token"].ToString();
            lbl_expiration.Content = Resources["expiration"].ToString();

            btn_browse.Content = Resources["browse"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;

            try
            {
                userList = await ApiCommunication.GetApiRequest<List<UserList>>(ApiUrls.GlobalNETUserList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
                userRoleList = await ApiCommunication.GetApiRequest<List<UserRoleList>>(ApiUrls.UserRoleList, null, App.UserData.Authentification.Token);

                userList.ForEach(user => { user.Translation = SystemFunctions.DBTranslation(userRoleList.First(a => a.Id == user.RoleId).SystemName); });
                userRoleList.ForEach(role => { role.Translation = SystemFunctions.DBTranslation(role.SystemName); });

                DgListView.ItemsSource = userList;
                DgListView.Items.Refresh();
                cb_roleId.ItemsSource = userRoleList;

            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
            DgListView.Items.Refresh();
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }


        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "Username") { e.Header = Resources["userName"].ToString(); e.DisplayIndex = 1; }
                else if (headername == "Translation") { e.Header = Resources["role"].ToString(); e.DisplayIndex = 2; }
                else if (headername == "Password") e.Header = Resources["password"].ToString();
                else if (headername == "Name") e.Header = Resources["name"].ToString();
                else if (headername == "Surname") e.Header = Resources["surname"].ToString();
                else if (headername == "Description") e.Header = Resources["description"].ToString();
                else if (headername == "Expiration") e.Header = Resources["expiration"].ToString();
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;

                else if (headername == "RoleId") e.Visibility = Visibility.Hidden;
                else if (headername == "Photo") e.Visibility = Visibility.Hidden;
                else if (headername == "Token") e.Visibility = Visibility.Hidden;
                else if (headername == "PhotoPath") e.Visibility = Visibility.Hidden;
                else if (headername == "MimeType") e.Visibility = Visibility.Hidden;
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
                    UserList user = e as UserList;
                    return user.Username.ToLower().Contains(filter.ToLower())
                    || user.Name.ToLower().Contains(filter.ToLower())
                    || user.Surname.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Description) && user.Description.ToLower().Contains(filter.ToLower())
                    ;
                };
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        public void NewRecord()
        {
            selectedRecord = new UserList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy)
        {
            selectedRecord = (UserList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord()
        {
            selectedRecord = (UserList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETUserList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (UserList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            { selectedRecord = (UserList)DgListView.SelectedItem;
            } else { selectedRecord = new UserList(); }
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
                selectedRecord.RoleId = ((UserRoleList)cb_roleId.SelectedItem).Id;
                selectedRecord.Username = txt_userName.Text;
                selectedRecord.Password = pb_password.Password;
                selectedRecord.Name = txt_name.Text;
                selectedRecord.Surname = txt_surname.Text;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.Timestamp = DateTimeOffset.Now.DateTime;
                selectedRecord.Token = txt_token.Text;
                selectedRecord.Expiration = dp_expiration.Value;

                if (selectedRecord.PhotoPath != txt_photoPath.Text)
                {
                    selectedRecord.MimeType = MimeMapping.GetMimeMapping(txt_photoPath.Text);
                    selectedRecord.Photo = File.ReadAllBytes(txt_photoPath.Text);
                    selectedRecord.PhotoPath = txt_photoPath.Text;
                }

                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                {
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETUserList, httpContent, null, App.UserData.Authentification.Token);
                }
                else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETUserList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    selectedRecord = new UserList();
                    await LoadDataList();
                    SetRecord(false);
                }
                else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (UserList)DgListView.SelectedItem : new UserList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private void SetRecord(bool showForm, bool copy = false)
        {
            txt_id.Value = (copy) ? 0 : selectedRecord.Id;

            cb_roleId.SelectedItem = (selectedRecord.Id == 0) ? userRoleList.FirstOrDefault() : userRoleList.First(a=> a.Id == selectedRecord.RoleId);
            txt_userName.Text = selectedRecord.Username;
            pb_password.Password = selectedRecord.Password;
            txt_name.Text = selectedRecord.Name;
            txt_surname.Text = selectedRecord.Surname;
            txt_description.Text = selectedRecord.Description;
            chb_active.IsChecked = (selectedRecord.Id == 0) ? App.Setting.ActiveNewInputDefault : selectedRecord.Active;
            dp_timestamp.Value = selectedRecord.Timestamp;
            txt_token.Text = selectedRecord.Token;
            dp_expiration.Value = selectedRecord.Expiration;
            img_photoPath.Source = (!string.IsNullOrWhiteSpace(selectedRecord.PhotoPath)) ? MediaFunctions.ByteToImage(selectedRecord.Photo) : new BitmapImage(new Uri(Path.Combine(App.settingFolder, "no_photo.png")));
            txt_photoPath.Text = selectedRecord.PhotoPath;

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

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog() { DefaultExt = ".png", Filter = "Image files |*.png;*.jpg;*.jpeg", Title = Resources["fileOpenDescription"].ToString() };
                if (dlg.ShowDialog() == true)
                {
                    img_photoPath.Source = new BitmapImage(new Uri(dlg.FileName));
                    txt_photoPath.Text = dlg.FileName;
                    selectedRecord.Photo = File.ReadAllBytes(dlg.FileName);
                }
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }
    }
}