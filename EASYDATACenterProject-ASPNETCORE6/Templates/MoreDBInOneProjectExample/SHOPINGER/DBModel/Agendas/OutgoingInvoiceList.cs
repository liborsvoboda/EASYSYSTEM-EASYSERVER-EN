using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SHOPINGER.DBModel
{
    public partial class OutgoingInvoiceList
    {
        public OutgoingInvoiceList()
        {
            CreditNoteLists = new HashSet<CreditNoteList>();
            OutgoingInvoiceItemLists = new HashSet<OutgoingInvoiceItemList>();
            ReceiptLists = new HashSet<ReceiptList>();
        }

        public int Id { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Supplier { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public int PaymentMethodId { get; set; }
        public int MaturityId { get; set; }
        public string? OrderNumber { get; set; }
        public bool Storned { get; set; }
        public int PaymentStatusId { get; set; }
        public int TotalCurrencyId { get; set; }
        public string? Description { get; set; }
        public decimal TotalPriceWithVat { get; set; }
        public int? ReceiptId { get; set; }
        public int? CreditNoteId { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual CreditNoteList? CreditNote { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual MaturityList Maturity { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual PaymentMethodList PaymentMethod { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual PaymentStatusList PaymentStatus { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual ReceiptList? Receipt { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual CurrencyList TotalCurrency { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<CreditNoteList> CreditNoteLists { get; set; }
        public virtual ICollection<OutgoingInvoiceItemList> OutgoingInvoiceItemLists { get; set; }
        public virtual ICollection<ReceiptList> ReceiptLists { get; set; }
    }
}
