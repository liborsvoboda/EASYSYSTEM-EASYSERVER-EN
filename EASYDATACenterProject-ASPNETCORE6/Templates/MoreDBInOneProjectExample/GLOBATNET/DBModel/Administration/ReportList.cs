using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class ReportList
    {
        public int Id { get; set; }
        public string PageName { get; set; } = null!;
        public string SystemName { get; set; } = null!;
        public bool JoinedId { get; set; }
        public string? Description { get; set; }
        public string? ReportPath { get; set; }
        public string MimeType { get; set; } = null!;
        public byte[] File { get; set; } = null!;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Default { get; set; }

        public virtual UserList User { get; set; } = null!;
    }
}
