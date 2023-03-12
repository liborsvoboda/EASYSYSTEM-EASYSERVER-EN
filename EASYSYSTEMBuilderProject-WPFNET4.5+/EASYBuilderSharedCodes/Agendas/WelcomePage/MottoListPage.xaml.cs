﻿using GlobalNET.Classes;
using GlobalNET;
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using GlobalNET.Api;

namespace GlobalNET.Pages
{
    public partial class WelcomePage : MetroWindow {

        private List<MottoList> MottoList = new List<MottoList>();
        private readonly string MottoListPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"Data","Mottos");

        public WelcomePage() {

            InitializeComponent();
            Loaded += MainManagerOnOnLoaded;
            Show();
        }

        private async void MainManagerOnOnLoaded(object sender, RoutedEventArgs e) {
            try
			{
                var lines = File.ReadLines(MottoListPath);
                foreach (string line in lines) { if (!string.IsNullOrWhiteSpace(line)) { MottoList.Add(new MottoList() { Name = line }); } }

                MottoList = await ApiCommunication.GetApiRequest<List<MottoList>>(ApiUrls.GlobalNETMottoList, null, null);
            }
            catch { }

            try
            {
                labelMotto.Content = MottoList[int.Parse(Math.Truncate(0.001 * new Random().Next(0, (MottoList.Count - 1) * 1000)).ToString())].Name;
                Storyboard endAnimation = (Storyboard)FindResource("ProgressAnimation");
                BeginStoryboard(endAnimation);
                endAnimation = (Storyboard)FindResource("LogoAnimation");
                BeginStoryboard(endAnimation);
                endAnimation = (Storyboard)FindResource("StartAnimation");
                BeginStoryboard(endAnimation);

            } catch { Close(); }
        }

        private void Storyboard_Completed(object sender, EventArgs e) => Close();
    }
}
