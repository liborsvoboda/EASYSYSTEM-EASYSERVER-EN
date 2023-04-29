using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESHOPER.DBModel
{
    public partial class UserRoleList
    {
        public UserRoleList()
        {
            UserLists = new HashSet<UserList>();
        }

        public int Id { get; set; }
        public string Role { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual ICollection<UserList> UserLists { get; set; }
    }
}
