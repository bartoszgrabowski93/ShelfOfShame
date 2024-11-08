using ShelfOfShame.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        
    }
}
