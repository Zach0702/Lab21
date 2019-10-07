using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabNumber21.Models;

namespace LabNumber21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register register)
        {
            if (ModelState.IsValid)
            {

                return View(register);
            }
            return View(register);
        }
        //[HttpPost]
        //public ActionResult Register(Register register)
        //{
        //    if (string.IsNullOrEmpty(register.FirstName))
        //    {
        //        ModelState.AddModelError("FirstName", "First name is a required field");
        //    }
        //    if (string.IsNullOrEmpty(register.LastName))
        //    {
        //        ModelState.AddModelError("LastName", "Last name must be entered");
        //    }
        //    if (string.IsNullOrEmpty(register.EMail))
        //    {
        //        ModelState.AddModelError("EMail", "Email must be entered");
        //    }
        //    if (string.IsNullOrEmpty(register.OnlinePassword))
        //    {
        //        ModelState.AddModelError("OnlinePassword", "Password must be entered");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    else
        //    {
        //        return View(register);
        //    }

        //}

        public IActionResult AddUser(Register userRegister)
        {
            return View(userRegister);
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
