using System;

namespace GlobalNET.Classes {

    public partial class UsedLicenseList {
        public int Id { get; set; } = 0;
        public string IpAddress { get; set; } = null;
        public string UnlockCode { get; set; } = null;
        public string AlgorithmName { get; set; }
        public string PartNumber { get; set; } = null;
        public string License { get; set; } = null;
        public DateTime? ActivateDate { get; set; } = null;
        public int ItemId { get; set; } = 0;
        public int AddressId { get; set; }
    }

    public partial class ExtendedUsedLicenseList : UsedLicenseList {
        public string ItemName { get; set; } = null;
        public string CompanyName { get; set; } = null;
    }
}