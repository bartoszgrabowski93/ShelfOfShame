﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class Shelf
    {
        public int Id { get; set; }        
        public int MainCategoryId {  get; set; }
        public virtual MainCategory MainCategory { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ItemShelves> ItemShelves { get; set; }
    }
}
