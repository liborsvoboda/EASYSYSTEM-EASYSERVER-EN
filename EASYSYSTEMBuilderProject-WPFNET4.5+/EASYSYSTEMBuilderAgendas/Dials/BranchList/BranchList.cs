using System;

namespace GlobalNET.Classes
{
    public partial class BranchList
    {
        public int Id { get; set; } = 0;
        public string CompanyName { get; set; } = null;
        public string ContactName { get; set; }
        public string Street { get; set; } = null;
        public string City { get; set; } = null;
        public string PostCode { get; set; } = null;
        public string Phone { get; set; } = null;
        public string Email { get; set; }
        public string BankAccount { get; set; }
        public string Ico { get; set; }
        public string Dic { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}
