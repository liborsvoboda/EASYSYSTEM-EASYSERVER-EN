using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class DocumentTypeList
    {
        public DocumentTypeList()
        {
            DocumentAdviceLists = new HashSet<DocumentAdviceList>();
        }

        public int Id { get; set; }
        public string SystemName { get; set; } = null!;
        public string? Description { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<DocumentAdviceList> DocumentAdviceLists { get; set; }
    }
}
