using System;

namespace GlobalNET.Classes
{
    public partial class UserRoleList
    {
        public int Id { get; set; } = 0;
        public string Role { get; set; } = null;
        public string Description { get; set; } = null;
        public bool Active { get; set; } = false;
        public DateTime? Timestamp { get; set; } = null;
    }

    public class UserRoleListSelection
    {
        public int Id { get; set; } = 0;
        public string Role { get; set; } = null;
    }
}
