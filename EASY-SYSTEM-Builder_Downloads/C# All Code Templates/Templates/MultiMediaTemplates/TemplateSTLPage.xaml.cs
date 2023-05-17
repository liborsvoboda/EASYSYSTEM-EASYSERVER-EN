using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using HelixToolkit.Wpf;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D;

/// This is Template Is Customized For Show 3D STL Object
namespace GlobalNET.Pages {

    public partial class TemplateSTLPage : UserControl {

        /// <summary>
        /// Standartized declaring static page data for global vorking with pages
        /// </summary>
        public static DataViewSupport dataViewSupport = new DataViewSupport();

        public static TemplateClassList selectedRecord = new TemplateClassList();

        public TemplateSTLPage() {
            InitializeComponent();
            Language defaultLanguage = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage);
            _ = SystemOperations.SetLanguageDictionary(Resources, defaultLanguage.Value);

            ModelVisual3D device3D = new ModelVisual3D();
            device3D.Content = Display3d(Path.Combine(App.startupPath, "Data", "Track.stl")).GetAwaiter().GetResult();
            viewPort3d.Children.Add(device3D);
        }

        private async Task<Model3D> Display3d(string model) {
            Model3D device = null;
            try
            {
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);
                ModelImporter import = new ModelImporter();
                device = import.Load(model);
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.Message + Environment.NewLine + ex.StackTrace); }
            return device;
        }

        #region helper methods

        private class ExtensionsItem {

            public ExtensionsItem() {
                ident = null;
                isTrue = false;
                asn1OctetString = null;
            }

            public DerObjectIdentifier ident { get; set; }
            public bool isTrue { get; set; }
            public Asn1OctetString asn1OctetString { get; set; }
        }

        #endregion helper methods
    }
}