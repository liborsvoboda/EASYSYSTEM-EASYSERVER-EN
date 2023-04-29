using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class Calendar
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList User { get; set; } = null!;
    }
}
