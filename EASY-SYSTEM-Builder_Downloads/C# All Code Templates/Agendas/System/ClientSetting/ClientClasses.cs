using System;

namespace GlobalNET.Classes {

    /// <summary>
    /// Client configuration Definition
    /// </summary>
    public class Config {
        public string ApiAddress { get; set; } = "http://109.164.71.204:5000";
        public bool WriteToLog { get; set; } = true;
        public Double ServerCheckIntervalSec { get; set; } = 5000;
        public bool TopMost { get; set; } = false;
        public bool ActiveNewInputDefault { get; set; } = true;
        public string DefaultLanguage { get; set; } = "{\"Name\":\"System\",\"Value\":\"system\"}";
        public string ThemeName { get; set; } = "Base Light";
        public string AccentName { get; set; } = "Green";
        public string ReportingPath { get; set; } = "C:\\Program Files\\GroupWare-Solution.Eu\\FyiReporting\\RdlReader.exe";
        public string UpdateUrl { get; set; } = "https://groupware-solution.eu/FTP/GlobalNETProject/Update";
        public string AutomaticUpdate { get; set; } = "never";
        public bool HideStartVideo { get; set; } = false;
        public string ReportConnectionString { get; set; } = "Server=192.168.1.104,1433;Database=GLOBALNET;User ID=globalnet;Password=globalnet;";
        public string ReportBuilderPath { get; set; } = "C:\\Program Files\\GroupWare-Solution.Eu\\FyiReporting\\RdlDesigner.exe";
        public bool ActiveSystemSaver { get; set; } = true;
        public bool DisableOnActivity { get; set; } = true;
        public int TimeToEnable { get; set; } = 30;
        public bool ImDeveloper { get; set; } = false;
    }

    /// <summary>
    /// Program version Class
    /// </summary>
    public class AppVersion {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Private { get; set; }
    }

    /// <summary>
    /// Actual List Item informations for Controls each Page in MainView
    /// </summary>
    public class DataViewSupport {
        public int SelectedRecordId { get; set; } = 0;
        public bool FormShown { get; set; } = false;
        public string FilteredValue { get; set; } = null;
        public string AdvancedFilter { get; set; } = null;
    }

    /// <summary>
    /// Language definition support
    /// </summary>
    public class Language {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    /// <summary>
    /// Report naming support
    /// </summary>
    public class ReportSelection {
        public string Name { get; set; }
    }
}