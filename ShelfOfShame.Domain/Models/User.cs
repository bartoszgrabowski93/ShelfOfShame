using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }     
        public string Password { get; set; }
        public ContactInfo Contact { get; set; }
        public string Nickname { get; set; } = String.Empty;
        public ICollection<Shelf> UserShelfs { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
