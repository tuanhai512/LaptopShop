using Management.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class UserController : Controller
    {
        private QLWBLTContext _context;
        public UserController(QLWBLTContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
