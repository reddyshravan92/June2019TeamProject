using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreDemoProject.Models;


namespace ASPNETCoreDemoProject.Controllers
{
    [Route("blogs/")]
    public class BlogController : Controller
    {
        private readonly BlogRepository _repository;
        
        public BlogController()
        {
            this._repository = new BlogRepository();
        }
        public IActionResult Index()
        {
            var blogs = this._repository.GetBlogs();
            return View(blogs);
        }

        [Route("welcome")]
        public string Welcome(string message)
        {
            return $"hello..{message}";
        }

        [Route("login")]
        public bool Login(string username, string password)
        {
            var isValid = false;
            if(username == "satya" && password == "satya")
            {
                isValid = true;
            }
            return isValid ;
        }

        [Route("logMe")]
        [HttpGet]
        public IActionResult LogView()
        {
            var logModel = new LoginViewModel();
            return View(logModel);
        }

        [Route("logMe")]
        [HttpPost]
        public ActionResult LogView(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var username =  model.Username;
                //do something
            }

            return View(model);
        }
    }
}