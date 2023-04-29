﻿using System;
using System.Collections.Generic;

namespace GLOBALNET.DBModel
{
    public partial class VatList
    {
        public VatList()
        {
            ItemLists = new HashSet<ItemList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Value { get; set; }
        public bool Default { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<ItemList> ItemLists { get; set; }
    }
}
