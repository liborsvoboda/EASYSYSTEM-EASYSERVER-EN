using System;

namespace PRUVODKY.Classes
{
    public partial class WorkList
    {
        public int Id { get; set; } = 0;
        public DateTime Date { get; set; }
        public int PersonalNumber { get; set; }
        public int WorkPlace { get; set; }
        public int OperationNumber { get; set; }
        public TimeSpan WorkTime { get; set; }
        public int Pcs { get; set; }
        public decimal Amount { get; set; }
        public decimal WorkPower { get; set; }
        public int UserId { get; set; } = 0;
        public DateTime? Timestamp { get; set; } = null;

    }

    public partial class ExtendedWorkList : WorkList
    {
        public string FullName { get; set; } = null;
    }

    public partial class PersonalList
    {
        public int PersonalNumber { get; set; }
        public string FullName { get; set; } = null;
        public string FullInfo { get; set; } = null;
    }
}
