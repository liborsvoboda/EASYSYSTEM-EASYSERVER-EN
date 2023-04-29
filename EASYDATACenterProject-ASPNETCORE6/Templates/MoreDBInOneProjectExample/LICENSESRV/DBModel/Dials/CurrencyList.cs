﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LICENSESRV.DBModel
{
    public partial class CurrencyList
    {
        public CurrencyList()
        {
            ItemLists = new HashSet<ItemList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal ExchangeRate { get; set; }
        public bool Fixed { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Default { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public virtual UserList User { get; set; } = null!;
        public virtual ICollection<ItemList> ItemLists { get; set; }
    }
}
