using Management.Models;
using Management.ViewModel.Role;
using Management.ViewModel.Staff;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var entityUser = new User();
            if (model != null)
            {
              
                var rolelist = _context.Roles.ToList().Select(
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = Convert.ToString(x.Id)
                });
                ViewBag.Roles = rolelist;
                if(ModelState.IsValid)
                {
                    entity = new Staff()
                    {
                        Id= model.Id,
                        Name = model.Name,
                        Email = model.Email,
                        Password = model.Password,
                        RoleId = model.RoleId
                    };                                       
                    _context.Add(entity);
                    _context.SaveChanges();

                    entityUser = new User()
                    {
                       Id = model.Id,
                        Name = model.Name,
                        Email = model.Email,
                        Password = model.Password,
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
        public IActionResult Edit(int id)
        {

            var entity = _context.Staff.Find(id);
            var model = new UpdateStaffInput();
           
            model.Id = entity.Id;
            model.Name = entity.Name;
            model.RoleId = entity.RoleId;
            
            return View(model);
        }
        [HttpPut]
        public IActionResult Edit(UpdateStaffInput model)
        {
            var entity = new Staff();
            var entityUser = new User();
            if (model == null)
                return NotFound();
            entity = new Staff()
            {
                Id = entity.Id,
                Name = entity.Name,
                RoleId = entity.RoleId,
                Email = entity.Email,
                Password = entity.Password
            };           
            this._context.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            this._context.SaveChanges();

            entityUser = new User()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Password = entity.Password
            };
            this._context.Entry(entityUser).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            this._context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var entity = this._context.Staff.Find(id);
            this._context.Staff.Remove(entity);

            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(DetailStaffDTO model, int id)
        {
            var query = from c in _context.Staff
                        where c.Id == id
                        select new DetailStaffDTO
                        {
                            Id = c.Id,
                            Name = c.Name,
                            RoleName = c.Role.Name,
                            Email = c.Email,
                            BirthDay = c.BirthDay,
                            Phone = c.Phone,
                            Address = c.Address,
                            
                        };

            return View(query.First());
        }
    }
}
