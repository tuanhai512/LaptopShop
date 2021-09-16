using Management.Models;
using Management.ViewModel.Categories;
using Management.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class CategoryController : Controller
    {
        private QLWBLTContext _context;
        public static List<Category> listCategory = new List<Category>();
        public CategoryController( QLWBLTContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = from c in _context.Categories
                        select new CategoryDTO
                        { 
                            ID = c.Id,
                            Name = c.Name 
                        };
            return View(query.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryInput model)
        {
            var entity = new Category();
            if (model == null)
                entity = new Category();
            entity.Name = model.Name;
            _context.Add(entity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit( int id )
        {
            var entity = this._context.Categories.Find(id);
            var model = new UpdateCategoryInput();
            model.ID = entity.Id;
            model.Name = entity.Name;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit( UpdateCategoryInput model)
        {
            var entity = new Category();
            if (model == null)
                return NotFound();
            entity.Id = model.ID;
            entity.Name = model.Name;
            this._context.Entry(entity).State = EntityState.Modified;
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var entity = this._context.Categories.Find(id);
            this._context.Categories.Remove(entity);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            var query = from c in _context.Categories
                        where c.Id == id
                        select new DetailCategoryDTO
                        {
                            ID = c.Id,
                            Name = c.Name
                        };
            
            return View(query.First());   
        }
       
    }
}
