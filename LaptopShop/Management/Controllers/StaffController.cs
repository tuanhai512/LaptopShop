using Management.Models;
using Management.ViewModel.Role;
using Management.ViewModel.Staff;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class StaffController : Controller
    {
        private QLWBLTContext _context;
        public StaffController( QLWBLTContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = from c in _context.Staff
                        select new StaffDTO
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Email = c.Email,
                            RoleName = c.Role.Name,                   
                        };
            return View(query.ToList());
           
        }
        public IActionResult Create()
        {
           var rolelist = _context.Roles.ToList().Select(
           x => new SelectListItem
           {
               Text = x.Name,
               Value = Convert.ToString(x.Id)
           }
          );
            ViewBag.Roles = rolelist;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateStaffInput model)
        {
            var entity = new Staff();
            if(model != null)
            {
                entity = new Staff();
                var rolelist = _context.Roles.ToList().Select(
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = Convert.ToString(x.Id)
                });
                ViewBag.Roles = rolelist;
                if(ModelState.IsValid)
                {
                    entity.Id = model.Id;
                    entity.Name = model.Name;
                    entity.Email = model.Email;
                    entity.Password = model.Password;
                    entity.RoleId = model.RoleId;
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
