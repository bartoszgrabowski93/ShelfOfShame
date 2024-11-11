using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class OnShelfItem
    {
        public int Id { get; set; }        
        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }        
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int ReviewRef { get; set; }
        public Review Review { get; set; }
    }
}
