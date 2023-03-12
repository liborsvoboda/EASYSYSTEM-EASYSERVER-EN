using System;

namespace GlobalNET.Classes
{
    public class ServerSetting
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}


