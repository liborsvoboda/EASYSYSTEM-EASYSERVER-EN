﻿using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class MaturityList
    {
        public MaturityList()
        {
            IncomingInvoiceLists = new HashSet<IncomingInvoiceList>();
            OutgoingInvoiceLists = new HashSet<OutgoingInvoiceList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Value { get; set; }
        public bool Default { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<IncomingInvoiceList> IncomingInvoiceLists { get; set; }
        public virtual ICollection<OutgoingInvoiceList> OutgoingInvoiceLists { get; set; }
    }
}
