using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class AccessRoleList
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string AccessRole { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual UserList User { get; set; }
    }
}
