using System;
using System.Collections.Generic;

namespace EASYBUILDER.DBModel
{
    public partial class ViewAttachmentList
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string? PartNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
