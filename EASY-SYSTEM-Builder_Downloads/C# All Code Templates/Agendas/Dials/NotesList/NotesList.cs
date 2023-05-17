using System;

namespace GlobalNET.Classes {

    public partial class NotesList {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}