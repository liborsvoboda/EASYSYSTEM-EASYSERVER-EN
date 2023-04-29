using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class PartList
    {
        public int Id { get; set; }
        public int WorkPlace { get; set; }
        public string Number { get; set; } = null!;
        public string? Name { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
