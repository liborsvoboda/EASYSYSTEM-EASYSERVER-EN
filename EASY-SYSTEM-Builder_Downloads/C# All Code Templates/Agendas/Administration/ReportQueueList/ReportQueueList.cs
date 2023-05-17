using System;

namespace GlobalNET.Classes {

    public partial class ReportQueueList {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null;
        public int Sequence { get; set; } = 0;
        public string Sql { get; set; } = null;
        public string TableName { get; set; } = null;
        public string Filter { get; set; } = null;
        public string Search { get; set; } = null;
        public string SearchColumnList { get; set; } = null;
        public bool SearchFilterIgnore { get; set; }
        public int? RecId { get; set; } = 0;
        public bool RecIdFilterIgnore { get; set; }
        public DateTime Timestamp { get; set; }

        public string TranslatedTableName { get; set; } = null;
    }

    public partial class SetReportFilter {
        public string TableName { get; set; } = null;
        public string Filter { get; set; } = null;
        public string Search { get; set; } = null;
        public int RecId { get; set; } = 0;
    }
}