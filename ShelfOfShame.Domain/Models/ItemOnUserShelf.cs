using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class ItemOnUserShelf : Item
    {
        public int UserRef { get; set; }
        public int ItemRef { get; set; }
        public decimal UserRating { get; set; }
        public DateTime DateItemAddedOnShelf { get; set; } = DateTime.Now;
    }
}
