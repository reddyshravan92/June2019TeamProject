using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASPNETCOREMVCDemoProject.Models;

namespace ASPNETCOREMVCDemoProject.Controllers
{
    
    public class BlogsController : Controller
    {
        private readonly BlogRepository _repository;

        public BlogsController()
        {
            this._repository = new BlogRepository();
        }
        // GET: Blogs
        public ActionResult Index()
        {
            var blogs = this._repository.GetBlogs();

            return View(blogs);
        }

        // GET: Blogs/Details/5
        public ActionResult Details(int id)
        {
            var blog = _repository.GetBlogById(id);
            return View(blog);
        }

        // GET: Blogs/Create
        public ActionResult Create()
        {
            var blog = new Blog();
            return View(blog);
        }

        // POST: Blogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog model)
        {
            try
            {
                // TODO: Add insert logic here
                _repository.AddBlog(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Blogs/Edit/5
        public ActionResult Edit(int id)
        {
            var blog = _repository.GetBlogById(id);
            return View(blog);
        }

        // POST: Blogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Blog blog)
        {
            try
            {
                // TODO: Add update logic here
                _repository.UpdateBlog(blog);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Blogs/Delete/5
        public ActionResult Delete(int id)
        {
            var blog = _repository.GetBlogById(id);
            return View(blog);
        }

        // POST: Blogs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _repository.RemoveBlog(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}