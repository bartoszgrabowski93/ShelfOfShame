using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class ItemShelves
    {
        public int ItemId { get; set; }
        public Item Item    { get; set; }
        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }
    }
}
