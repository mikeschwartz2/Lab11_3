using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(string fname, string lname, string email, string phone, string uname, string password)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["passwod"] = password;
            ViewData["Phone"] = phone;
            ViewData["username"] = uname;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Order(UserReg register)
        {
            if (ModelState.IsValid)
            {
                return View(register);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("Index", register);
            }
        }
    }
}
