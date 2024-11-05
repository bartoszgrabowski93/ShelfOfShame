using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public abstract record Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserRating { get; set; }
        public int CriticsRating { get; set; }
        
    }
}
