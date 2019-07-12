using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCOREMVCDemoProject.Models
{
    public class BlogRepository
    {
        private readonly List<Blog> _blogs;

        public BlogRepository()
        {
            _blogs = new List<Blog>()
            {
                new Blog()
                {
                    Id = 1, 
                    Title = "ASP.NET core",
                    Author = "Satya"
                }
            };
        }

        public List<Blog> GetBlogs()
        {
            return this._blogs;
        }

        public Blog GetBlogById(int id)
        {
            return this._blogs.Where(b => b.Id == id).FirstOrDefault();
        }

        public void AddBlog(Blog blog)
        {
            this._blogs.Add(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            //update logic
        }

        public void RemoveBlog(int id)
        {
            var blog = this._blogs.Where(b => b.Id == id).FirstOrDefault();
            if(blog != null)
            {
                this._blogs.Remove(blog);
            }
        }
    }
}
