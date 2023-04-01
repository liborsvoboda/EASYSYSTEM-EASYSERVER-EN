using System;

namespace GlobalNET.Classes
{

    public partial class SystemFailList
    {
        public int Id { get; set; } = 0;
        public string Message { get; set; } = null;
        public int? UserId { get; set; } = null;
        public string UserName { get; set; } = null;
        public DateTime TimeStamp { get; set; }
    }
}
