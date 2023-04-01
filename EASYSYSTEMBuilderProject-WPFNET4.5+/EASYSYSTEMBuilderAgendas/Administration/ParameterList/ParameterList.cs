using System;

namespace GlobalNET.Classes
{
    public partial class ParameterList
    {
        public int Id { get; set; } = 0;
        public int? UserId { get; set; } = null;
        public string Parameter { get; set; } = null;
        public string Value { get; set; } = null;
        public string Type { get; set; } = null;
        public string Description { get; set; } = null;
        public DateTime TimeStamp { get; set; }
    }

}
