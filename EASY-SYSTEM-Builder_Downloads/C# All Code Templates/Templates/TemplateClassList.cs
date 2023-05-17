using System;

/**
 * Start Class Template
 * ONLY Replace 'TemplateClassList' and DataFields [DATASET] with your Table Name
 */

namespace GlobalNET.Classes {

    public partial class TemplateClassList {
        public int Id { get; set; } = 0;
        public string SystemName { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public partial class ExtendedTemplateClassList : TemplateClassList {

        public string Currency { get; set; }  
        public string TotalCurrency { get; set; }


        public ExtendedTemplateClassList() { }
        public ExtendedTemplateClassList(ItemList ch) {
            foreach (var prop in ch.GetType().GetProperties())
            { this.GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(ch, null), null); }
        }
    }

    public partial class TemplateClassListWithLocalTranslation {
        public int Id { get; set; } = 0;
        public string SystemName { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Translation { get; set; } = null;
    }


}