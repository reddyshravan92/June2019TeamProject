using System;
using System.Collections.Generic;
using System.Text;
using Models;
namespace DataAccess
{
    public interface IBlogRepository
    {
        List<Blog> GetBlogs();
        Blog GetBlogById(int id);
        void AddBlog(Blog entity);
    }
}
