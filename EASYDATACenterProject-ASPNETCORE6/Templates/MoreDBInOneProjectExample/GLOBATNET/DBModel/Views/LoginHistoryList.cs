using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class LoginHistoryList
    {
        public int Id { get; set; }
        public string IpAddress { get; set; } = null!;
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
