using Management.Models;
using Management.ViewModel.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class RoleController : Controller
    {
        private QLWBLTContext _context;
        
        public RoleController(QLWBLTContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = from r in _context.Roles
                        select new RoleDTO
                        {
                            Id = r.Id,
                            Name = r.Name
                        };
            return View(query.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateRoleInput model)
        {
            var entity = new Role();
            if (model == null)
                entity = new Role();
            entity.Id = model.Id;
            entity.Name = model.Name;
            _context.Add(entity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id )
        {
            var entity = this._context.Roles.Find(id);
            var model = new UpdateRoleInput();
            model.Id = entity.Id;
            model.Name = entity.Name;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit (UpdateRoleInput model)
        {
            var entity = new Role();
            if (model == null)
                return NotFound();
            entity.Id = model.Id;
            entity.Name = model.Name;
            this._context.Entry(entity).State = EntityState.Modified;
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var entity = this._context.Roles.Find(id);
            this._context.Roles.Remove(entity);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            var query = from r in _context.Roles
                        where r.Id == id
                        select new DetailRoleDTO
                        {
                            Id = r.Id,
                            Name = r.Name
                        };
            return View(query.First());
        }
    }
}
