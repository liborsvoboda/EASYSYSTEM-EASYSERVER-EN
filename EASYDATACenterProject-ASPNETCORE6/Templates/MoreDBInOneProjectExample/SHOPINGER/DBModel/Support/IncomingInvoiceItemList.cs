using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SHOPINGER.DBModel
{
    public partial class IncomingInvoiceItemList
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string? PartNumber { get; set; }
        public string Name { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public decimal PcsPrice { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalPriceWithVat { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual IncomingInvoiceList DocumentNumberNavigation { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UnitList UnitNavigation { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
