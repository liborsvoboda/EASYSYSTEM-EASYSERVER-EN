using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class PersonList
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PersonalNumber { get; set; }
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual GroupList Group { get; set; } = null!;
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
