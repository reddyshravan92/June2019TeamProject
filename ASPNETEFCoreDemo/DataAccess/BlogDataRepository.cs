using System;
using Models;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Collections.Generic;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BlogDataRepository : IBlogDataRepository
    {
        private readonly BlogDbContext _context;

        public BlogDataRepository(IConfiguration configuration)
        {
            _context = new BlogDbContext(configuration.GetConnectionString("DefaultConnectionString"));
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

        public void UpdateBlog(Blog blog)
        {
            var dbBlog = _context.Blogs.Where(b => b.Id == blog.Id).FirstOrDefault();
            dbBlog.Title = blog.Title;
            dbBlog.Author = blog.Author;
            dbBlog.UpdatedBy = blog.UpdatedBy;
            dbBlog.UpdatedDt = blog.UpdatedDt;
            _context.SaveChanges();
        }

        public void DeleteBlog(int id)
        {
            var blog = _context.Blogs.Where(b => b.Id == id).FirstOrDefault();
            if(blog != null)
            {
                _context.Blogs.Remove(blog);
                _context.SaveChanges();
            }
        }
    }
}
