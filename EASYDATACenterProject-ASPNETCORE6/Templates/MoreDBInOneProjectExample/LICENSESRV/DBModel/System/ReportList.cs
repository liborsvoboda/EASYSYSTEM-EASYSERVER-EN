using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESRV.DBModel
{
    public partial class ReportList
    {
        public int Id { get; set; }
        public string PageName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool JoinedId { get; set; }
        public string? Description { get; set; }
        public string? ReportPath { get; set; }
        public string MimeType { get; set; } = null!;
        public byte[] File { get; set; } = null!;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Default { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
