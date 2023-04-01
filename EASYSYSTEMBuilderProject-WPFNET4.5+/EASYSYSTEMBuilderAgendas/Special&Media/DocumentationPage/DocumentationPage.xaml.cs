using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GlobalNET.GlobalFunctions;
using System.ComponentModel;
using Prism.Ioc;
using Prism.Regions;
using System.Windows.Markup;
using System.Windows.Input;
using MahApps.Metro.Controls;
using System.Timers;
using System.IO;

namespace GlobalNET.Pages
{
    public partial class DocumentationPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static Classes.Calendar selectedRecord = new Classes.Calendar();

        private CPUUsage CPU = new CPUUsage();
        private RAMUsage RAM = new RAMUsage();
        private Timer _timer = new Timer();
       
        public DocumentationPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);
            _timer.Enabled = true;
            _timer.Interval = 250;
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
            this.Loaded += UserControl_Loaded;

            webViewer.Address = "https://liborsvoboda.github.io/EASYSYSTEM-EASYSERVER-CZ/";
            webViewer.FrameLoadStart += WebViewer_FrameLoadStart;
            webViewer.FrameLoadEnd += WebViewer_FrameLoadEnd;
        }

        void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Closing += window_Closing;
        }

        void window_Closing(object sender, global::System.ComponentModel.CancelEventArgs e)
        {
            StopTimerOnShutdown();
        }

        internal void StopTimerOnShutdown()
        {
            _timer.Enabled = false;
            _timer.Stop();
        }

        private static double Clamp(double val, double min, double max)
        {
            if (val < min)
                return min;
            else if (val > max)
                return max;
            return val;
        }

        private double ToGBFromMBytes(Int64 bytes)
        {
            return (double)bytes / 1024.0;
        }

        private static Action EmptyDelegate = delegate () { };
        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
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

        private void WebViewer_FrameLoadStart(object sender, CefSharp.FrameLoadStartEventArgs e)
        {
            MainWindow.ProgressRing = System.Windows.Visibility.Visible;
        }

        private void WebViewer_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
            MainWindow.ProgressRing = System.Windows.Visibility.Hidden;
        }
    }
}
