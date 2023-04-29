using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class AddressList
    {
        public AddressList()
        {
            LicenseAlgorithmLists = new HashSet<LicenseAlgorithmList>();
            UsedLicenseLists = new HashSet<UsedLicenseList>();
        }

        public int Id { get; set; }
        public string AddressType { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string? ContactName { get; set; }
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string? BankAccount { get; set; }
        public string? Ico { get; set; }
        public string? Dic { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<LicenseAlgorithmList> LicenseAlgorithmLists { get; set; }
        public virtual ICollection<UsedLicenseList> UsedLicenseLists { get; set; }
    }
}
