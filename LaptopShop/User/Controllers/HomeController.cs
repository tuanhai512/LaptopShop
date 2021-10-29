using Management.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using User.Models;

namespace User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        QLWBLTContext db = new QLWBLTContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> pro = db.Products.ToList();
            var query = from c in db.Products
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
