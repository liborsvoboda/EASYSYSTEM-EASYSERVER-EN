using System;

namespace GlobalNET.Classes {

    public partial class PaymentMethodList {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null;
        public bool Default { get; set; } = false;
        public string Description { get; set; } = null;
        public bool AutoGenerateReceipt { get; set; }
        public bool AllowGenerateReceipt { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}