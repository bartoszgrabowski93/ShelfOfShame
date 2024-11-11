using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Domain.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FacebookRef { get; set; }
    }
}
