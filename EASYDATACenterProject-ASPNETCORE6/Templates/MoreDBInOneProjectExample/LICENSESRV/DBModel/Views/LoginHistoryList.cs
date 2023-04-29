using System;
using System.Collections.Generic;

namespace LICENSESRV.DBModel
{
    public partial class LoginHistoryList
    {
        public int Id { get; set; }
        public string IpAddress { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string TerminalName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
