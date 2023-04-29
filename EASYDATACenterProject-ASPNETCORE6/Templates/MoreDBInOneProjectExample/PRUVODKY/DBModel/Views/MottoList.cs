using System;
using System.Collections.Generic;

namespace PRUVODKY.DBModel
{
    public partial class MottoList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
