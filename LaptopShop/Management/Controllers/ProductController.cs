using Management.Models;
using Management.ViewModel.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;
using Management.ViewModel.Categories;

namespace Management.Controllers
{
    public class ProductController : Controller
    {
        private QLWBLTContext _context;
        private IWebHostEnvironment _webHostEnvironment;

        public ProductController(QLWBLTContext context, IWebHostEnvironment webHostEnvironment)
        {
            this._context = context;
            this._webHostEnvironment = webHostEnvironment;

        }
        public IActionResult Index()
        {         
                var query = from c in _context.Products
                            select new ProductDTO
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Price = c.Price,
                                Description = c.Description,
                                CategoryName = c.Category.Name,
                                CategoryId = c.CategoryId,
                                Quantity = c.Quantity,
                                Image = c.Image
                            };
                return View(query.ToList());
         
          
        }
     
        public IActionResult Create()
        {
            var categorylist = _context.Categories.ToList().Select(
            x => new SelectListItem
            {
                Text = x.Name,
                Value = Convert.ToString(x.Id)
            }
           );
                ViewBag.Categories = categorylist;
                return View();      
          
        }
        [HttpPost]
        public IActionResult Create(CreateProductInput model )
        {        
            var entity = new Product();
            if (model != null)
            {           
                entity = new Product();
                var categorylist = _context.Categories.ToList().Select(
                x => new SelectListItem
                {
                    Text = x.Name,
                    Value = Convert.ToString(x.Id)
                }
                );
                ViewBag.Categories = categorylist;
                if (model.UploadImage != null)
                {
                    string filename = Path.GetFileNameWithoutExtension(model.UploadImage.FileName);
                    string extent = Path.GetExtension(model.UploadImage.FileName);
                    filename = filename + extent;
                    model.Image = "/Images/" + filename;
                    model.UploadImage.CopyTo(new FileStream(Path.Combine("wwwroot/Images", filename), FileMode.Create));
                    model.UploadImage.CopyTo(new FileStream(Path.Combine("../User/wwwroot/Images", filename), FileMode.Create));
                }
                entity.Image = model.Image;
                if (ModelState.IsValid )
                {                  
                        entity.Id = model.Id;
                        entity.Name = model.Name;
                        entity.Price = model.Price.HasValue ? model.Price.Value : 0;
                    entity.Quantity = model.Quantity.HasValue ? model.Quantity.Value : 0;
                    entity.Description = model.Description;
                        entity.CategoryId = model.CategoryId;
                        _context.Add(entity);
                        _context.SaveChanges();
                        return RedirectToAction("Index");                   
                }                       
                else
                {
                 
                    return View();
                }              
            }
            else
            {
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
           
            var entity = _context.Products.Find(id);
            var model = new UpdateProductInput();
            var categorylist = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categorylist, "Name", "Name");
           
            model.Id = entity.Id;
            model.Name = entity.Name;
            model.Price = entity.Price;
            model.Quantity = entity.Quantity;
            model.Description = entity.Description;
            
            model.CategoryId = entity.CategoryId;
            model.Image = entity.Image;
            return View(model);
        }
        [HttpPut]
        public IActionResult Edit(UpdateProductInput model )
        {
            var entity = new Product();
            if (model == null)
                return NotFound();

            var categorylist = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categorylist, "Name", "Name");

            if (model.UploadImage != null)
            {
                string filename = Path.GetFileNameWithoutExtension(model.UploadImage.FileName);
                string extent = Path.GetExtension(model.UploadImage.FileName);
                filename = filename + extent;
                model.Image = "/Images/" + filename;

                model.UploadImage.CopyTo(new FileStream(Path.Combine("wwwroot/Images", filename), FileMode.Create));
                model.UploadImage.CopyTo(new FileStream(Path.Combine("../User/wwwroot/Images", filename), FileMode.Create));

            }
            entity.Id = model.Id;
            entity.Name = model.Name;
            entity.Price = model.Price.HasValue ? model.Price.Value : 0;
            entity.Quantity = model.Quantity.HasValue ? model.Price.Value : 0;
            entity.Description = model.Description;        
            entity.CategoryId = model.CategoryId;
            entity.Image = model.Image;
      
            this._context.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var entity = this._context.Products.Find(id);
            this._context.Products.Remove(entity);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail( DetailProductDTO model , int id)
        {
            var query = from c in _context.Products
                        where c.Id == id
                        select new DetailProductDTO
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Price = c.Price,
                            Quantity = c.Quantity,
                            Description = c.Description,
                            Image = c.Image,
                            CategoryId = c.CategoryId
                        };

            return View(query.First());
        }
    }
}
