using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieTicketLibrary;
using Onlinemovie.Models;
using WebApplication2.Models;

namespace Onlinemovie.Controllers
{
    public class AdminController : Controller
    {
        AdminService service;
        public AdminController()
        {
            service = new AdminService();
        }
        public IActionResult Login()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Login(Credentials credentials)
        {
            try
            {
                int result = service.Login(credentials);
                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid userId or password.");
                    return View("Login", credentials);
                }
                return RedirectToAction("SearchView", "Search");
            }
            catch(Exception e)
            {
                ErrorViewModel m = new ErrorViewModel() { RequestId=e.Message };
                return View("Error",m);
            }
        }
        public IActionResult Entry()                //register
        {
            return View();
        }
       [AppErrorFilter]
       [HttpPost]
          public IActionResult Entry(Register register)
          {
            service.AddNew(register);
            return View("Login");
        }
        

    }
}