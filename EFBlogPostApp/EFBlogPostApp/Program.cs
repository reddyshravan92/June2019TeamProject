using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFBlogPostApp
{
    class Program
    {
        static void Main(string[] args)
        {

            BlogPostDbContext context = new BlogPostDbContext();

            //Blog blog = new Blog();
            //blog.Title = "EF Core";
            //blog.Author = "SAtya";
            //blog.CreatedDt = DateTime.Now;
            //blog.CreatedBy = "Satya";

            //context.Blogs.Add(blog);
            //context.SaveChanges();

            //Blog blogToPost = context.Blogs.Where(b => b.Id == 1).FirstOrDefault();
            //if(blogToPost != null)
            //{
            //    Post post = new Post();
            //    post.Title = "EF Code first approach";
            //    post.Author = "System generated";
            //    post.Blog = blogToPost;
            //    context.Posts.Add(post);
            //    context.SaveChanges();
            //}

            //Console.WriteLine(context.Blogs.Count());

            //var posts = context.Posts.ToList();
            //Console.WriteLine(posts.Count);
            //Console.WriteLine(posts.FirstOrDefault()?.Title);

            //Eager Loading
            //var firstPost = context.Posts.Include("Blog").Where(p => p.Id == 1).FirstOrDefault();
            //Console.WriteLine(firstPost?.Title);
            //Console.WriteLine(firstPost?.BlogId);
            //Console.WriteLine(firstPost?.Blog?.Title);

            //Lazy loading
            IList<Post> posts = context.Posts.ToList<Post>();

            var firstPost = posts[0];
            var postBlog = context.Blogs.Where(b => b.Id == firstPost.BlogId).FirstOrDefault();
            Console.WriteLine(postBlog?.Title);



        }
    }
}
