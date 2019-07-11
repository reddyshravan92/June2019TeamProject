using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreDemoProject.Models;


namespace ASPNETCoreDemoProject.Controllers
{
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
    }
}