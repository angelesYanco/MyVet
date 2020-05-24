using Microsoft.AspNetCore.Mvc;
using MyVet.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {

            }

            return View();
        }
    }
}
