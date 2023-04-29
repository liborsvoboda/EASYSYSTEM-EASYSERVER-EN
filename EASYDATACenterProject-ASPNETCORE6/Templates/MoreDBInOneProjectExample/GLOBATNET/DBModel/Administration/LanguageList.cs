using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class LanguageList
    {
        public int Id { get; set; }
        public string SystemName { get; set; } = null!;
        public string DescriptionCz { get; set; } = null!;
        public string DescriptionEn { get; set; } = null!;
        public int? UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual UserList? User { get; set; }
    }
}
