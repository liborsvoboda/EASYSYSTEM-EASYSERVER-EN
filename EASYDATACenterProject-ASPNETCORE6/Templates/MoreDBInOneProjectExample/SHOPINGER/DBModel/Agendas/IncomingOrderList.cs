using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SHOPINGER.DBModel
{
    public partial class IncomingOrderList
    {
        public IncomingOrderList()
        {
            IncomingOrderItemLists = new HashSet<IncomingOrderItemList>();
        }

        public int Id { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Supplier { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public bool Storned { get; set; }
        public int TotalCurrencyId { get; set; }
        public string? Description { get; set; }
        public string? CustomerOrderNumber { get; set; }
        public decimal TotalPriceWithVat { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual CurrencyList TotalCurrency { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<IncomingOrderItemList> IncomingOrderItemLists { get; set; }
    }
}
