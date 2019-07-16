using System;
using Models;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _context;

        public BlogRepository()
        {
            _context = new BlogDbContext();
        }

        public List<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }

        public void AddBlog(Blog entity)
        {
            this._context.Blogs.Add(entity);
            this._context.SaveChanges();
        }

        public Blog GetBlogById(int id)
        {
            var blog = _context.Blogs.Where(b => b.Id == id).FirstOrDefault();
            return blog;
        }

    }
}
