using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESRV.DBModel
{
    public partial class UsedLicenseList
    {
        public int Id { get; set; }
        public string IpAddress { get; set; } = null!;
        public string UnlockCode { get; set; } = null!;
        public string AlgorithmName { get; set; } = null!;
        public string PartNumber { get; set; } = null!;
        public string License { get; set; } = null!;
        public DateTime ActivateDate { get; set; }
        public int ItemId { get; set; }
        public int AddressId { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual AddressList Address { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual ItemList Item { get; set; } = null!;
    }
}
