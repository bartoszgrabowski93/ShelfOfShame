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
        public int MainCategoryId { get; set; }
        public virtual MainCategory MainCategory { get; set; }
        
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public decimal UserRatings { get; set; } = 0;

    }
}
