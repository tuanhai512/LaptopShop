using Management.Models;
using Management.ViewModel.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    public class LoginController : Controller
    {
        private QLWBLTContext _context;

        public LoginController(QLWBLTContext context)
        {
            this._context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(CreateUserInput model)
        {

            if (model != null)
            {

                if (_context.Users.Any(x => x.Email == model.Email && x.Password == model.Password))
                {
                    ViewBag.Info = "Tài khoản đã tồn tại";
                    return View();
                }
                else
                {
                    var entity = new User();
                    var entityStaff = new Staff();
                    if (ModelState.IsValid)
                    {
                        entity = new User()
                        {
                            Name = model.Name,
                            Password = model.Password,
                            Id = model.Id,
                            Phone = model.Phone,
                            Email = model.Email,
                            BirthDay = model.BirthDay,
                            Address = model.Address,
                            Avatar = model.Avatar,
                        };
                        _context.Add(entity);
                        _context.SaveChanges();

                        entityStaff = new Staff()
                        {
                            Name = model.Name,
                            Password = model.Password,
                            Id = model.Id,
                            Phone = model.Phone,
                            Email = model.Email,
                            BirthDay = model.BirthDay,
                            Address = model.Address,
                            Avatar = model.Avatar,
                        };
                        _context.Add(entityStaff);
                        _context.SaveChanges();

                        return RedirectToAction("Index", "Product");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Vui lòng nhập dữ liệu");

                    }
                    return View(model);
                }

            }

            else
            {
                return View(model);
            }
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDTO model)
        {
           
            if(ModelState.IsValid)
            {
                var check = _context.Users.Where(s => s.Email == model.Email && s.Password == model.Password).FirstOrDefault();
                if (check == null)
                {
                    ViewBag.Info = "Tài khoản không tồn tại";
                    return View(model);
                }
                else
                {

                    if (_context.Staff.Any(s => s.Role.Name == "Manager"))
                    {

                        return RedirectToAction("Index", "Product");

                    }
                    else if (_context.Staff.Any(s => s.Role.Name == "Employee"))
                    {
                        return RedirectToAction("Index", "Category");

                    }
                    else
                    {
                        return View(model);
                    }
                }
               
            }   
            else
            {   
                ModelState.AddModelError("", "Vui lòng nhập đủ thông tin");
                return View(model);
            }    
           
        }          
    }
}
