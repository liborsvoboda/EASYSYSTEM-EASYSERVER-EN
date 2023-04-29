using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUVODKY.DBModel
{
    public partial class WorkList
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PersonalNumber { get; set; }
        public int WorkPlace { get; set; }
        public int OperationNumber { get; set; }
        public TimeSpan WorkTime { get; set; }
        public int Pcs { get; set; }
        public decimal Amount { get; set; }
        public decimal WorkPower { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
