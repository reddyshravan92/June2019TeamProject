using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreDemoProject.Models
{
    public class BlogRepository
    {
        private List<Blog> _blogs;

        public BlogRepository()
        {
            this._blogs = new List<Blog>();
            this._blogs.Add(new Blog()
            {
                Id = 1, 
                Title = "Satya Blog",
                Author= "Satya"
            });

            this._blogs.Add(new Blog()
            {
                Id = 2,
                Title = ".NET Core",
                Author = "MSDN"
            });
        }

        public List<Blog> GetBlogs()
        {
            return this._blogs;
        }
    }
}
