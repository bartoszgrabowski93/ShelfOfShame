using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int YearReleased { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int UserRating { get; set; } = 0;
        public int CriticsRating { get; set; } = 0;
        
    }
}
