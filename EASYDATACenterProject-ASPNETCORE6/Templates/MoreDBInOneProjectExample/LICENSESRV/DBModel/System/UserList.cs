using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESRV.DBModel
{
    public partial class UserList
    {
        public UserList()
        {
            AddressLists = new HashSet<AddressList>();
            AttachmentLists = new HashSet<AttachmentList>();
            Calendars = new HashSet<Calendar>();
            CurrencyLists = new HashSet<CurrencyList>();
            ItemLists = new HashSet<ItemList>();
            LicenseAlgorithmLists = new HashSet<LicenseAlgorithmList>();
            ParameterLists = new HashSet<ParameterList>();
            ReportLists = new HashSet<ReportList>();
            TemplateLists = new HashSet<TemplateList>();
            UnitLists = new HashSet<UnitList>();
            VatLists = new HashSet<VatList>();
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
        public virtual ICollection<AddressList> AddressLists { get; set; }
        public virtual ICollection<AttachmentList> AttachmentLists { get; set; }
        public virtual ICollection<Calendar> Calendars { get; set; }
        public virtual ICollection<CurrencyList> CurrencyLists { get; set; }
        public virtual ICollection<ItemList> ItemLists { get; set; }
        public virtual ICollection<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; }
        public virtual ICollection<ParameterList> ParameterLists { get; set; }
        public virtual ICollection<ReportList> ReportLists { get; set; }
        public virtual ICollection<TemplateList> TemplateLists { get; set; }
        public virtual ICollection<UnitList> UnitLists { get; set; }
        public virtual ICollection<VatList> VatLists { get; set; }
    }
}
