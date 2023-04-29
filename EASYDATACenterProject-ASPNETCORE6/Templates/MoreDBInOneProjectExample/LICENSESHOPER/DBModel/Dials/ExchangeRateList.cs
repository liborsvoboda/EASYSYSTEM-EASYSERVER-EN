using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESHOPER.DBModel
{
    public partial class ExchangeRateList
    {
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public decimal Value { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual CurrencyList Currency { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
