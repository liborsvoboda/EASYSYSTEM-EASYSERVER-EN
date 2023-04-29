using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class ReceiptList
    {
        public ReceiptList()
        {
            OutgoingInvoiceLists = new HashSet<OutgoingInvoiceList>();
            ReceiptItemLists = new HashSet<ReceiptItemList>();
        }

        public int Id { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string? InvoiceNumber { get; set; }
        public string Supplier { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public bool Storned { get; set; }
        public int TotalCurrencyId { get; set; }
        public string? Description { get; set; }
        public decimal TotalPriceWithVat { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual OutgoingInvoiceList? InvoiceNumberNavigation { get; set; }
        public virtual CurrencyList TotalCurrency { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<OutgoingInvoiceList> OutgoingInvoiceLists { get; set; }
        public virtual ICollection<ReceiptItemList> ReceiptItemLists { get; set; }
    }
}
