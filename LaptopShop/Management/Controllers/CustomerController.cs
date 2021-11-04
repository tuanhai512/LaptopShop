using Management.Models;
using Management.ViewModel.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class CustomerController : Controller
    {
        private QLWBLTContext _context;
        public CustomerController(QLWBLTContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = from c in _context.Staff
                        select new CustomerDTO
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Email = c.Email,                          
                        };
            return View(query.ToList());

        }
        public IActionResult Hide(int? id)
        {
            var query = from i in _context.Customers
                        where i.UserId == -1
                        select new CustomerDTO
                        {
                            Id = i.Id,
                            Name = i.Name,
                            Email = i.Email
                        };

            return View(query.ToList());
        }
        [HttpPost]
        public IActionResult Deactive(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Customer customer = _context.Customers.Find(id);
            if (customer.Status > 0)
            {
                customer.Status = -1;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerInput model)
        {
            var entity = new Customer();
            var entityUser = new User();
            if (model != null)
            {                      
                if (ModelState.IsValid)
                {
                    entity = new Customer()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Email = model.Email,
                        Password = model.Password
                    };
                    _context.Add(entity);
                    _context.SaveChanges();

                    entityUser = new User()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Email = model.Email,
                        Password = model.Password
                    };
                    _context.Add(entityUser);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
