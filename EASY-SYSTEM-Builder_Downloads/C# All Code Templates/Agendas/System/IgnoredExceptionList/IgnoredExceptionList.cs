using System;

namespace GlobalNET.Classes {

    public partial class IgnoredExceptionList {
        public int Id { get; set; } = 0;
        public string ErrorNumber { get; set; } = null;
        public string Description { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}