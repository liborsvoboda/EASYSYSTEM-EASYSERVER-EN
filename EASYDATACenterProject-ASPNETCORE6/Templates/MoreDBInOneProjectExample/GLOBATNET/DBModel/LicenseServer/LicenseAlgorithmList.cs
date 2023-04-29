using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class LicenseAlgorithmList
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string Algorithm { get; set; } = null!;
        public string? Description { get; set; }
        public bool LimitActive { get; set; }
        public int? ActivationLimit { get; set; }
        public int UsedCount { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual AddressList Address { get; set; } = null!;
        public virtual ItemList Item { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
    }
}
