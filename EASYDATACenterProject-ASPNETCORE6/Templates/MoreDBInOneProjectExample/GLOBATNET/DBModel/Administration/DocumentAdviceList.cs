using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class DocumentAdviceList
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string DocumentType { get; set; } = null!;
        public string Prefix { get; set; } = null!;
        public string Number { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual BranchList Branch { get; set; } = null!;
        public virtual DocumentTypeList DocumentTypeNavigation { get; set; } = null!;
        public virtual UserList User { get; set; } = null!;
    }
}
