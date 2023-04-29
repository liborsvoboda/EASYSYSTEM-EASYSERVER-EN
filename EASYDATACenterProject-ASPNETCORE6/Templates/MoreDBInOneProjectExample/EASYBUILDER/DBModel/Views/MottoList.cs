using System;
using System.Collections.Generic;

namespace EASYBUILDER.DBModel
{
    public partial class MottoList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
