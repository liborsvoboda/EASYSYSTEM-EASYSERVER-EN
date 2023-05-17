using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using GlobalNET.GlobalStyles;
using HelixToolkit.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

// This is Template ListView
namespace GlobalNET.Pages {

    public partial class AttachmentListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static AttachmentListView selectedRecord = new AttachmentListView();

        public AttachmentListPage() {
            InitializeComponent();
            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            _ = LoadDataList();
            SetRecord();
        }

        //change datasource
        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            try
            {
                DgListView.ItemsSource = await ApiCommunication.GetApiRequest<List<AttachmentListView>>(ApiUrls.AttachmentList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex) {
            try
            {
                ((DataGrid)sender).Columns.ToList().ForEach(e =>
                {
                    string headername = e.Header.ToString();
                    if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                    else if (headername == "PartNumber") { e.Header = Resources["partNumber"].ToString(); }
                    else if (headername == "FileName") { e.Header = Resources["fileName"].ToString(); }
                    else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }
                    else if (headername == "Id") e.DisplayIndex = 0;
                    else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                });
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        //change filter fields
        public void Filter(string filter) {
            try
            {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) =>
                {
                    AttachmentListView user = e as AttachmentListView;
                    return user.TimeStamp.ToShortDateString().ToLower().Contains(filter.ToLower())
                    || user.FileName.ToLower().Contains(filter.ToLower());
                };
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (AttachmentListView)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord();
        }

        private async void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            try
            {
                if (DgListView.SelectedItems.Count > 0)
                {
                    selectedRecord = (AttachmentListView)DgListView.SelectedItem;
                    dataViewSupport.SelectedRecordId = selectedRecord.Id;

                    viewPort3d.IsEnabled = webViewer.IsEnabled = false;
                    viewPort3d.Visibility = webViewer.Visibility = Visibility.Hidden;

                    string filePath = Path.Combine(App.tempFolder, selectedRecord.FileName);
                    FileOperations.ByteArrayToFile(filePath, (await ApiCommunication.GetApiRequest<AttachmentList>(ApiUrls.AttachmentList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token)).Attachment);
                    switch (selectedRecord.FileName.ToLower().Split('.').Last())
                    {
                        case "stl":
                            viewPort3d.IsEnabled = true; viewPort3d.Visibility = Visibility.Visible; //viewPort3d.Viewport.Print("");
                            ModelVisual3D device3D = new ModelVisual3D { Content = await Display3d(filePath) };
                            viewPort3d.Children.Add(device3D); viewPort3d.ZoomExtents();
                            break;

                        default:
                            webViewer.IsEnabled = true; webViewer.Visibility = Visibility.Visible;
                            webViewer.Address = filePath;
                            break;
                    }
                }
                else { selectedRecord = new AttachmentListView(); }
                dataViewSupport.SelectedRecordId = selectedRecord.Id;
                SetRecord();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
        }

        //change dataset prepare for working
        private void SetRecord() {
            MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
            ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
        }

        private async Task<Model3D> Display3d(string modelPath) {
            Model3D device = null;
            try
            {
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);
                ModelImporter import = new ModelImporter();
                import.DefaultMaterial = new DiffuseMaterial(new SolidColorBrush(Color.FromRgb(255, 255, 255)));
                device = import.Load(modelPath);
            }
            catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.Message + Environment.NewLine + ex.StackTrace); }
            return device;
        }
    }
}