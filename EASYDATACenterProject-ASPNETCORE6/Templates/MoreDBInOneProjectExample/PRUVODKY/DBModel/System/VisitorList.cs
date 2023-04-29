using System;
using System.Collections.Generic;

namespace PRUVODKY.DBModel
{
    public partial class VisitorList
    {
        public VisitorList()
        {
            VisitorIpLists = new HashSet<VisitorIpList>();
        }

        public int Id { get; set; }
        public string VisitorIp { get; set; } = null!;
        public bool? PhysicalUser { get; set; }
        public bool Contacted { get; set; }
        public DateTime? ContactDate { get; set; }
        public bool? PositiveContact { get; set; }
        public bool? NegativeContact { get; set; }
        public DateTime? NextContactWaiting { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? Note { get; set; }
        public string? WhoIs { get; set; }
        public string Timestamp { get; set; } = null!;

        public virtual ICollection<VisitorIpList> VisitorIpLists { get; set; }
    }
}
