using System;
using System.Collections.Generic;

#nullable disable

namespace User.Models
{
    public partial class staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
