using EASYTools.ImageEffectLibrary;
using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalClasses;
using GlobalNET.GlobalOperations;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GlobalNET.Pages {

    public partial class ImageGalleryListPage : UserControl {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static ImageGalleryList selectedRecord = new ImageGalleryList();

        private List<ImageGalleryList> ImageGalleryList = new List<ImageGalleryList>();

        public PhotoCollection Photos = new PhotoCollection();
        private ImageHelper ClonedSelectedImage = new ImageHelper();

        public ImageGalleryListPage() {
            InitializeComponent();

            _ = SystemOperations.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            //mi_server.Header = Resources["server"].ToString();
            //mi_loadFromServer.Header = Resources["loadFromServer"].ToString();
            //mi_saveToServer.Header = Resources["saveToServer"].ToString();
            //mi_cleanLocalStorage.Header = Resources["cleanLocalStorage"].ToString();

            mi_images.Header = Resources["images"].ToString();
            lbl_default.Content = Resources["default"].ToString();
            mi_insertNew.Header = Resources["insertNew"].ToString();
            mi_deleteSelected.Header = Resources["deleteSelected"].ToString();
            mi_imageFace.Header = Resources["imageFace"].ToString();
            mi_imageColor.Header = Resources["imageColor"].ToString();
            mi_imageInfo.Header = Resources["imageInfo"].ToString();

            gd_Photos.DataContext = Photos;
            PhotosListBox.ItemsSource = Photos;

            _ = LoadDataList();
            SetRecord();
        }

        public async Task<bool> LoadDataList() {
            MainWindow.ProgressRing = Visibility.Visible;
            this.PhotosListBox.InputBindings.Clear();
            try
            {
                await LoadFromServer();
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        /// <summary>
        /// Last proccess
        /// </summary>
        /// <returns></returns>
        private async Task<bool> LoadFromServer(int selectedPhotoId = 0) {
            MainWindow.ProgressRing = Visibility.Visible;
            try
            {
                ImageGalleryList = await ApiCommunication.GetApiRequest<List<ImageGalleryList>>(ApiUrls.ImageGalleryList, null, App.UserData.Authentification.Token);

                ClearGallery();
                ImageGalleryList.ForEach(item =>
                {
                    try { FileOperations.ByteArrayToFile(Path.Combine(App.galleryFolder, item.FileName), item.Attachment); } catch { }
                    Photos.Add(Path.Combine(App.galleryFolder, item.FileName), item.Id, item.IsPrimary);
                });
                RefreshViewPhoto(selectedPhotoId);
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        //change dataset prepare for working
        private void SetRecord() {
            MainWindow.DataGridSelected = false; MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = selectedRecord.Id; MainWindow.DgRefresh = true;
            dataViewSupport.FormShown = false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="selectedPhotoId" >selectedPhotoId -1 is Select Last</param>
        private async void RefreshViewPhoto(int? selectedPhotoId = 0) {
            if (selectedPhotoId != 0)
            { PhotosListBox.SelectedItem = Photos.First(x => (selectedPhotoId > 0 && x.DbId == selectedPhotoId) || (selectedPhotoId == -1 && x.DbId == Photos.Max(a => a.DbId))); }

            MessageDialogResult result = new MessageDialogResult();
            if (PhotosListBox.IsEnabled && ClonedSelectedImage.Changed) result = await MainWindow.ShowMessage(false, await DBOperations.DBTranslation("YouHaveUnconfirmedImagesChanges_IgnoreIt?"), true);
            if (!ClonedSelectedImage.Changed || (ClonedSelectedImage.Changed && result == MessageDialogResult.Affirmative)) { ClonedSelectedImage = new ImageHelper(((Photo)PhotosListBox.SelectedItem).Source); SetImageChanges(false); }
            ViewedPhoto.Source = ClonedSelectedImage.EditingImage;

            if (PhotosListBox.SelectedItem == null) { PhotosListBox.SelectedItem = ViewedPhoto.Source = null; }
            SetImageControls();
        }

        //private void ImageSelectionChanged(object sender, SelectionChangedEventArgs e) => RefreshViewPhoto();
        private void PhotoListBoxSelectClick(object sender, MouseButtonEventArgs e) => RefreshViewPhoto();

        private async void LoadFromServerClick(object sender, RoutedEventArgs e) => await LoadFromServer();

        private async void SaveToServerClick(object sender, RoutedEventArgs e) => await SaveImageToServer();

        private void CleanLocalStorageClick(object sender, RoutedEventArgs e) => ClearGallery();

        /// <summary>
        /// Image Graphics Changes Controllers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageChangesCancelClick(object sender, MouseButtonEventArgs e) { ClonedSelectedImage.ResetChanges(); RefreshViewPhoto(); }

        private async void ImageChangesSaveClick(object sender, MouseButtonEventArgs e) {
            ClonedSelectedImage.SaveTo(((Photo)PhotosListBox.SelectedItem).Source);
            int selectedPhotoId = ((Photo)PhotosListBox.SelectedItem).DbId;
            await SaveImageToServer(selectedPhotoId);
            await LoadFromServer(selectedPhotoId);
        }

        /// <summary>
        /// null For Full Folder else No of dbId, 0 = new
        /// </summary>
        /// <param name="onlyThis"></param>
        /// <returns></returns>
        private async Task<bool> SaveImageToServer(int? onlyThis = null) {
            MainWindow.ProgressRing = Visibility.Visible;
            DBResultMessage dBResult;

            try
            {
                if (onlyThis == null)
                { //Saving Full Galery
                    foreach (Photo photo in Photos)
                    {
                        string fileName = Path.GetFileName(photo.Source);
                        selectedRecord = new ImageGalleryList()
                        {
                            Id = photo.DbId,
                            IsPrimary = photo.IsPrimary,
                            FileName = fileName,
                            Attachment = File.ReadAllBytes(photo.Source),
                            UserId = App.UserData.Authentification.Id,
                            TimeStamp = DateTimeOffset.Now.DateTime
                        };

                        string json = JsonConvert.SerializeObject(selectedRecord);
                        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                        if (selectedRecord.Id == 0)
                        {
                            dBResult = await ApiCommunication.PutApiRequest(ApiUrls.ImageGalleryList, httpContent, null, App.UserData.Authentification.Token);
                        }
                        else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.ImageGalleryList, httpContent, null, App.UserData.Authentification.Token); }

                        if (dBResult.recordCount > 0) { }
                        else { await MainWindow.ShowMessage(false, "Exception Error : " + dBResult.ErrorMessage); }
                    }
                }
                else
                {  // Save Last image only
                    Photo selectedPhoto = Photos.First(a => a.DbId == onlyThis);
                    selectedRecord = new ImageGalleryList()
                    {
                        Id = selectedPhoto.DbId,
                        IsPrimary = selectedPhoto.IsPrimary,
                        FileName = Path.GetFileName(selectedPhoto.Source),
                        Attachment = File.ReadAllBytes(selectedPhoto.Source),
                        UserId = App.UserData.Authentification.Id,
                        TimeStamp = DateTimeOffset.Now.DateTime
                    };

                    string json = JsonConvert.SerializeObject(selectedRecord);
                    StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    if (selectedRecord.Id == 0)
                    {
                        dBResult = await ApiCommunication.PutApiRequest(ApiUrls.ImageGalleryList, httpContent, null, App.UserData.Authentification.Token);
                    }
                    else { dBResult = await ApiCommunication.PostApiRequest(ApiUrls.ImageGalleryList, httpContent, null, App.UserData.Authentification.Token); }

                    if (dBResult.recordCount > 0) { }
                    else { await MainWindow.ShowMessage(false, "Exception Error : " + dBResult.ErrorMessage); return false; }
                }
            }
            catch (Exception autoEx) { App.ApplicationLogging(autoEx); return false; }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        private async void InsertNewClick(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg; *.jpeg; *.png; *.tiff; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                if (!MimeMapping.GetMimeMapping(openFileDialog.FileName).StartsWith("image/")) { await MainWindow.ShowMessage(false, await DBOperations.DBTranslation("fileisNotImage")); }
                else
                {
                    try { FileOperations.CopyFile(openFileDialog.FileName, Path.Combine(App.galleryFolder, openFileDialog.SafeFileName)); } catch { }
                    Photos.Add(openFileDialog.FileName, 0, false);
                    await SaveImageToServer(0);
                    await LoadFromServer(-1);
                }
            }
        }

        private async Task<bool> DeleteImageFromServer(int dbId) {
            MainWindow.ProgressRing = Visibility.Visible;
            DBResultMessage dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.ImageGalleryList, dbId.ToString(), App.UserData.Authentification.Token);
            MainWindow.ProgressRing = Visibility.Hidden;

            if (dBResult.recordCount > 0) { return true; }
            else { await MainWindow.ShowMessage(false, "Exception Error : " + dBResult.ErrorMessage); return false; }
        }

        private async void DeleteSelectedClick(object sender, RoutedEventArgs e) {
            if (PhotosListBox.SelectedItem != null)
            {
                Photo deletePhoto = (Photo)PhotosListBox.SelectedItem;
                await DeleteImageFromServer(deletePhoto.DbId);
                await LoadFromServer();
            }
        }

        /// <summary>
        /// Phycical clear local storage and form
        /// </summary>
        private void ClearGallery() {
            Photos.Clear(); PhotosListBox.Items.Refresh();
            PhotosListBox.SelectedItem = ViewedPhoto.Source = null;
            ClonedSelectedImage.ResetChanges();
            try { FileOperations.ClearFolder(App.galleryFolder); } catch { }
        }

        private async void IsPrimaryClick(object sender, RoutedEventArgs e) {
            int selectedPhotoId = ((Photo)PhotosListBox.SelectedItem).DbId;
            Photos.First(a => a.DbId == selectedPhotoId).IsPrimary = (bool)chb_isPrimary.IsChecked;

            await SaveImageToServer(selectedPhotoId);
            await LoadFromServer(selectedPhotoId);
        }

        private async void SelectedHotelChanged(object sender, SelectionChangedEventArgs e) {
            MessageDialogResult result = new MessageDialogResult();
            if (ClonedSelectedImage.Changed) result = await MainWindow.ShowMessage(false, await DBOperations.DBTranslation("YouHaveUnconfirmedImagesChanges_IgnoreIt?"), true);
            await LoadFromServer();
        }

        private void SetImageControls() {
            chb_isPrimary.Checked -= IsPrimaryClick; chb_isPrimary.Unchecked -= IsPrimaryClick;
            if (((Photo)PhotosListBox.SelectedItem) != null)
            {
                mi_imageFace.IsEnabled = mi_imageColor.IsEnabled = mi_imageInfo.IsEnabled = true;
                chb_isPrimary.IsEnabled = true; chb_isPrimary.IsChecked = ((Photo)PhotosListBox.SelectedItem).IsPrimary;
            }
            else { mi_imageFace.IsEnabled = mi_imageColor.IsEnabled = mi_imageInfo.IsEnabled = false; }

            if (((Photo)PhotosListBox.SelectedItem) == null) { chb_isPrimary.IsEnabled = false; chb_isPrimary.IsChecked = false; }
            chb_isPrimary.Checked += IsPrimaryClick; chb_isPrimary.Unchecked += IsPrimaryClick;
        }

        private void SetImageChanges(bool imageChanged) {
            if (imageChanged)
            {
                dp_imageChanges.Visibility = Visibility.Visible; PhotosListBox.IsEnabled = false;
                chb_isPrimary.Checked -= IsPrimaryClick; chb_isPrimary.Unchecked -= IsPrimaryClick;
                mi_images.IsEnabled = false;
            }
            else { dp_imageChanges.Visibility = Visibility.Hidden; mi_images.IsEnabled = PhotosListBox.IsEnabled = true; }
        }

        /// <summary>
        /// Images Effect Part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrayscaleClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.ConvertToGrayscale(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void NegativeClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.LightnessLinearStretch(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void EnhanceVisibilityClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.EnhanceVisibility(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void GrayscaleHistogramEqualizationClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.GrayscaleHistogramEqualization(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void SaturationHistogramEqualizationClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.SaturationHistogramEqualization(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void LightnessHistogramEqualizationClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.LightnessHistogramEqualization(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void MirrorHorizontallyClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.MirrorHorizontally(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void MirrorVerticallyClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.MirrorVertically(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void LaplacianFilterClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.LaplacianFilter(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void BinarizeClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.Binarize(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void DilationClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.Dilation(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void ErosionClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.Erosion(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void MorphologyOpenClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.MorphologyOpen(); SetImageChanges(true); RefreshViewPhoto();
        }

        private void MorphologyCloseClick(object sender, RoutedEventArgs e) {
            ClonedSelectedImage.MorphologyClose(); SetImageChanges(true); RefreshViewPhoto();
        }
    }
}