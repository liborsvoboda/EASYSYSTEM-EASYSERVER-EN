using System;

namespace GlobalNET.Classes {

    public partial class LicenseActivationFailList {
        public int Id { get; set; } = 0;
        public string IpAddress { get; set; } = null;
        public string UnlockCode { get; set; } = null;
        public string PartNumber { get; set; } = null;
        public DateTime TimeStamp { get; set; }
    }
}