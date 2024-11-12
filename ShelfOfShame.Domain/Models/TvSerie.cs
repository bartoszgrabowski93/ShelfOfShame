using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class TvSerie : Item
    {
        public string StreamingPlatform { get; set; }
        public bool HasUserStartedIt { get; set; }
        public bool IsItCompleted { get; set; }
        public int NumberOfSeasons { get; set; }
    }
}
