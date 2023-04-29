using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class UsedLicenseList
    {
        public int Id { get; set; }
        public string AlgorithmName { get; set; } = null!;
        public string PartNumber { get; set; } = null!;
        public string UnlockCode { get; set; } = null!;
        public int AddressId { get; set; }
        public int ItemId { get; set; }
        public string License { get; set; } = null!;
        public DateTime ActivateDate { get; set; }
        public string IpAddress { get; set; } = null!;

        public virtual AddressList Address { get; set; } = null!;
        public virtual ItemList Item { get; set; } = null!;
    }
}
