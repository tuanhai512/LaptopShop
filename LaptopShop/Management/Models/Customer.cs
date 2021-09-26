using System;
using System.Collections.Generic;

#nullable disable

namespace Management.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public virtual User User { get; set; }
    }
}
