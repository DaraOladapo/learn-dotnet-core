using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class BlankController : Controller
    {
        public IActionResult Index(int MyInt)
        {
            return View();
        } 
        public IActionResult FormIndex([FromForm]int MyInt)
        {
            return View();
        }  
        public IActionResult QueryIndex([FromQuery]int MyInt)
        {
            return View();
        }
        public IActionResult HeaderIndex([FromHeader]int MyInt)
        {
            return View();
        }
        public IActionResult RouteIndex([FromRoute]int MyInt)
        {
            return View();
        } 
        public IActionResult ServiceIndex([FromServices]int MyInt)
        {
            return View();
        }
        public IActionResult FormCollection(IFormCollection Form)
        {
            return View();
        }
        
    }
}
