using System;
using System.Collections.Generic;

namespace SHOPINGER.DBModel
{
    public partial class ServerSetting
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public bool Active { get; set; }
    }
}
