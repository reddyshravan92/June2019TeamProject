using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreModelsDemo.Models;

namespace ASPNETCoreModelsDemo.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string Title { get; set; }

       
        public IActionResult Index()
        {
            var products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = ".NET Core"
            });
            products.Add(new Product()
            {
                Id =2,
                Name ="EF core"
            });

            return View(products);
        }

        public IActionResult Details(int id)
        {
            ViewData["ActionName"] = "Details View";
            ViewBag.FullName = "Satya";

            return View(new Product() { Id =1, Name = "Asp.net Core"});
        }
        public IActionResult Privacy()
        {
            Title = "Privacy app";
            return View();
        }

        public IActionResult Contact()
        {
            Title = "TEst App";
            return View();
        }
    }
}
