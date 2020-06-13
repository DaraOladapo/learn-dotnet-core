using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portal.Models;
using Portal.Models.Data;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Student = new Student() { FirstName = "Dara", LastName = "Oladapo" };
            return View(Student);
        }

        [NonAction]
        public void SayHi()
        {

        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
