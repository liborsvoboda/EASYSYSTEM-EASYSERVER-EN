using System;

namespace GlobalNET.Classes
{
    public partial class CreditNoteList
    {
        public int Id { get; set; } = 0;
        public string DocumentNumber { get; set; } = null;
        public string Supplier { get; set; } = null;
        public string Customer { get; set; } = null;
        public DateTime IssueDate { get; set; } = DateTimeOffset.Now.Date;
        public string InvoiceNumber { get; set; }
        public bool Storned { get; set; }
        public int TotalCurrencyId { get; set; }
        public string Description { get; set; } = null;
        public decimal TotalPriceWithVat { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public partial class ExtendedCreditNoteList : CreditNoteList
    {
        public string TotalCurrency { get; set; }
    }
}
