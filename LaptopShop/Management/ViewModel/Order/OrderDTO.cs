using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.ViewModel.Order
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int? Total { get; set; }
        public int? Status { get; set; }
    }
}
