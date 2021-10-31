using Management.Models;
using Management.ViewModel.Order;
using Management.ViewModel.ProductOrder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class OrderController : Controller
    {
        private QLWBLTContext _context;
        public OrderController(QLWBLTContext context)
        {
            this._context = context;
        }
        public ActionResult Index()
        {
            var query = from c in _context.Orders
                        where c.Status == 0
                        select new OrderDTO
                        {
                            Id = c.Id,
                            Status = c.Status,          
                            Total = c.Total,                                                      
                        };
            return View(query.ToList());
        }
        public ActionResult Confirm(int? id)
        {
            var query = from c in _context.Orders
                        where c.Status == 1
                        select new OrderDTO
                        {
                            Id = c.Id,
                            Status = c.Status,
                            Total = c.Total,
                        };
            return View(query.ToList());
        }
        public ActionResult XacNhan(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Order order = _context.Orders.Find(id);
            if (order.Status == 0)
            {
                order.Status = 1;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Complete(int? id)
        {
            var query = from c in _context.Orders
                        where c.Status == 2
                        select new OrderDTO
                        {
                            Id = c.Id,
                            Status = c.Status,
                            Total = c.Total,
                        };
            return View(query.ToList());
        }
        public ActionResult HoanTat(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
           
            Order order = _context.Orders.Find(id);
            if (order.Status == 1)
            {
                if (ModelState.IsValid)
                {
                    var invoice = new Invoice()
                    {
                        OrderId = order.Id,
                        TotalMoney = order.Total,
                        CreateAt = DateTime.Now,                     
                    };
                    _context.Invoices.Add(invoice);
                    _context.SaveChanges();
              
                    order.Status = 2;                 
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");

        }
        public ActionResult Cancel(int? id)
        {
            var query = from c in _context.Orders
                        where c.Status == 3
                        select new OrderDTO
                        {
                            Id = c.Id,
                            Status = c.Status,
                            Total = c.Total,
                        };
            return View(query.ToList());
        }
        public ActionResult Huy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Order order = _context.Orders.Find(id);
            if (order.Status == 1)
            {
                order.Status = 3;
            }           
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        
    }
}
