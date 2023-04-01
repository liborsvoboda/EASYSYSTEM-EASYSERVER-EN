using System;

namespace GlobalNET.Classes
{

    public partial class AccessRoleList
    {
        public int Id { get; set; } = 0;
        public string TableName { get; set; } = null;
        public string AccessRole { get; set; } = null;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Translation { get; set; } = null;

    }
}
