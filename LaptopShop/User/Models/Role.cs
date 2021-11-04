using System;
using System.Collections.Generic;

#nullable disable

namespace User.Models
{
    public partial class Role
    {
        public Role()
        {
            staff = new HashSet<staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
