using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NutritionWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWebApp.Controllers
{
    public class HomeController : Controller
    {
        private OurDbContext _context;
        public HomeController(OurDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.users.ToList());
        }

        public IActionResult Admin()
        {
            return View(_context.users.ToList());
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
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user_var)
        {
            if (ModelState.IsValid)
            {
                _context.users.Add(user_var);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user_var.name + " is success registered";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user_var)
        {
            if (user_var.Email == "admin@gmail.com" && user_var.Password=="admin")
            {
                //HttpContext.Session.SetString("UserID", user_var.Email);
                HttpContext.Session.SetString("UserID", user_var.UserID.ToString());
                HttpContext.Session.SetString("Email", user_var.Email);
                return RedirectToAction("Admin");
            }
            
            var account = _context.users.Where(u => u.Email == user_var.Email && u.Password == user_var.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserID.ToString());
                HttpContext.Session.SetString("Email", account.Email);

                HttpContext.Session.SetString("waist", account.waist.ToString());
                HttpContext.Session.SetString("weight", account.weight.ToString());
                HttpContext.Session.SetString("height", account.height.ToString());

                return RedirectToAction("Index", "Home"); // after successfull login user will be redirected to this 
            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong");
            }
            return View();
        }
        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Email");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        //public ActionResult Admin()
        //{
        //    if (HttpContext.Session.GetString("UserID") != null)
        //    {
        //        ViewBag.Username = HttpContext.Session.GetString("Email");
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //    }

        //}
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index"); // in index page we will show list of registered users
        }
    }
}
