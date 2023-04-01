using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Org.BouncyCastle.Asn1;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Media;
using GlobalNET.Classes;
using System.Diagnostics;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalClasses;

namespace GlobalNET.Pages
{
    public partial class ServerSettingPage : UserControl
    {
        public ServerSettingPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            lbl_serviceEmail.Content = Resources["serviceEmail"].ToString();
            lbl_SMTPServer.Content = Resources["SMTPServer"].ToString();
            lbl_SMTPPort.Content = Resources["SMTPPort"].ToString();
            lbl_SMTPUserName.Content = Resources["SMTPUserName"].ToString();
            lbl_SMTPPassword.Content = Resources["SMTPPassword"].ToString();

            lbl_jwtLocalKey.Content = Resources["jwtLocalKey"].ToString();
            lbl_socketTimeoutMinutes.Content = Resources["socketTimeoutMinutes"].ToString();
            lbl_maxSocketBufferSizeKb.Content = Resources["maxSocketBufferSizeKb"].ToString();
            lbl_timeTokenValidation.Content = Resources["timeTokenValidation"].ToString();
            lbl_httpsProtocol.Content = Resources["httpsProtocol"].ToString();
            lbl_loginTimeoutMinutes.Content = Resources["loginTimeoutMinutes"].ToString();
            lbl_certificateDomain.Content = Resources["certificateDomain"].ToString();
            lbl_certificatePassword.Content = Resources["certificatePassword"].ToString();
            lbl_internalCachingEnabled.Content = Resources["internalCachingEnabled"].ToString();
            lbl_loggingCacheTimeMinutes.Content = Resources["loggingCacheTimeMinutes"].ToString();
            lbl_showApiDescription.Content = Resources["showApiDescription"].ToString();

            btn_showApi.Content = Resources["showApi"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();

            //data

            if (MainWindow.serviceRunning) LoadDataList();

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

        public void LoadDataList()
        {
            try
            {
                if (MainWindow.serviceRunning)
                {
                    txt_serviceEmail.Text = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.ServiceEmail.ToString()).Value;
                    txt_SMTPServer.Text = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPServer.ToString()).Value;
                    txt_SMTPPort.Value = double.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPPort.ToString()).Value);
                    txt_SMTPUserName.Text = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPUserName.ToString()).Value;
                    txt_SMTPPassword.Password = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPPassword.ToString()).Value;
                    txt_jwtLocalKey.Text = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.JwtLocalKey.ToString()).Value;
                    txt_socketTimeoutMinutes.Value = double.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SocketTimeoutMinutes.ToString()).Value);
                    txt_maxSocketBufferSizeKb.Value = double.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.MaxSocketBufferSizeKb.ToString()).Value);
                    chb_timeTokenValidation.IsChecked = bool.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.TimeTokenValidation.ToString()).Value);
                    chb_httpsProtocol.IsChecked = bool.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.HttpsProtocol.ToString()).Value);
                    txt_loginTimeoutMinutes.Value = double.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.LoginTimeoutMinutes.ToString()).Value);
                    txt_certificateDomain.Text = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.CertificateDomain.ToString()).Value;
                    txt_certificatePassword.Password = App.ServerSetting.Find(a => a.Key == ServerSettingKeys.CertificatePassword.ToString()).Value;
                    chb_internalCachingEnabled.IsChecked = bool.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.InternalCachingEnabled.ToString()).Value);
                    txt_loggingCacheTimeMinutes.Value = double.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.LoggingCacheTimeMinutes.ToString()).Value);
                    chb_showApiDescription.IsChecked = bool.Parse(App.ServerSetting.Find(a => a.Key == ServerSettingKeys.ShowApiDescription.ToString()).Value);
                }
            }
            catch
            { }

        }


        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.ServiceEmail.ToString()).Value = txt_serviceEmail.Text;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPServer.ToString()).Value = txt_SMTPServer.Text;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPPort.ToString()).Value = txt_SMTPPort.Value.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPUserName.ToString()).Value = txt_SMTPUserName.Text;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SMTPPassword.ToString()).Value = txt_SMTPPassword.Password;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.JwtLocalKey.ToString()).Value = txt_jwtLocalKey.Text;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.SocketTimeoutMinutes.ToString()).Value = txt_socketTimeoutMinutes.Value.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.MaxSocketBufferSizeKb.ToString()).Value = txt_maxSocketBufferSizeKb.Value.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.TimeTokenValidation.ToString()).Value = chb_timeTokenValidation.IsChecked.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.HttpsProtocol.ToString()).Value = chb_httpsProtocol.IsChecked.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.LoginTimeoutMinutes.ToString()).Value = txt_loginTimeoutMinutes.Value.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.CertificateDomain.ToString()).Value = txt_certificateDomain.Text;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.CertificatePassword.ToString()).Value = txt_certificatePassword.Password;
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.InternalCachingEnabled.ToString()).Value = chb_internalCachingEnabled.IsChecked.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.LoggingCacheTimeMinutes.ToString()).Value = txt_loggingCacheTimeMinutes.Value.ToString();
            App.ServerSetting.Find(a => a.Key == ServerSettingKeys.ShowApiDescription.ToString()).Value = chb_showApiDescription.IsChecked.ToString();

            string json = JsonConvert.SerializeObject(App.ServerSetting);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            DBResultMessage dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETServerSetting, httpContent, null, App.UserData.Authentification.Token);
            if (dBResult.recordCount > 0) {await MainWindow.ShowMessage(false, Resources["savingSuccessfull"].ToString()); }
            else {await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
        }

        private void BtnShowApi_Click(object sender, RoutedEventArgs e) => Process.Start(App.Setting.ApiAddress + "/swagger");
    }
}
