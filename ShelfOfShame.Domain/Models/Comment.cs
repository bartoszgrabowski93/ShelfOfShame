using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string TextComment { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
    }
}
