using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Windows.Controls;
using System.IO;
using System.Windows.Xps.Packaging;
using GlobalNET.GlobalFunctions;


namespace GlobalNET.Pages
{
    /// <summary>
    /// Template Page For internet pages document, pictures, text and and much more file formats opened in WebViewer
    /// </summary>
    public partial class TemplateWebViewPage : UserControl
    {
        /// <summary>
        /// Standartized declaring static page data for global vorking with pages 
        /// </summary>
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static TemplateClassList selectedRecord = new TemplateClassList();

        /// <summary>
        /// Initialize page with loading Dictionary and direct show example file
        /// </summary>
        public TemplateWebViewPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            webViewer.Address = Path.Combine("https://GroupWare-Solution.Eu");
            webViewer.FrameLoadStart += WebViewer_FrameLoadStart;
            webViewer.FrameLoadEnd += WebViewer_FrameLoadEnd;

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