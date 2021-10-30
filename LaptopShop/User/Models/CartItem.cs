using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace User.Models
{
    public class CartItem
    {
        public int Masp { get; set; }
        public string Tensp { get; set; }
        public string Hinhanh { get; set; }
        public double Price { get; set; }
        public int Soluong { get; set; }
        public double Thanhtien => Soluong * Price;
        public class GioHang
        {
            [NotMapped]
            public string ErrorRegister { get; set; }
            List<CartItem> items = new List<CartItem>();
            public IEnumerable<CartItem> Items
            {
                get { return items; }
            }
            
            
            
        }
    }
}

