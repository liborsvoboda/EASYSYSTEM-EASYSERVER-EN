using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Org.BouncyCastle.Asn1;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Media;
using GlobalNET.Classes;
using System.Collections.ObjectModel;
using System;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.Helper;
using GlobalNET.GlobalClasses;

namespace GlobalNET.Pages
{
    public partial class ClientSettingsPage : UserControl
    {
        public ObservableCollection<Language> Languages = new ObservableCollection<Language>() {
                                                                new Language() { Name = "System", Value = "system" },
                                                                new Language() { Name = "Czech", Value = "cs-CZ" },
                                                                new Language() { Name = "English", Value = "en-US" }
                                                             };

        public ClientSettingsPage()
        {
            InitializeComponent();
            Language defaultLanguage = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage);
            _ = MediaFunctions.SetLanguageDictionary(Resources, defaultLanguage.Value);

            ObservableCollection<UpdateVariant> UpdateVariants = new ObservableCollection<UpdateVariant>() {
                                                                new UpdateVariant() { Name = Resources["never"].ToString(), Value = "never" },
                                                                new UpdateVariant() { Name = Resources["showInfo"].ToString(), Value = "showInfo"},
                                                                new UpdateVariant() { Name = Resources["automaticDownload"].ToString(), Value = "automaticDownload"},
                                                                new UpdateVariant() { Name = Resources["automaticInstall"].ToString(), Value = "automaticInstall"}
                                                             };

            lbl_apiAddress.Content = Resources["apiAddress"].ToString();
            lbl_writeToLog.Content = Resources["logging"].ToString();
            lbl_serverCheckIntervalSec.Content = Resources["serverCheckIntervalSec"].ToString();
            lbl_topMost.Content = Resources["topMost"].ToString();
            lbl_activeNewInputDefault.Content = Resources["activeNewInputDefault"].ToString();
            lbl_defaultLanguage.Content = Resources["defaultLanguage"].ToString();
            lbl_reportingPath.Content = Resources["reportingPath"].ToString();
            lbl_updateUrl.Content = Resources["updateUrl"].ToString();
            lbl_automaticUpdate.Content = Resources["automaticUpdate"].ToString();
            lbl_hideStartVideo.Content = Resources["hideStartVideo"].ToString();
            btn_showVideo.Content = Resources["showVideo"].ToString();
            lbl_reportConnectionString.Content = Resources["reportConnectionString"].ToString();
            lbl_reportBuilder.Content = Resources["reportBuilder"].ToString();

            btn_run.Content = Resources["run"].ToString();
            btn_test.Content = Resources["test"].ToString();
            btn_browseDesigner.Content = btn_browse.Content = Resources["browse"].ToString();
            btn_checkUpdate.Content = Resources["checkUpdate"].ToString();
            btn_restart.Content = Resources["restart"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btnApiTest.Content = Resources["apiConnectionTest"].ToString();


            //data
            txt_apiAddress.Text = App.Setting.ApiAddress;
            chb_WritetoLog.IsChecked = App.Setting.WriteToLog;
            txt_serverCheckIntervalSec.Value = App.Setting.ServerCheckIntervalSec * 0.001;
            chb_topMost.IsChecked = App.Setting.TopMost;
            chb_activeNewInputDefault.IsChecked = App.Setting.ActiveNewInputDefault;
            txt_reportingPath.Text = App.Setting.ReportingPath;
            txt_updateUrl.Text = App.Setting.UpdateUrl;
            chb_hideStartVideo.IsChecked = App.Setting.HideStartVideo;
            pb_reportConnectionString.Password = App.Setting.ReportConnectionString;
            txt_reportBuilder.Text = App.Setting.ReportBuilderPath;

            cb_defaultLanguage.ItemsSource = Languages;
            cb_automaticUpdate.ItemsSource = UpdateVariants;

            int index = 0;
            cb_defaultLanguage.Items.SourceCollection.Cast<Language>().ToList().ForEach(language => { if (language.Name == defaultLanguage.Name) { cb_defaultLanguage.SelectedIndex = index; } index++; });
            index = 0;
            cb_automaticUpdate.Items.SourceCollection.Cast<UpdateVariant>().ToList().ForEach(update => { if (update.Value == App.Setting.AutomaticUpdate) { cb_automaticUpdate.SelectedIndex = index; } index++; });

        }

        private async void BtnApiTest_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    MainWindow.ProgressRing = Visibility.Visible;
                    string json = await httpClient.GetStringAsync(txt_apiAddress.Text + "/" + ApiUrls.BackendCheck + "/Db");
                    tbOutputMessageBox.Foreground = new SolidColorBrush(Colors.Green); tbOutputMessageBox.Text = json;
                    MainWindow.ProgressRing = Visibility.Hidden;
                }
                catch
                {
                    try
                    {
                        MainWindow.ProgressRing = Visibility.Visible;
                        string json = await httpClient.GetStringAsync(txt_apiAddress.Text + "/" + ApiUrls.BackendCheck);
                        tbOutputMessageBox.Foreground = new SolidColorBrush(Colors.Green); tbOutputMessageBox.Text = json;
                        MainWindow.ProgressRing = Visibility.Hidden;
                    }
                    catch (Exception ex)
                    {
                        tbOutputMessageBox.Text = null;
                        await MainWindow.ShowMessage(true, "Exception Error : " + ex.Message + Environment.NewLine + ex.StackTrace);
                    }
                }

            }
        }

        #region helper methods
        private class ExtensionsItem
        {
            public ExtensionsItem()
            {
                ident = null;
                isTrue = false;
                asn1OctetString = null;
            }

            public DerObjectIdentifier ident { get; set; }
            public bool isTrue { get; set; }
            public Asn1OctetString asn1OctetString { get; set; }
        }

        #endregion

        private void Txt_apiAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_apiAddress.Text.Length > 0) btnApiTest.IsEnabled = true; else btnApiTest.IsEnabled = false;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            App.Setting.ApiAddress = txt_apiAddress.Text;
            App.Setting.WriteToLog = (bool)chb_WritetoLog.IsChecked;
            App.Setting.ServerCheckIntervalSec = (double)txt_serverCheckIntervalSec.Value * 1000;
            App.Setting.TopMost = (bool)chb_topMost.IsChecked;
            App.Setting.ActiveNewInputDefault = (bool)chb_activeNewInputDefault.IsChecked;
            App.Setting.DefaultLanguage = JsonConvert.SerializeObject((Language)cb_defaultLanguage.SelectedItem);
            App.Setting.ThemeName = App.Setting.ThemeName;
            App.Setting.AccentName = App.Setting.AccentName;
            App.Setting.ReportingPath = txt_reportingPath.Text;
            App.Setting.UpdateUrl = txt_updateUrl.Text;
            App.Setting.AutomaticUpdate = ((UpdateVariant)cb_automaticUpdate.SelectedItem).Value;
            App.Setting.HideStartVideo = (bool)chb_hideStartVideo.IsChecked;
            App.Setting.ReportConnectionString = pb_reportConnectionString.Password;
            App.Setting.ReportBuilderPath = txt_reportBuilder.Text;

            if (FileFunctions.SaveSettings())
            {
                tbOutputMessageBox.Foreground = Brushes.Orange;
                tbOutputMessageBox.Text = Resources["savingSuccessfull"].ToString()
                    + Environment.NewLine + Resources["restartForApply"].ToString();
            }
        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            { OpenFileDialog dlg = new OpenFileDialog { DefaultExt = ".exe", Filter = "Exe files |*.exe", Title = Resources["fileOpenDescription"].ToString() };
                if (dlg.ShowDialog() == true) { txt_reportingPath.Text = dlg.FileName; }
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        private void BtnRestart_Click(object sender, RoutedEventArgs e) => MainWindow.AppRestart();
        private void BtnCheckUpdate_Click(object sender, RoutedEventArgs e) => Updater.CheckUpdate(true);
        private void BtnShowVideo_Click(object sender, RoutedEventArgs e) => new WelcomePage().Show();
        private void BtnTestConnection_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MainWindow.ProgressRing = Visibility.Visible;
                SqlConnection cnn = new SqlConnection(pb_reportConnectionString.Password);
                cnn.Open();
                if (cnn.State == System.Data.ConnectionState.Open)
                {
                    tbOutputMessageBox.Foreground = Brushes.Green;
                    tbOutputMessageBox.Text = Resources["connectionSucceed"].ToString();
                }
                else
                {
                    tbOutputMessageBox.Foreground = Brushes.Red;
                    tbOutputMessageBox.Text = cnn.ConnectionString + Environment.NewLine + Resources["connectionFail"].ToString();
                }
                cnn.Close();
                MainWindow.ProgressRing = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                tbOutputMessageBox.Foreground = Brushes.Red;
                tbOutputMessageBox.Text = pb_reportConnectionString.Password + Environment.NewLine + ex.Message;
                MainWindow.ProgressRing = Visibility.Hidden;
            }
        }

        private void BtnBrowseDesigner_Click(object sender, RoutedEventArgs e)
        {
            try {
                OpenFileDialog dlg = new OpenFileDialog { DefaultExt = ".exe", Filter = "Exe files |*.exe", Title = Resources["fileOpenDescription"].ToString() };
                if (dlg.ShowDialog() == true) { txt_reportBuilder.Text = dlg.FileName; }
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        private void BtnRun_Click(object sender, RoutedEventArgs e)
        {
            try {
                Process exeProcess = new Process();
                ProcessStartInfo info = new ProcessStartInfo()
                {
                    FileName = txt_reportBuilder.Text,
                    WorkingDirectory = Path.GetDirectoryName(txt_reportBuilder.Text) + "\\",
                    Arguments = "",
                    LoadUserProfile = true,
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Normal,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Verb = (Environment.OSVersion.Version.Major >= 6) ? "runas" : "",
                };
                exeProcess.StartInfo = info;
                exeProcess.Start();
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }
    }
}
