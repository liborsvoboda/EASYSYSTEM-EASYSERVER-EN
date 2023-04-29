using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class ExchangeRateList
    {
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public decimal Value { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual CurrencyList Currency { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
    }
}
