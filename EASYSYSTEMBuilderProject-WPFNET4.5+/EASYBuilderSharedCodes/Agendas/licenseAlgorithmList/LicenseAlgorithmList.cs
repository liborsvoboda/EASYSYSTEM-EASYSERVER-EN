using System;

namespace GlobalNET.Classes
{
    public partial class LicenseAlgorithmList
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null;
        public DateTime? ValidFrom { get; set; } = null;
        public DateTime? ValidTo { get; set; } = null;
        public string Algorithm { get; set; } = null;
        public string Description { get; set; } = null;
        public bool LimitActive { get; set; }
        public int? ActivationLimit { get; set; }
        public int UsedCount { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int ItemId { get; set; }

    }
    public partial class ExtendedLicenseAlgorithmList : LicenseAlgorithmList
    {
        public string PartNumber { get; set; } = null;
        public string ItemName { get; set; } = null;
        public string CompanyName { get; set; } = null;
    }
}
