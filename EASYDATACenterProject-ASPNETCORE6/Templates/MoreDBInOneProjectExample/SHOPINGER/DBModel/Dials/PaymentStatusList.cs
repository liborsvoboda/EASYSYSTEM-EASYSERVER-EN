using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SHOPINGER.DBModel
{
    public partial class PaymentStatusList
    {
        public PaymentStatusList()
        {
            IncomingInvoiceLists = new HashSet<IncomingInvoiceList>();
            OutgoingInvoiceLists = new HashSet<OutgoingInvoiceList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Default { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public bool Receipt { get; set; }
        public bool CreditNote { get; set; }
        public DateTime TimeStamp { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<IncomingInvoiceList> IncomingInvoiceLists { get; set; }
        public virtual ICollection<OutgoingInvoiceList> OutgoingInvoiceLists { get; set; }
    }
}
