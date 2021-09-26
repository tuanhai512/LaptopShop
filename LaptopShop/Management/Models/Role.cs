using System;
using System.Collections.Generic;

#nullable disable

namespace Management.Models
{
    public partial class Role
    {
        public Role()
        {
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Staff> staff { get; set; }
    }
}
