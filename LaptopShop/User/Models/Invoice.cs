using System;
using System.Collections.Generic;

#nullable disable

namespace User.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? Methods { get; set; }
        public int? Status { get; set; }
        public int? TotalMoney { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateAt { get; set; }

        public virtual Order Order { get; set; }
    }
}
