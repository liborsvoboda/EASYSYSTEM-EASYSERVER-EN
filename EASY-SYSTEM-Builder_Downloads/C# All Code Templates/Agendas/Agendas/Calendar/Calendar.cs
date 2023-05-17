using System;

namespace GlobalNET.Classes {

    public partial class Calendar {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; } = null;
        public DateTime TimeStamp { get; set; }
    }
}