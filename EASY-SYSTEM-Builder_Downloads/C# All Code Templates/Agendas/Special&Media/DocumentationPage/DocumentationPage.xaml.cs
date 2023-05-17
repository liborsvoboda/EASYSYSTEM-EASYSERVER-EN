using CefSharp;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using Newtonsoft.Json;
using System;
using System.Timers;
using System.Windows;
using System.Windows.Controls;

namespace GlobalNET.Pages {

    public partial class DocumentationPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static Classes.Calendar selectedRecord = new Classes.Calendar();

        private CPUUsage CPU = new CPUUsage();
        private RAMUsage RAM = new RAMUsage();
        private Timer _timer = new Timer();

        public DocumentationPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);
            _timer.Enabled = true;
            _timer.Interval = 250;
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
            this.Loaded += UserControl_Loaded;

            webViewer.BeginInit();
            webViewer.Address = "https://liborsvoboda.github.io/EASYSYSTEM-EASYSERVER-CZ/";
            webViewer.FrameLoadStart += WebViewer_FrameLoadStart;
            webViewer.FrameLoadEnd += WebViewer_FrameLoadEnd;
            webViewer.LifeSpanHandler = new MyCustomLifeSpanHandler();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) => Dispatcher.ShutdownStarted += Dispatcher_ShutdownStarted;

        private void Dispatcher_ShutdownStarted(object sender, EventArgs e) {
            _timer.Enabled = false;
            _timer.Stop();
            _cpuDial.Sections.Clear();
            _cpuDial.Dispatcher.DisableProcessing();
        }

        private static double Clamp(double val, double min, double max) {
            if (val < min)
                return min;
            else if (val > max)
                return max;
            return val;
        }

        private double ToGBFromMBytes(Int64 bytes) {
            return (double)bytes / 1024.0;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e) {
            lock (this)
            {
                CPU.Update();
                RAM.Update();
                this.Dispatcher.Invoke(() =>
                {
                    var cpuVal = Clamp(CPU.CPU, 0.0, 100.0);
                    var ramVal = Clamp(RAM.Memory, 0.0, 100.0);

                    _cpuDial.Value = cpuVal;
                    _ramDial.Value = ramVal;

                    _cpuLabel.Content = string.Format("CPU {0} %", cpuVal.ToString("N2"));
                    _ramLabel.Content = string.Format("RAM {0}/{1} GB", ToGBFromMBytes(RAM.UsedBytes).ToString("N2"), ToGBFromMBytes(RAM.TotalBytes).ToString("N2"));
                });
            }
        }

        private void WebViewer_FrameLoadStart(object sender, FrameLoadStartEventArgs e) {
            MainWindow.ProgressRing = Visibility.Visible;
        }

        private void WebViewer_FrameLoadEnd(object sender, FrameLoadEndEventArgs e) {
            MainWindow.ProgressRing = Visibility.Hidden;
        }

        private class MyCustomLifeSpanHandler : ILifeSpanHandler {

            public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser) {
                return true;
            }

            public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser) {
            }

            public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser) {
            }

            /// <summary>
            /// Block open New Solo Window Frame as popup
            /// </summary>
            /// <param name="chromiumWebBrowser"></param>
            /// <param name="browser"></param>
            /// <param name="frame"></param>
            /// <param name="targetUrl"></param>
            /// <param name="targetFrameName"></param>
            /// <param name="targetDisposition"></param>
            /// <param name="userGesture"></param>
            /// <param name="popupFeatures"></param>
            /// <param name="windowInfo"></param>
            /// <param name="browserSettings"></param>
            /// <param name="noJavascriptAccess"></param>
            /// <param name="newBrowser"></param>
            /// <returns></returns>
            public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser) {
                browser.MainFrame.LoadUrl(targetUrl);
                newBrowser = null;
                return true;
            }
        }
    }
}