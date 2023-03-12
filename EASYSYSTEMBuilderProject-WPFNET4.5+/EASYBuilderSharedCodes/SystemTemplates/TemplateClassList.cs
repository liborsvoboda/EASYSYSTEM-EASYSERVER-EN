using System;

namespace GlobalNET.Classes
{
    /// <summary>
    /// Example of Table Dataset
    /// </summary>
    public partial class TemplateClassList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    /// <summary>
    /// Example of extended Table dataset for user friendly
    /// </summary>
    public partial class ExtendedTemplateClassList : TemplateClassList
    {
        public string TotalCurrency { get; set; }
    }
}
