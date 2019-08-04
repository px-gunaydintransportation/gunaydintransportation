using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GunaydinTransporting.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gunaydin_Transporting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = new Users();
            user.Id = 1;
            user.Name = "Halil Şahin";
            user.Password = "hayuha12";
            user.PhoneNumber = "5534922220";
            return View(user);
        }
    }
}