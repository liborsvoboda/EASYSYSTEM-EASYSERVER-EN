using System;

namespace GlobalNET.Classes
{
    public partial class CurrencyList
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = null;
        public decimal ExchangeRate { get; set; } = 1;
        public bool Fixed { get; set; }
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Default { get; set; }
    }
}
