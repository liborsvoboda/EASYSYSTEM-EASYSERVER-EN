using CefSharp;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Controls;

namespace GlobalNET.Pages {

    /// <summary>
    /// Template Page For internet pages document, pictures, text and and much more file formats opened in WebViewer
    /// </summary>
    public partial class TemplateWebViewPage : UserControl {

        /// <summary>
        /// Standartized declaring static page data for global vorking with pages
        /// </summary>
        public static DataViewSupport dataViewSupport = new DataViewSupport();

        public static TemplateClassList selectedRecord = new TemplateClassList();

        /// <summary>
        /// Initialize page with loading Dictionary and direct show example file
        /// </summary>
        public TemplateWebViewPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            webViewer.Address = Path.Combine("https://GroupWare-Solution.Eu");
            webViewer.FrameLoadStart += WebViewer_FrameLoadStart;
            webViewer.FrameLoadEnd += WebViewer_FrameLoadEnd;
            webViewer.LifeSpanHandler = new MyCustomLifeSpanHandler();
        }

        private void WebViewer_FrameLoadStart(object sender, FrameLoadStartEventArgs e) {
            MainWindow.ProgressRing = System.Windows.Visibility.Visible;
        }

        private void WebViewer_FrameLoadEnd(object sender, FrameLoadEndEventArgs e) {
            MainWindow.ProgressRing = System.Windows.Visibility.Hidden;
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