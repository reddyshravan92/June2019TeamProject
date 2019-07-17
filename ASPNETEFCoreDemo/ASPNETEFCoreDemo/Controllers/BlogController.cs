using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Contracts;

namespace ASPNETEFCoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogBusinessRepository _repository;

        public BlogController(IBlogBusinessRepository blogRepository)
        {
            _repository = blogRepository;
        }

        public IActionResult Index()
        {
            var blogs = _repository.GetBlogs();
            return View(blogs);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var blog = new Blog();
            return View(blog);
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Modal is not valid");
            }

            _repository.AddBlog(blog);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var blog = _repository.GetBlogById(id);
            return View(blog);
        }

        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }

            _repository.UpdateBlog(blog);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var blog = _repository.GetBlogById(id);
            return View(blog);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _repository.DeleteBlog(id);
            return RedirectToAction("Index");
        }
    }
}