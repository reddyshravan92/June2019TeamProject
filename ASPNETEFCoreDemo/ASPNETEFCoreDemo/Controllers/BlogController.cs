using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using DataAccess;
using Microsoft.Extensions.Configuration;

namespace ASPNETEFCoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _repository;

        public BlogController(IBlogRepository blogRepository)
        {
            _repository = blogRepository;
        }
        public IActionResult Index()
        {
            var blogs = _repository.GetBlogs();
            return View(blogs);
        }
    }
}