using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyAspNetCore.Models;

namespace UdemyAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        //yks.com.tr / Home/Index
        public IActionResult Index()
        {
            // viewbag, viewdata, tempdata,model
            ViewBag.Name = "Tuba";
            ViewData["Name"] = "Remi";
            TempData["Name"] = "Behram";

            Customer customer = new() { Age = 27, FirstName = "Remi", LastName = "Köse" };
            //return View(customer);
            return RedirectToAction("Tuba");
        }

        public IActionResult Tuba()
        {
            //business =?> db veri çekiyor olabilirim
            return View();
        }
    }
}
