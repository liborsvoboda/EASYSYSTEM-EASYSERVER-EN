using System;

namespace GlobalNET.Classes
{
    public partial class MaturityList
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null;
        public int Value { get; set; } = 1;
        public bool Default { get; set; }
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}
