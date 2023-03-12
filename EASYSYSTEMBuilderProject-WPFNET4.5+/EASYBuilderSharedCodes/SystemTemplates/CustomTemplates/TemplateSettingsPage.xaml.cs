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
using System.Web;
using Microsoft.Win32;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;

// This is Template Is Customized For Load and Save data without List (Settings) is folded from standartized Methods
namespace GlobalNET.Pages
{

    public partial class TemplateSettingsPage : UserControl
    {
        /// <summary>
        /// Define Collection For Combobox
        /// </summary>
        public ObservableCollection<Language> Languages = new ObservableCollection<Language>() {
                                                                new Language() { Name = "System", Value = "system" },
                                                                new Language() { Name = "Czech", Value = "cs-CZ" },
                                                                new Language() { Name = "English", Value = "en-US" }
                                                             };
        /// <summary>
        /// Initialize page with loading Dictionary and start loding data
        /// Manual work needed Translate All XAML fields by Resources
        /// Runned on start
        /// 
        /// </summary>
        public TemplateSettingsPage()
        {
            InitializeComponent();
            Language defaultLanguage = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage);
            _ = MediaFunctions.SetLanguageDictionary(Resources, defaultLanguage.Value);
            try { 
                lbl_apiAddress.Content = Resources["apiAddress"].ToString();
                lbl_serviceName.Content = Resources["serviceName"].ToString();
                lbl_writeToLog.Content = Resources["logging"].ToString();
                lbl_serverCheckIntervalSec.Content = Resources["serverCheckIntervalSec"].ToString();
                lbl_topMost.Content = Resources["topMost"].ToString();
                lbl_activeNewInputDefault.Content = Resources["activeNewInputDefault"].ToString();
                lbl_defaultLanguage.Content = Resources["defaultLanguage"].ToString();
                lbl_showVerticalPanel.Content = Resources["showVerticalPanel"].ToString();
                lbl_powerBuilderPath.Content = Resources["powerBuilderPath"].ToString();

                btn_browse.Content = Resources["browse"].ToString();
                btn_restart.Content = Resources["restart"].ToString();
                btn_save.Content = Resources["btn_save"].ToString();
                btnApiTest.Content = Resources["apiConnectionTest"].ToString();
            } catch { }

            //data
            txt_apiAddress.Text = App.Setting.ApiAddress;
            chb_WritetoLog.IsChecked = App.Setting.WriteToLog;
            txt_serverCheckIntervalSec.Value = App.Setting.ServerCheckIntervalSec * 0.001;
            chb_topMost.IsChecked = App.Setting.TopMost;
            chb_activeNewInputDefault.IsChecked = App.Setting.ActiveNewInputDefault;
            txt_powerBuilderPath.Text = App.Setting.ReportingPath;

            cb_defaultLanguage.ItemsSource = Languages;

            int index = 0;
            cb_defaultLanguage.Items.SourceCollection.Cast<Language>().ToList().ForEach(language => { if (language.Name == defaultLanguage.Name) { cb_defaultLanguage.SelectedIndex = index; } index++; });
        }

        /// <summary>
        /// Customized GET Call 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnApiTest_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string json = await httpClient.GetStringAsync(txt_apiAddress.Text + "/" + ApiUrls.BackendCheck + "/Db");
                    await MainWindow.ShowMessage(false, json); 
                } catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.StackTrace);                 }
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


        /// <summary>
        /// Standartized method for Direct Save Record
        /// Manual work needed, set correct data set for SubRecord
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            App.Setting.ApiAddress = txt_apiAddress.Text;
            App.Setting.WriteToLog = (bool)chb_WritetoLog.IsChecked;
            App.Setting.ServerCheckIntervalSec = (double)txt_serverCheckIntervalSec.Value * 1000;
            App.Setting.TopMost = (bool)chb_topMost.IsChecked;
            App.Setting.ActiveNewInputDefault = (bool)chb_activeNewInputDefault.IsChecked;
            App.Setting.DefaultLanguage = JsonConvert.SerializeObject((Language)cb_defaultLanguage.SelectedItem);
            App.Setting.ThemeName = App.Setting.ThemeName;
            App.Setting.AccentName = App.Setting.AccentName;
            App.Setting.ReportingPath = txt_powerBuilderPath.Text;

            if (FileFunctions.SaveSettings()) { await MainWindow.ShowMessage(false, Resources["savingSuccessfull"].ToString()); }
        }


        private void ApiAddress_TextChanged(object sender, TextChangedEventArgs e) => btnApiTest.IsEnabled = txt_apiAddress.Text.Length > 0;

        private void BtnRestart_Click(object sender, RoutedEventArgs e) => MainWindow.AppRestart();
        

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog
                { DefaultExt = ".exe", Filter = "Exe files |*.exe", Title = Resources["fileOpenDescription"].ToString() };
                if (dlg.ShowDialog() == true) { txt_powerBuilderPath.Text = dlg.FileName; }
            }
            catch { }
        }
    }
}
