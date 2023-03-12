using System;

namespace GlobalNET.Classes
{
    public partial class LoginHistoryList
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string TerminalName { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
