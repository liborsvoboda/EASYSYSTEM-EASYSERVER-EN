using System;
using System.Linq;

namespace GlobalNET.Classes {

    public partial class ItemList {
        public int Id { get; set; } = 0;
        public string PartNumber { get; set; } = null;
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public string Unit { get; set; } = null;
        public decimal Price { get; set; } = 1;
        public int VatId { get; set; }
        public int CurrencyId { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public partial class ExtendedItemList : ItemList {

        public string Vat { get; set; } = null;
        public string Currency { get; set; } = null;

        public ExtendedItemList() { }

        public ExtendedItemList(ItemList ch) {
            foreach (var prop in ch.GetType().GetProperties())
            { this.GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(ch, null), null); }
        }
    }
}
