using System;

namespace PRUVODKY.Classes
{
    public partial class PersonList
    {
        public int Id { get; set; } = 0;
        public int GroupId { get; set; }
        public int PersonalNumber { get; set; }
        public string Name { get; set; } = null;
        public string SurName { get; set; } = null;
        public int UserId { get; set; } = 0;
        public DateTime? Timestamp { get; set; } = null;

    }

    public partial class ExtendedPersonList : PersonList
    {
        public string Group { get; set; } = null;
    }

}
