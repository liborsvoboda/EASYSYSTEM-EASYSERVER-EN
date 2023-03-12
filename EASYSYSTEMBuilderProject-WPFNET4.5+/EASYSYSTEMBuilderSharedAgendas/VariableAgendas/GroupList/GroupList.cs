using System;

namespace PRUVODKY.Classes
{
    public partial class GroupList
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null;
        public int UserId { get; set; } = 0;
        public DateTime? Timestamp { get; set; } = null;

        //public UserRoleList Role { get; set; } = new UserRoleList();
    }

}
