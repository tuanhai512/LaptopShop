using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Models;
using User.Helpers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using static User.Models.CartItem;
using TechTalk.SpecFlow.CommonModels;

namespace User.Controllers
{
    public class GioHangController : Controller
    {
        public const string CARTKEY = "cart";

        //List<CartItem> giohang = new List<CartItem>();
        private readonly QLWBLTContext _context;
        public GioHangController(QLWBLTContext context)
        {
            _context = context;
        }
        public List<CartItem> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }
                return data;
            }
        }
        public List<CartItemVM> CartsVM
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItemVM>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItemVM>();
                }
                return data;
            }
        }
        public IActionResult Index()
        {
            ViewBag.total = Carts.Sum(item => item.Price * item.Soluong);
            ViewBag.totalQty = Carts.Sum(item => item.Soluong);
            return View(Carts);
        }
        public IActionResult Index2()
        {                      
            return View(CartsVM);
        }
        public IActionResult AddToCart(int id, int ?amount)
        {
            //var myCart = Carts;
            //var item = myCart.SingleOrDefault(p => p.Masp == id);
            //if (item == null)
            //{
            //    var sanpham = _context.Products.SingleOrDefault(p => p.Id == id);
            //    item = new CartItem
            //    {
            //        Masp = id,
            //        Tensp = sanpham.Name,
            //        Price = sanpham.Price,
            //        Hinhanh = sanpham.Image,
            //        Soluong = soluong,
            //    };
            //    myCart.Add(item);
            //}
            //else
            //{
            //    item.Soluong += soluong;
            //}
            //HttpContext.Session.Set("GioHang", myCart);
            //return RedirectToAction("Index", "Home");
            try
            {
                List<CartItemVM> giohang = CartsVM;
                CartItemVM item = CartsVM.SingleOrDefault(p => p.product.Id == id);
                if (item != null)
                {
                    if (amount.HasValue)
                    {
                        item.amount = amount.Value;
                    }
                    else
                        amount++;
                }
                else
                {
                    Product db = _context.Products.SingleOrDefault(p => p.Id == id);
                    item = new CartItemVM
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = db
                    };
                    giohang.Add(item);

                }
                HttpContext.Session.Set("GioHang", giohang);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
           

        }
        public IActionResult UpdateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("GioHang");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].Masp == id)
                        {
                            dataCart[i].Soluong = quantity;
                        }
                    }


                    HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("GioHang");
                return Ok(quantity);
            }
            return BadRequest();

        }





    }
}