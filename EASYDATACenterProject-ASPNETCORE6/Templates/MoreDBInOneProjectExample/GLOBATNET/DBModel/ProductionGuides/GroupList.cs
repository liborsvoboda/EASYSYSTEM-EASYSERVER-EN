using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class GroupList
    {
        public GroupList()
        {
            PersonLists = new HashSet<PersonList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<PersonList> PersonLists { get; set; }
    }
}
