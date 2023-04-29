using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class SystemFailList
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string LogLevel { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual UserList? User { get; set; }
    }
}
