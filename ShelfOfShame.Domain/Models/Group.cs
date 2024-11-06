using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = String.Empty;
        public List<User>? Users { get; set; }
    }
}
