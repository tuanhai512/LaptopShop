using System;
using System.Collections.Generic;

#nullable disable

namespace Management.Models
{
    public partial class Order
    {
        public Order()
        {
            Invoices = new HashSet<Invoice>();
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }
        public int? Total { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
