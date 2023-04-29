using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESHOPER.DBModel
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
        [JsonIgnore]
        [ValidateNever]
        public virtual CurrencyList Currency { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UnitList UnitNavigation { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual VatList Vat { get; set; } = null!;
        public virtual ICollection<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; }
        public virtual ICollection<UsedLicenseList> UsedLicenseLists { get; set; }
    }
}
