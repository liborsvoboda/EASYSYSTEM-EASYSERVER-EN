using System;

namespace GlobalNET.Classes {

    public partial class DocumentTypeList {
        public int Id { get; set; } = 0;
        public string SystemName { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Translation { get; set; }
    }
}