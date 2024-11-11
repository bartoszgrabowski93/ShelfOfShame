using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class UserGroup
    {
        public int UserId { get; set; }
        public User UserRef { get; set; }
        public int GroupId { get; set; }
        public Group GroupRef { get; set; }
    }
}
