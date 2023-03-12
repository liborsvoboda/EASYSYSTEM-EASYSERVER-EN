using System;

namespace GlobalNET.Classes
{
    public partial class ReportList
    {
        public int Id { get; set; } = 0;
        public string PageName { get; set; } = null;
        public string Name { get; set; } = null;
        public bool JoinedId { get; set; } = false;
        public string Description { get; set; } = null;
        public bool Default { get; set; }
        public string ReportPath { get; set; } = null;
        public string MimeType { get; set; } = null;
        public byte[] File { get; set; } = null;
        public int UserId { get; set; }
        public DateTime? Timestamp { get; set; }
    }

}
