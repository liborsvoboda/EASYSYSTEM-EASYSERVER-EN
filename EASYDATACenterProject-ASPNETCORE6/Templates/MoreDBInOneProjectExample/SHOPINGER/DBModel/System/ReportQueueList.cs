using System;
using System.Collections.Generic;

namespace SHOPINGER.DBModel
{
    public partial class ReportQueueList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Sequence { get; set; }
        public string Sql { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string? Filter { get; set; }
        public string? Search { get; set; }
        public string? SearchColumnList { get; set; }
        public bool SearchFilterIgnore { get; set; }
        public int? RecId { get; set; }
        public bool RecIdFilterIgnore { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public partial class SetReportFilter
    {
        public string TableName { get; set; } = null;
        public string Filter { get; set; } = null;
        public string Search { get; set; } = null;
        public int RecId { get; set; } = 0;
    }
}
