﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class Film : Item
    {
        public string StreamingPlatform { get; set; }
        public string Genre { get; set; }
    }
}
