using System;
using BlogPost.Models;

namespace BlogPost.Business
{
    public class BlogBusiness
    {
        public Blog GetBlog()
        {
            Blog blog = new Blog();
            //blog.Id = 1;
            //blog.Name = "C#";
            //blog.CreatedBy = "Satya";
            //blog.CreatedDate = DateTime.Now;

            return blog;
        }

        public Blog AddBlog(Blog entity)
        {
            return entity;
        }
    }
}
