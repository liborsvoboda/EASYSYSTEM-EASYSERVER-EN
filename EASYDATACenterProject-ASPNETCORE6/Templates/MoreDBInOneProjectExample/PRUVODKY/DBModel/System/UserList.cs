using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class UserList
    {
        public UserList()
        {
            Calendars = new HashSet<Calendar>();
            GroupLists = new HashSet<GroupList>();
            OperationLists = new HashSet<OperationList>();
            PartLists = new HashSet<PartList>();
            PersonLists = new HashSet<PersonList>();
            TemplateLists = new HashSet<TemplateList>();
            WorkLists = new HashSet<WorkList>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Token { get; set; }
        public DateTime? Expiration { get; set; }
        public byte[]? Photo { get; set; }
        public string? MimeType { get; set; }
        public string? PhotoPath { get; set; }
        public bool SystemAdmin { get; set; }

        [JsonIgnore]
        [ValidateNever]
        public virtual UserRoleList Role { get; set; } = null!;
        public virtual ICollection<Calendar> Calendars { get; set; }
        public virtual ICollection<GroupList> GroupLists { get; set; }
        public virtual ICollection<OperationList> OperationLists { get; set; }
        public virtual ICollection<PartList> PartLists { get; set; }
        public virtual ICollection<PersonList> PersonLists { get; set; }
        public virtual ICollection<TemplateList> TemplateLists { get; set; }
        public virtual ICollection<WorkList> WorkLists { get; set; }
    }
}
