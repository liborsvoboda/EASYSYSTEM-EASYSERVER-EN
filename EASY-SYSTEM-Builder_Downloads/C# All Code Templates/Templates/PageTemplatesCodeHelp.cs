using GlobalNET.Api;
using GlobalNET.Classes;
using GlobalNET.GlobalOperations;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GlobalNET.Templates {

    /// <summary>
    /// Library with standardize Definitions and Methods For Develop Any System
    /// </summary>
    public class PageTemplatesCodeHelp {

        #region MyReStandartized Definitions

        /// <summary>
        /// Define Collection For ComboBox Example
        /// </summary>
        public ObservableCollection<Language> Languages = new ObservableCollection<Language>() {
                                                                new Language() { Name = "System", Value = "system" },
                                                                new Language() { Name = "Czech", Value = "cs-CZ" },
                                                             };

        #endregion MyReStandartized Definitions

        /// <summary>
        /// Special Method for input limitation as number only
        /// Its only for help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Example of Load System Parameters for Page
        /// Add Call this method Before LoadDatalist and Tilt Documents
        /// LoadParameters() will be later translating Detail Fields
        /// </summary>
        private async void LoadParameters() {
            string itemVatPriceFormat = await DataOperations.ParameterCheck("ItemVatPriceFormat");
            string documentVatPriceFormat = await DataOperations.ParameterCheck("DocumentVatPriceFormat");
            int intValue = int.Parse(await DataOperations.ParameterCheck("DocumentRowHeight"));
        }

        /// <summary>
        /// Global Application Defined API Communication Types for Centralized using
        /// </summary>
        private async void DefinedAllAplicationApiComunicationTypes() {
            ///ApiUrls variable is List With All API calls

            ///DBResultMessage is Class for Global using of All API with all information of Request result
            DBResultMessage dBResult;

            /// Serialize Dataset for API sending INSERT/UPDATE
            TemplateClassList myRecord = new TemplateClassList();
            string json = JsonConvert.SerializeObject(myRecord);
            StringContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            ///API for load/Select Data
            await ApiCommunication.GetApiRequest<List<TemplateClassList>>(ApiUrls.TemplateClassList, null, App.UserData.Authentification.Token);

            ///API for Data Insert
            dBResult = await ApiCommunication.PutApiRequest(ApiUrls.TemplateClassList, httpContent, null, App.UserData.Authentification.Token);

            ///API for Data Update
            dBResult = await ApiCommunication.PostApiRequest(ApiUrls.TemplateClassList, httpContent, null, App.UserData.Authentification.Token);

            ///API for Delete Data
            dBResult = await ApiCommunication.DeleteApiRequest(ApiUrls.TemplateClassList, "someId", App.UserData.Authentification.Token);
        }

        /// <summary>
        /// Global Application available Methods for All Pages for Centralized using
        /// </summary>
        private async void DefinedGlobalMainWindowMethodsForAllPages() {
            ///Application Restart
            App.AppRestart();

            ///ProgresRing for Wait indication
            MainWindow.ProgressRing = Visibility.Hidden;

            ///Show Info message
            await MainWindow.ShowMessage(false, "Resources[\"dictionaryWord\"].ToString()");

            ///Show Confirm Dialog
            MessageDialogResult result = await MainWindow.ShowMessage(false, "Resources[\"dictionaryWord\"].ToString()" + " ", true);
            if (result == MessageDialogResult.Affirmative) { }

            ///Method For Sett Language of Each Page
            Language defaultLanguage = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage);
            ///_ = SystemOperations.SetLanguageDictionary(Resources, defaultLanguage.Value);
        }

        /// <summary>
        /// Global Specific Methods For Customized Working
        /// </summary>
        private async void UsedSpecificMethodsForCustomizedWorking() {

            #region Other Help Global Definitions and Methods

            ///Load Parameter From Table Parameters text is Parameter name
            var res = int.Parse(await DataOperations.ParameterCheck("someParameterName"));

            ///Set ComboBox Item By myValue (from selected record or another)
            int index = 0; ComboBox cb_defaultLanguage = new ComboBox();
            cb_defaultLanguage.Items.SourceCollection.Cast<Language>().ToList().ForEach(language => { if (language.Name == "myvalue") { cb_defaultLanguage.SelectedIndex = index; } index++; });

            ///Open File Dialog
            OpenFileDialog dlg = new OpenFileDialog
            { DefaultExt = ".exe", Filter = "Exe files |*.exe", Title = "Resources[\"fileOpenDescription\"].ToString()" };
            if (dlg.ShowDialog() == true) { }

            #endregion Other Help Global Definitions and Methods
        }

        #region Other Custom Communications

        /// <summary>
        /// Customized GET Call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnApiTest_Click(object sender, RoutedEventArgs e) {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string json = await httpClient.GetStringAsync("someUrl");
                    await MainWindow.ShowMessage(false, json);
                }
                catch (Exception ex) { await MainWindow.ShowMessage(true, "Exception Error : " + ex.StackTrace); }
            }
        }

        #endregion Other Custom Communications
    }
}