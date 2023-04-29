using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class OperationList
    {
        public int Id { get; set; }
        public int WorkPlace { get; set; }
        public string PartNumber { get; set; } = null!;
        public int OperationNumber { get; set; }
        public string Note { get; set; } = null!;
        public int PcsPerHour { get; set; }
        public decimal KcPerKs { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
