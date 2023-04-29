using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class Calendar
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
