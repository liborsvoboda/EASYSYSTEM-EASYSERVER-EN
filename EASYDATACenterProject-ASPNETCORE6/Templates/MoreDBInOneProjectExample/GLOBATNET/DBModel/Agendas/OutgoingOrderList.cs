using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class OutgoingOrderList
    {
        public OutgoingOrderList()
        {
            OutgoingOrderItemLists = new HashSet<OutgoingOrderItemList>();
        }

        public int Id { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public string Supplier { get; set; } = null!;
        public bool Storned { get; set; }
        public int TotalCurrencyId { get; set; }
        public string? Description { get; set; }
        public decimal TotalPriceWithVat { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual CurrencyList TotalCurrency { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<OutgoingOrderItemList> OutgoingOrderItemLists { get; set; }
    }
}
