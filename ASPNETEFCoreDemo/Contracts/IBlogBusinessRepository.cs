using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Contracts
{
    public interface IBlogBusinessRepository
    {
        List<Blog> GetBlogs();
        Blog GetBlogById(int id);
        void AddBlog(Blog entity);
        void UpdateBlog(Blog entity);
        void DeleteBlog(int id);
    }
}
