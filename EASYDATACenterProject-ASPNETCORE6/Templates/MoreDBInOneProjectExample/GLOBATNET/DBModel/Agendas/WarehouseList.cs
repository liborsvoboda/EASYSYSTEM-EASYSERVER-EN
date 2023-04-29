using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class WarehouseList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool AllowNegativeStatus { get; set; }
        public bool Default { get; set; }
        public bool LockedByStockTaking { get; set; }
        public DateTime LastStockTaking { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList User { get; set; } = null!;
    }
}
