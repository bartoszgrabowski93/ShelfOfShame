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
        public string Name { get; set; } = String.Empty;
        public int CategoryId {  get; set; }
    }
}
