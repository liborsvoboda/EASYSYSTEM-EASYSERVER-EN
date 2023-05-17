using System;

namespace GlobalNET.Classes {

    public partial class UserRoleList {
        public int Id { get; set; } = 0;
        public string SystemName { get; set; } = null;
        public string Description { get; set; } = null;
        public DateTime? Timestamp { get; set; } = null;

        public string Translation { get; set; } = null;
    }
}