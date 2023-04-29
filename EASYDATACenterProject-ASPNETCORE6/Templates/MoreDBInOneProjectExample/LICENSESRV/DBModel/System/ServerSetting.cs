using System;
using System.Collections.Generic;

namespace LICENSESRV.DBModel
{
    public partial class ServerSetting
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
