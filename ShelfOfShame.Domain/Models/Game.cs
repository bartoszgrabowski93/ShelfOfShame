﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class Game : Item
    {
        public bool IsItStarted { get; set; }
        public string SourcePlatform { get; set; }
        public string Genre { get; set; }
    }
}
