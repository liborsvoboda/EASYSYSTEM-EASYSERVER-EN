using System;
using System.Collections.Generic;

namespace PRUVODKY.DBModel
{
    public partial class ReportList
    {
        public int Id { get; set; }
        public string PageName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool JoinedId { get; set; }
        public string? Description { get; set; }
        public string? ReportPath { get; set; }
        public string MimeType { get; set; } = null!;
        public byte[] File { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
