using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class ItemList
    {
        public ItemList()
        {
            LicenseAlgorithmLists = new HashSet<LicenseAlgorithmList>();
            UsedLicenseLists = new HashSet<UsedLicenseList>();
        }

        public int Id { get; set; }
        public string PartNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Unit { get; set; } = null!;
        public decimal Price { get; set; }
        public int VatId { get; set; }
        public int CurrencyId { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual CurrencyList Currency { get; set; } = null!;
        public virtual UnitList UnitNavigation { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
        public virtual VatList Vat { get; set; } = null!;
        public virtual ICollection<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; }
        public virtual ICollection<UsedLicenseList> UsedLicenseLists { get; set; }
    }
}
