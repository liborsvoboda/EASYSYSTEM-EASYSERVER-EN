using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class VisitorIpList
    {
        public int Id { get; set; }
        public string VisitorIp { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual VisitorList VisitorIpNavigation { get; set; } = null!;
    }
}
