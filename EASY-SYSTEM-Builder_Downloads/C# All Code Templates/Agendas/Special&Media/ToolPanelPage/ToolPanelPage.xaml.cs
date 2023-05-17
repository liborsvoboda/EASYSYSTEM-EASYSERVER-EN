using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;

namespace GlobalNET.Pages {

    public partial class ToolPanelPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static Classes.Calendar selectedRecord = new Classes.Calendar();

        public ToolPanelPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            t_rpdClient.Title = Resources["rpdClient"].ToString();
            t_webDocumentation.Title = Resources["webDocumentation"].ToString();
            t_githubCodes.Title = Resources["githubCodes"].ToString();
            t_reportDesigner.Title = Resources["reportDesigner"].ToString();

            //_ = LoadDataList();
        }

        private void WebDocOpenClick(object sender, RoutedEventArgs e) {
            Process.Start("https://liborsvoboda.github.io/EASYSYSTEM-EASYSERVER-CZ/");
        }

        private void RdpClientOpenClick(object sender, RoutedEventArgs e) {
            if (FileOperations.CheckFile(Path.Combine(App.startupPath, "Data", "AddOn", "winvnc.exe")))
            {
                try
                {
                    var vncProccess = new Process();
                    ProcessStartInfo info = new ProcessStartInfo()
                    {
                        FileName = Path.Combine(App.startupPath, "Data", "AddOn", "RDClient.exe"),
                        WorkingDirectory = Path.Combine(App.startupPath, "Data", "AddOn"),
                        Arguments = "",
                        LoadUserProfile = true,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        Verb = (Environment.OSVersion.Version.Major >= 6) ? "runas" : "",
                    };
                    vncProccess.StartInfo = info;
                    vncProccess.Start();
                }
                catch { }
            }
        }

        private void GitHubCodesClick(object sender, RoutedEventArgs e) {
            Process.Start("https://github.com/liborsvoboda/EASYSYSTEM-EASYSERVER-CZ");
        }

        private void ReportDesignerOpenClick(object sender, RoutedEventArgs e) {
            Process.Start(App.Setting.ReportBuilderPath);
        }

        private void ServerApiDocsOpenClick(object sender, RoutedEventArgs e) {
            Process.Start("http://kliknetezde.cz:5000/AdminApiDocs");
        }

        private void WebPageOpenClick(object sender, RoutedEventArgs e) {
            Process.Start("https://groupware-solution.eu");
        }

        private void GitHubOpenClick(object sender, RoutedEventArgs e) {
            Process.Start("https://github.com/liborsvoboda");
        }

        private void TerminalOpenClick(object sender, RoutedEventArgs e) {
        }

        private void CustomBackendSrvWebToolClick(object sender, RoutedEventArgs e) {
            Process.Start("http://kliknetezde.cz:5000");
        }

        private async void ComputerInfoClick(object sender, RoutedEventArgs e) {
            string message = nameof(Environment.MachineName) + ": " + Environment.MachineName + Environment.NewLine +
                nameof(Environment.OSVersion) + ": " + Environment.OSVersion + Environment.NewLine +
                nameof(Environment.ProcessorCount) + ": " + Environment.ProcessorCount + Environment.NewLine +
                nameof(Environment.UserName) + ": " + Environment.UserName + Environment.NewLine + Environment.NewLine;

            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    message += nameof(ip) + ": " + ip.ToString() + Environment.NewLine;
                }
            }
            await MainWindow.ShowMessage(false, message, false);
        }
    }
}