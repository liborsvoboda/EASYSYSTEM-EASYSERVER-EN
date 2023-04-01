using System;

namespace GlobalNET.Classes
{
    public partial class DocumentAdviceList
    {
        public int Id { get; set; } = 0;
        public int BranchId { get; set; }
        public string DocumentType { get; set; } = null;
        public string Prefix { get; set; } = null;
        public string Number { get; set; } = null;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public partial class ExtendedDocumentAdviceList : DocumentAdviceList
    {
        public string Branch { get; set; }
    }
}
