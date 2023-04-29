using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESHOPER.DBModel
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
        [JsonIgnore]
        [ValidateNever]
        public virtual AddressList Address { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual ItemList Item { get; set; } = null!;
    }
}
