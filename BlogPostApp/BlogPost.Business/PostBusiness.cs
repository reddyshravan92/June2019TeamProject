using System;
using System.Collections.Generic;
using System.Text;
using BlogPost.Models;

namespace BlogPost.Business
{
    public class PostBusiness
    {
        private readonly Post _post;

        public PostBusiness(int? id, string title, string author)
        {
            _post = new Post();
            _post.Id = id ?? 100;
            _post.Title = title ?? "Agile";
            _post.Author = author ?? "John";
        }

        public Post GetPost()
        {
            return _post;
        }
    }
}
