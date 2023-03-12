using Newtonsoft.Json;
using GlobalNET.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MahApps.Metro.Controls;
using EASYTools.Calendar;
using System.Web.UI.WebControls;
using System.Web;
using System.Threading.Tasks;
using GlobalNET.GlobalFunctions;
using GlobalNET.Api;

namespace GlobalNET.Pages
{
    public partial class CalendarPage : UserControl
    {
        public static DataViewSupport dataViewSupport = new DataViewSupport();
        public static Classes.Calendar selectedRecord = new Classes.Calendar();

        private new string Language = JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value;
        private List<string> Months = new List<string>();

        public CalendarPage()
        {
            InitializeComponent();
            _ = MediaFunctions.SetLanguageDictionary(Resources, JsonConvert.DeserializeObject<Language>(App.Setting.DefaultLanguage).Value);

            if (Language == "system") { Language = Thread.CurrentThread.CurrentCulture.ToString(); }
            switch (Language)
            {
                case "cs-CZ":
                    Months = new List<string> { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
                    break;
                case "en-US":
                    Months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    break;
            }

            cboMonth.ItemsSource = Months;
            for (int i = -10; i < 10; i++) { cboYear.Items.Add(DateTime.Today.AddYears(i).Year); }

            cboMonth.SelectedItem = Months.FirstOrDefault(w => w.ToUpper() == DateTime.Today.ToString("MMMM").ToUpper());
            cboYear.SelectedItem = DateTime.Today.Year;

            _ = LoadDataList();
            cboMonth.SelectionChanged += (o, e) => RefreshCalendar();
            cboYear.SelectionChanged += (o, e) => RefreshCalendar();
            SetRecord(false);
        }

        public async Task<bool> LoadDataList()
        {
            MainWindow.ProgressRing = Visibility.Visible;
            List<Classes.Calendar> Data = new List<Classes.Calendar>();
            try { if (MainWindow.serviceRunning) Data = await ApiCommunication.GetApiRequest<List<Classes.Calendar>>(ApiUrls.GlobalNETCalendar, App.UserData.Authentification.Id.ToString(), App.UserData.Authentification.Token); }
            catch { }

            foreach (Classes.Calendar record in Data)
            {
                foreach (Day calendarDay in Calendar.Days)
                {
                    if (calendarDay.Date == record.Date && record.Notes.Length > 0)
                    {
                        calendarDay.Notes = record.Notes;
                    }
                }
            }
            MainWindow.ProgressRing = Visibility.Hidden; return true;
        }

        private async void RefreshCalendar()
        {
            if (cboYear.SelectedItem == null) return;
            if (cboMonth.SelectedItem == null) return;

            int year = (int)cboYear.SelectedItem;
            int month = cboMonth.SelectedIndex + 1;
            DateTime targetDate = new DateTime(year, month, 1);

            Calendar.BuildCalendar(targetDate);
            await LoadDataList();
        }

        private async void Calendar_DayChanged(object sender, DayChangedEventArgs e)
        {
            selectedRecord = new Classes.Calendar()
            {
                UserId = App.UserData.Authentification.Id,
                Date = e.Day.Date,
                Notes = e.Day.Notes,
                TimeStamp = DateTimeOffset.Now.DateTime
            };

            string json = JsonConvert.SerializeObject(selectedRecord);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            DBResultMessage dBResult = await ApiCommunication.PostApiRequest(ApiUrls.GlobalNETCalendar, httpContent, null, App.UserData.Authentification.Token);
            if (dBResult.recordCount == 0)
            {
               await MainWindow.ShowMessage(true, "Exception Error : " + dBResult.ErrorMessage);
            }
        }

        private void SetRecord(bool showForm)
        {
            MainWindow.DataGridSelected = MainWindow.DataGridSelectedIdListIndicator = false; MainWindow.dataGridSelectedId = 0; MainWindow.DgRefresh = false;
            dataViewSupport.FormShown = true;
        }
    }
}