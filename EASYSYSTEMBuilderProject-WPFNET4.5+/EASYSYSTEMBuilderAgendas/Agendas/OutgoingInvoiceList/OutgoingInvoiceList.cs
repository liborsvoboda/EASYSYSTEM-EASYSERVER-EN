using System;

namespace GlobalNET.Classes
{
    public partial class OutgoingInvoiceList
    {
        public int Id { get; set; } = 0;
        public string DocumentNumber { get; set; } = null;
        public string Supplier { get; set; } = null;
        public string Customer { get; set; } = null;
        public DateTime IssueDate { get; set; } = DateTimeOffset.Now.Date;
        public DateTime TaxDate { get; set; } = DateTimeOffset.Now.Date;
        public DateTime MaturityDate { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? MaturityId { get; set; }
        public string OrderNumber { get; set; }
        public bool Storned { get; set; }
        public int? PaymentStatusId { get; set; }
        public int TotalCurrencyId { get; set; }
        public string Description { get; set; } = null;
        public decimal TotalPriceWithVat { get; set; }
        public int? ReceiptId { get; set; } = null;
        public int? CreditNoteId { get; set; } = null;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public partial class ExtendedOutgoingInvoiceList : OutgoingInvoiceList
    {
        public string TotalCurrency { get; set; }
        public bool CreditNoteExist { get; set; }
        public bool ReceiptExist { get; set; }
    }
}
