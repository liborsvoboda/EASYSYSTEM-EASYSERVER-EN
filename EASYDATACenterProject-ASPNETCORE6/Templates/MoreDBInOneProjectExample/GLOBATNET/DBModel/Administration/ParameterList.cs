using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class ParameterList
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string SystemName { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList? User { get; set; }
    }
}
