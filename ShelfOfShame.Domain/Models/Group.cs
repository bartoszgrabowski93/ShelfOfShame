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
        public string GroupNickname { get; set; } = String.Empty;
        public ICollection<UserGroup> UserGroups { get; set; }
    }
}
