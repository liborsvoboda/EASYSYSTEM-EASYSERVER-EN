using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EASYBUILDER.DBModel
{
    public partial class OfferList
    {
        public OfferList()
        {
            OfferItemLists = new HashSet<OfferItemList>();
        }

        public int Id { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Supplier { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public int OfferValidity { get; set; }
        public bool Storned { get; set; }
        public int TotalCurrencyId { get; set; }
        public string? Description { get; set; }
        public decimal TotalPriceWithVat { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual CurrencyList TotalCurrency { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<OfferItemList> OfferItemLists { get; set; }
    }
}
