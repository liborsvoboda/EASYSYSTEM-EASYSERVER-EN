using Newtonsoft.Json;
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
using MahApps.Metro.Controls;
using EASYTools.Calendar;
using System.Web.UI.WebControls;
using System.Web;
using System.Threading.Tasks;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace GlobalNET.Pages
{
    public partial class ToolPanelPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static Classes.Calendar selectedRecord = new Classes.Calendar();

        public ToolPanelPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            t_rpdClient.Title = Resources["rpdClient"].ToString();
            t_webDocumentation.Title = Resources["webDocumentation"].ToString();
            t_githubCodes.Title = Resources["githubCodes"].ToString();
            t_reportDesigner.Title = Resources["reportDesigner"].ToString();

            //_ = LoadDataList();

        }


        private void WebDocOpenClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://liborsvoboda.github.io/EASYSYSTEM-EASYSERVER-CZ/");
        }

        private void RdpClientOpenClick(object sender, RoutedEventArgs e)
        {
            if (FileFunctions.CheckFile(Path.Combine(App.startupPath, "Data", "AddOn", "winvnc.exe")))
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
                }catch{}
            }
        }

        private void GitHubCodesClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/liborsvoboda/EASYSYSTEM-EASYSERVER-CZ");
        }

        private void ReportDesignerOpenClick(object sender, RoutedEventArgs e)
        {
            Process.Start(App.Setting.ReportBuilderPath);
        }
    }
}
