using System;

namespace PRUVODKY.Classes
{
    public partial class OperationList
    {
        public int Id { get; set; } = 0;
        public int WorkPlace { get; set; }
        public string PartNumber { get; set; } = null;
        public int OperationNumber { get; set; }
        public string Note { get; set; } = null;
        public int PcsPerHour { get; set; }
        public decimal KcPerKs { get; set; }
        public int UserId { get; set; } = 0;
        public DateTime? Timestamp { get; set; } = null;

    }

    public partial class WorkPlaceList
    {
        public int WorkPlace { get; set; }
        public string WorkPlacePartNumberOperation { get; set; } = null;
    }

    public partial class PartNumberList
    {
        public int WorkPlace { get; set; }
        public string PartNumber { get; set; } = null;
        public string Name { get; set; } = null;
        public int OperationNumber { get; set; }
    }

}
