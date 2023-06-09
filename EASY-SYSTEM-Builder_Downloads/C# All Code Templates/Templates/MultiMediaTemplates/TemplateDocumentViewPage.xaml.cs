﻿using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Controls;

namespace GlobalNET.Pages {

    /// <summary>
    /// Template Page For View document, pictures, text and and much more file formats opened in WebViewer
    /// </summary>
    public partial class TemplateDocumentViewPage : UserControl {

        /// <summary>
        /// Standartized declaring static page data for global vorking with pages
        /// </summary>
        public static DataViewSupport dataViewSupport = new DataViewSupport();

        public static TemplateClassList selectedRecord = new TemplateClassList();

        /// <summary>
        /// Initialize page with loading Dictionary and direct show example file
        /// </summary>
        public TemplateDocumentViewPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);
            webViewer.Address = Path.Combine(App.startupPath, "Data", "xpsDocument.xps");
            //dv_docuentViewer.Document = new XpsDocument(Path.Combine(App.startupPath, "Data", "xpsDocument.xps"), FileAccess.Read).GetFixedDocumentSequence();
        }
    }
}