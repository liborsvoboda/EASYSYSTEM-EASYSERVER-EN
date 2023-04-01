using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Web;
using Microsoft.Win32;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;
using System.IO;
using GlobalNET;
using HelixToolkit.Wpf;
using System.Threading.Tasks;
using System.Windows.Xps.Packaging;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;
using GlobalNET.GlobalStyles;
using MahApps.Metro.Controls.Dialogs;
using System.Net;

namespace GlobalNET.Pages
{
    public partial class ItemListPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ItemList selectedRecord = new ItemList();

        private List<UnitList> UnitList = new List<UnitList>();
        private List<CurrencyList> CurrencyList = new List<CurrencyList>();
        private List<VatList> VatList = new List<VatList>();
        private List<AttachmentList> AttachmentList = new List<AttachmentList>();

        private string itemVatPriceFormat = "N2";
        
        public ItemListPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //translate fields in detail form
            lbl_id.Content = Resources["id"].ToString();
            lbl_partNumber.Content = Resources["identifier"].ToString();
            lbl_name.Content = Resources["fname"].ToString();
            lbl_description.Content = Resources["description"].ToString();
            lbl_unit.Content = Resources["unit"].ToString();
            lbl_price.Content = Resources["price"].ToString();
            lbl_currency.Content = Resources["currency"].ToString();
            lbl_vat.Content = Resources["vat"].ToString();
            lbl_active.Content = Resources["active"].ToString();
            lbl_attachments.Content = Resources["attachments"].ToString();
            lbl_priceWithVat.Content = Resources["priceWithVat"].ToString();

            btn_delete.Content = Resources["delete"].ToString();
            btn_browse.Content = Resources["browse"].ToString();
            btn_export.Content = Resources["export"].ToString();
            btn_save.Content = Resources["btn_save"].ToString();
            btn_cancel.Content = Resources["btn_cancel"].ToString();

            itemVatPriceFormat = SystemFunctions.ParameterCheck("ItemVatPriceFormat");
            _ = LoadDataList();
            SetRecord(false);
        }

        //change datasource
        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;

            try
            {
                cb_unit.ItemsSource = UnitList = await ApiCommunication.GetApiRequest<List<UnitList>>(ApiUrls.GlobalNETUnitList, null, App.UserData.Authentification.Token);
                cb_currency.ItemsSource = CurrencyList = await ApiCommunication.GetApiRequest<List<CurrencyList>>(ApiUrls.GlobalNETCurrencyList, null, App.UserData.Authentification.Token); 
                cb_vat.ItemsSource = VatList = await ApiCommunication.GetApiRequest<List<VatList>>(ApiUrls.GlobalNETVatList, null, App.UserData.Authentification.Token);

                List<ItemList> itemList = new List<ItemList>(); List<ExtendedItemList> extendedItemList = new List<ExtendedItemList>();
                if (MainWindow.serviceRunning)
                    DgListView.ItemsSource = itemList = await ApiCommunication.GetApiRequest<List<ItemList>>(ApiUrls.GlobalNETItemList, (dataViewSupport.AdvancedFilter == null) ? null : "Filter/" + WebUtility.UrlEncode(dataViewSupport.AdvancedFilter.Replace("[!]", "").Replace("{!}", "")), App.UserData.Authentification.Token);

                itemList.ForEach(record => {
                    ExtendedItemList item = new ExtendedItemList()
                    {
                        Id = record.Id,
                        PartNumber = record.PartNumber,
                        Name = record.Name,
                        Description = record.Description,
                        Unit = record.Unit,
                        Price = record.Price,
                        VatId = record.VatId,
                        CurrencyId = record.CurrencyId,
                        UserId = record.UserId,
                        Active = record.Active,
                        TimeStamp = record.TimeStamp,
                        Vat = VatList.Where(a => a.Id == record.VatId).Select(a => a.Value).FirstOrDefault().ToString(),
                        Currency = CurrencyList.Where(a => a.Id == record.CurrencyId).Select(a => a.Name).FirstOrDefault().ToString()
                    }; extendedItemList.Add(item);
                });

                DgListView.ItemsSource = extendedItemList;
                DgListView.Items.Refresh();

            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}

            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }


        // set translate columns in listView
        private void DgListView_Translate(object sender, EventArgs ex)
        {
            ((DataGrid)sender).Columns.ToList().ForEach(e =>
            {
                string headername = e.Header.ToString();
                if (headername == "PartNumber") e.Header = Resources["identifier"].ToString();
                else if (headername == "Name") e.Header = Resources["fname"].ToString();
                else if (headername == "Description") e.Header = Resources["description"].ToString();
                else if (headername == "Unit") { e.Header = Resources["unit"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Price") { e.Header = Resources["price"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; }
                else if (headername == "Currency") { e.Header = Resources["currency"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 4; }
                else if (headername == "Vat") { e.Header = Resources["vat"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 3; }
                else if (headername == "Active") { e.Header = Resources["active"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 2; }
                else if (headername == "Timestamp") { e.Header = Resources["timestamp"].ToString(); e.CellStyle = DatagridStyles.gridTextRightAligment; e.DisplayIndex = DgListView.Columns.Count - 1; }

                else if (headername == "Id") e.DisplayIndex = 0;
                else if (headername == "UserId") e.Visibility = Visibility.Hidden;
                else if (headername == "CurrencyId") e.Visibility = Visibility.Hidden;
                else if (headername == "VatId") e.Visibility = Visibility.Hidden;
            });
        }

        //change filter fields
        public void Filter(string filter)
        {
            try {
                if (filter.Length == 0) { dataViewSupport.FilteredValue = null; DgListView.Items.Filter = null; return; }
                dataViewSupport.FilteredValue = filter;
                DgListView.Items.Filter = (e) => {
                    ItemList user = e as ItemList;
                    return user.PartNumber.ToLower().Contains(filter.ToLower())
                    || user.Name.ToLower().Contains(filter.ToLower())
                    || !string.IsNullOrEmpty(user.Description) && user.Description.ToLower().Contains(filter.ToLower())
                    || user.Unit.ToLower().Contains(filter.ToLower());
                };
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        public void NewRecord()
        {
            selectedRecord = new ItemList();
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        public void EditRecord(bool copy)
        {
            selectedRecord = (ItemList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true, copy);
        }

        public async void DeleteRecord()
        {
            selectedRecord = (ItemList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            MessageDialogResult result = await MainWindow.ShowMessage(false, Resources["deleteRecordQuestion"].ToString() + " " + selectedRecord.Id.ToString(), true);
            if (result == MessageDialogResult.Affirmative)
            {
                DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETItemList, selectedRecord.Id.ToString(), App.UserData.Authentification.Token);
                if (dBResult.recordCount == 0) await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
                _ = LoadDataList(); SetRecord(false);
            }
        }

        private void DgListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DgListView.SelectedItems.Count == 0) return;
            selectedRecord = (ItemList)DgListView.SelectedItem;
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(true);
        }

        private void DgListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgListView.SelectedItems.Count > 0)
            {
                selectedRecord = (ItemList)DgListView.SelectedItem;
            } else
            {
                selectedRecord = new ItemList();
            }
            dataViewSupport.SelectedRecordId = selectedRecord.Id;
            SetRecord(false);
        }

        //change dataset save method
        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.progressRing = Visibility.Visible;
                DBResultMessage dBResult;
                selectedRecord.Id = (int)((txt_id.Value != null) ? txt_id.Value : 0);
                selectedRecord.PartNumber = txt_partNumber.Text;
                selectedRecord.Name = txt_name.Text;
                selectedRecord.Description = txt_description.Text;
                selectedRecord.Unit = ((UnitList)cb_unit.SelectedItem).Name;
                selectedRecord.Price = (decimal)txt_price.Value;
                selectedRecord.CurrencyId = ((CurrencyList)cb_currency.SelectedItem).Id;
                selectedRecord.VatId = ((VatList)cb_vat.SelectedItem).Id;
                selectedRecord.Active = (bool)chb_active.IsChecked;
                selectedRecord.UserId = App.UserData.Authentification.Id;
                selectedRecord.TimeStamp = DateTimeOffset.Now.DateTime;



                string json = JsonConvert.SerializeObject(selectedRecord);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                if (selectedRecord.Id == 0)
                { dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETItemList, httpContent, null, App.UserData.Authentification.Token);
                } else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETItemList, httpContent, null, App.UserData.Authentification.Token); }

                if (dBResult.recordCount > 0)
                {
                    //Replace Attachments
                    AttachmentList.ForEach(attachment => { attachment.ParentId = dBResult.insertedId; attachment.Id = 0; });
                    dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.GlobalNETAttachmentList, "ITEM/" + selectedRecord.Id, App.UserData.Authentification.Token);
                    json = JsonConvert.SerializeObject(AttachmentList); httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    dBResult = await ApiCommunication.PutApiRequest(ApiUrls.GlobalNETAttachmentList, httpContent, null, App.UserData.Authentification.Token);
                    if (dBResult.recordCount != AttachmentList.Count()) { await MainWindow.ShowMessage(true, Resources["attachmentDBError"].ToString() + Environment.NewLine + dBResult.ErrorMessage); }
                    else
                    {
                        selectedRecord = new ItemList();
                        await LoadDataList();
                        SetRecord(false);
                    }
                } else { await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage); }
            }
            catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
            finally { MainWindow.progressRing = Visibility.Hidden; }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            selectedRecord = (DgListView.SelectedItems.Count > 0) ? (ItemList)DgListView.SelectedItem : new ItemList();
            SetRecord(false);
        }

        //change dataset prepare for working
        private async void SetRecord(bool showForm, bool copy = false)
        {
            SetSubListsNonActiveOnNewItem(selectedRecord.Id == 0);
            tv_attachments.Items.Clear(); AttachmentList.Clear();

            txt_id.Value = (copy) ? 0 : selectedRecord.Id;
            txt_partNumber.Text = selectedRecord.PartNumber;
            txt_name.Text = selectedRecord.Name;
            txt_description.Text = selectedRecord.Description;
            cb_unit.Text = selectedRecord.Unit;
            txt_price.Value = (double)selectedRecord.Price;
            cb_currency.Text = CurrencyList.Where(x => x.Id == selectedRecord.CurrencyId).Select(a => a.Name).FirstOrDefault();
            cb_vat.Text = VatList.Where(x => x.Id == selectedRecord.VatId).Select(a => a.Name).FirstOrDefault();
            chb_active.IsChecked = (selectedRecord.Id == 0) ? App.Setting.ActiveNewInputDefault : selectedRecord.Active;

            if (selectedRecord.Id > 0 && showForm) {
                tv_attachments.Items.Clear();
                AttachmentList = await ApiCommunication.GetApiRequest<List<AttachmentList>>(ApiUrls.GlobalNETAttachmentList, "ITEM/" + selectedRecord.Id, App.UserData.Authentification.Token);
                AttachmentList.ForEach(attachment => {
                    TreeViewItem attachmentItem = new TreeViewItem() { Header = attachment.FileName, Tag = attachment.FileName.Split('.').Last(), HorizontalAlignment = HorizontalAlignment.Stretch, HorizontalContentAlignment = HorizontalAlignment.Center };
                    attachmentItem.Selected += AttachmentItem_Selected;
                    tv_attachments.Items.Add(attachmentItem);
                });
            }

            if (showForm) {
                HideAttachmentSection();
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = false;
                ListView.Visibility = Visibility.Hidden; ListForm.Visibility = Visibility.Visible; dataViewSupport.FormShown = true;
                if (CurrencyList.Where(a => a.Default).Count() == 1 && cb_currency.Text == null) { cb_currency.Text = CurrencyList.First(a => a.Default).Name; }
                if (UnitList.Where(a => a.Default).Count() == 1 && cb_unit.Text == null) { cb_unit.Text = UnitList.First(a => a.Default).Name; }
                if (VatList.Where(a => a.Default).Count() == 1 && cb_vat.Text == null) { cb_vat.Text = VatList.First(a => a.Default).Name; }
            }
            else {
                MainWindow.DataGridSelected = true; MainWindow.DataGridSelectedIdListIndicator = selectedRecord.Id != 0; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
                ListForm.Visibility = Visibility.Hidden; ListView.Visibility = Visibility.Visible; dataViewSupport.FormShown = false;
            }
        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog { DefaultExt = ".*", Filter = "Supported files |*.*;", Title = Resources["fileOpenDescription"].ToString() };
                if (dlg.ShowDialog() == true)
                {
                    if (AttachmentList.Where(a => a.FileName == dlg.SafeFileName).Count() == 0) {
                        AttachmentList.Add(new AttachmentList()
                        {
                            ParentId = 0,
                            ParentType = "ITEM",
                            FileName = dlg.SafeFileName,
                            Attachment = File.ReadAllBytes(dlg.FileName),
                            UserId = App.UserData.Authentification.Id,
                            TimeStamp = DateTimeOffset.Now.DateTime
                        });
                    }
                    TreeViewItem attachmentItem = new TreeViewItem() { Header = dlg.SafeFileName, Tag = dlg.FileName.Split('.').Last(), HorizontalAlignment = HorizontalAlignment.Stretch, HorizontalContentAlignment = HorizontalAlignment.Center };
                    attachmentItem.Selected += AttachmentItem_Selected;
                    tv_attachments.Items.Add(attachmentItem);
                }
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        private async void AttachmentItem_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                btn_delete.IsEnabled = true; btn_export.IsEnabled = true;
                viewPort3d.IsEnabled = webViewer.IsEnabled = false;
                viewPort3d.Visibility = webViewer.Visibility = Visibility.Hidden;

                TreeViewItem attachmentItem = (TreeViewItem)sender;
                string filePath = Path.Combine(App.tempFolder, attachmentItem.Header.ToString());
                FileFunctions.ByteArrayToFile(filePath, AttachmentList.Where(a => a.FileName == attachmentItem.Header.ToString()).First().Attachment);
                switch (((TreeViewItem)sender).Tag.ToString().ToLower())
                {
                    case "stl":
                        viewPort3d.IsEnabled = true; viewPort3d.Visibility = Visibility.Visible; //viewPort3d.Viewport.Print("");
                        ModelVisual3D device3D = new ModelVisual3D { Content = await Display3d(filePath) };
                        viewPort3d.Children.Add(device3D); viewPort3d.ZoomExtents();
                        break;
                    default:
                        webViewer.IsEnabled = true; webViewer.Visibility = Visibility.Visible;
                        webViewer.Source = new Uri(filePath);
                        break;
                }
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        private void HideAttachmentSection()
        {
            btn_delete.IsEnabled = true; btn_export.IsEnabled = true;
            viewPort3d.IsEnabled = webViewer.IsEnabled = false;
            viewPort3d.Visibility = webViewer.Visibility = Visibility.Hidden;
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            try
            { string fileName = ((TreeViewItem)tv_attachments.SelectedValue).Header.ToString();
                SaveFileDialog dlg = new SaveFileDialog
                { DefaultExt = ".*", Filter = "Supported files |*.*;", Title = Resources["fileOpenDescription"].ToString(), FileName = fileName };
                if (dlg.ShowDialog() == true) { FileFunctions.ByteArrayToFile(dlg.FileName, AttachmentList.Where(a => a.FileName == fileName).First().Attachment); }
            } catch (Exception autoEx) {SystemFunctions.SaveSystemFailMessage(SystemFunctions.GetExceptionMessages(autoEx));}
        }

        private async Task<Model3D> Display3d(string modelPath)
        {
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

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            AttachmentList.Remove(AttachmentList.Where(a => a.FileName == ((TreeViewItem)tv_attachments.SelectedValue).Header.ToString()).First());
            tv_attachments.Items.Remove(tv_attachments.SelectedItem);
            if (tv_attachments.SelectedItem == null) btn_delete.IsEnabled = btn_export.IsEnabled = false;
        }

        
        private void PriceVatChanged(object sender, SelectionChangedEventArgs e) => PriceChanged();
        private void PriceCurrencyChanged(object sender, SelectionChangedEventArgs e) => PriceChanged();
        private void PriceValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e) => PriceChanged();
        private void PriceChanged()
        {
            try
            {
                val_priceWithVat.Content = ((double)(txt_price.Value + txt_price.Value * (double)VatList.First(x => x.Id == selectedRecord.VatId).Value)).ToString(itemVatPriceFormat) + " " + ((CurrencyList)cb_currency.SelectedItem).Name;
            } catch { val_priceWithVat.Content = string.Empty ; }
        }

        private void SetSubListsNonActiveOnNewItem(bool newItem)
        {
            if (newItem) {
                cb_unit.ItemsSource = UnitList.Where(a => a.Active).ToList();
                cb_currency.ItemsSource = CurrencyList.Where(a => a.Active).ToList();
                cb_vat.ItemsSource = VatList.Where(a => a.Active).ToList();
            }
            else { cb_unit.ItemsSource = UnitList; cb_currency.ItemsSource = CurrencyList; cb_vat.ItemsSource = VatList; }
        }

    }
}