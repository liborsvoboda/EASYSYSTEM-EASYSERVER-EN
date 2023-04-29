using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESRV.DBModel
{
    public partial class ParameterList
    {
        public int Id { get; set; }
        public string Parameter { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
