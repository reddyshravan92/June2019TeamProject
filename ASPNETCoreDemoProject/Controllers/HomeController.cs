using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemoProject.Controllers
{
    public class HomeController : Controller
    {
       public string Index()
        {
            return "Hello from MVC";
        }

        public string HelloWorld()
        {
            return "Hello world!";
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}