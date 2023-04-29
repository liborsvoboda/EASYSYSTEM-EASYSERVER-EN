using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EASYBUILDER.DBModel
{
    public partial class AttachmentList
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string ParentType { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public byte[] Attachment { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
    }
}
