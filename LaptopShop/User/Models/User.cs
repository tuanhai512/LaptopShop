using System;
using System.Collections.Generic;

#nullable disable

namespace User.Models
{
    public partial class User
    {
        public User()
        {
            Customers = new HashSet<Customer>();
            staff = new HashSet<staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}
