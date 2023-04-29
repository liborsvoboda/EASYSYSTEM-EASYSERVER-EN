using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class LicenseActivationFailList
    {
        public int Id { get; set; }
        public string IpAddress { get; set; } = null!;
        public string? UnlockCode { get; set; }
        public string? PartNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
