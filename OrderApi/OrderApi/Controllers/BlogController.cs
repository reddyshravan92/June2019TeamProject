using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogPost.Business;
using BlogPost.Models;

namespace OrderApi.Controllers
{
    
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogBusiness _business;

        public BlogController()
        {
            _business = new BlogBusiness();
        }

        /// <summary>
        /// This is an api for getting blogs
        /// </summary>
        /// <returns></returns>
        [Route("api/blogs")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<Blog> GetBlogs()
        {
            return _business.GetBlog();
        }
    }
}