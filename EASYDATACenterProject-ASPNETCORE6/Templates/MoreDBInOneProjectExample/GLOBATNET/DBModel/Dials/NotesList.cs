using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class NotesList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList User { get; set; } = null!;
    }
}
