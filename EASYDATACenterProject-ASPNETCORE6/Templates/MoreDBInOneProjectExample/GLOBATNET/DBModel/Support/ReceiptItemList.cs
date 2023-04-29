using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class ReceiptItemList
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

        public virtual ReceiptList DocumentNumberNavigation { get; set; } = null!;
        public virtual UnitList UnitNavigation { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
    }
}
