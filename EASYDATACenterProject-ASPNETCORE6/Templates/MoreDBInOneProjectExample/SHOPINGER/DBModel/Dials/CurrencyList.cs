using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SHOPINGER.DBModel
{
    public partial class CurrencyList
    {
        public CurrencyList()
        {
            CreditNoteLists = new HashSet<CreditNoteList>();
            ExchangeRateLists = new HashSet<ExchangeRateList>();
            IncomingInvoiceLists = new HashSet<IncomingInvoiceList>();
            IncomingOrderLists = new HashSet<IncomingOrderList>();
            ItemLists = new HashSet<ItemList>();
            OfferLists = new HashSet<OfferList>();
            OutgoingInvoiceLists = new HashSet<OutgoingInvoiceList>();
            OutgoingOrderLists = new HashSet<OutgoingOrderList>();
            ReceiptLists = new HashSet<ReceiptList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal ExchangeRate { get; set; }
        public bool Fixed { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Default { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<CreditNoteList> CreditNoteLists { get; set; }
        public virtual ICollection<ExchangeRateList> ExchangeRateLists { get; set; }
        public virtual ICollection<IncomingInvoiceList> IncomingInvoiceLists { get; set; }
        public virtual ICollection<IncomingOrderList> IncomingOrderLists { get; set; }
        public virtual ICollection<ItemList> ItemLists { get; set; }
        public virtual ICollection<OfferList> OfferLists { get; set; }
        public virtual ICollection<OutgoingInvoiceList> OutgoingInvoiceLists { get; set; }
        public virtual ICollection<OutgoingOrderList> OutgoingOrderLists { get; set; }
        public virtual ICollection<ReceiptList> ReceiptLists { get; set; }
    }
}
