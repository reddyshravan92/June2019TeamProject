using System;
using System.Linq;

namespace EFDbFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogDbContext _context = new BlogDbContext();
            Console.WriteLine(_context.Blogs.Count());
            Blog firstBlog = _context.Blogs.FirstOrDefault();
            Console.WriteLine(firstBlog?.Title);

            Blog blog = _context.Blogs.Where(b => b.Id == 2).FirstOrDefault();
            Console.WriteLine(blog?.Title);

            //add new entry
            Blog blogToAdd = new Blog();
            blogToAdd.Title = "Satya Blog";
            blogToAdd.Author = "Satya";
            blogToAdd.CreatedDt = DateTime.Now;
            blogToAdd.CreatedBy = "Satya";

            _context.Blogs.Add(blogToAdd);
            _context.SaveChanges();

            //Update script
            Blog blogToUpdate = _context.Blogs.Where(b => b.Id == 2).FirstOrDefault();
            blogToUpdate.Title = "blog updated - .net core";
            blogToUpdate.UpdatedDt = DateTime.Now;
            blogToUpdate.UpdatedBy = "System";
            _context.Update(blogToUpdate);
            _context.SaveChanges();


            //Delete script
            Blog blogToRemove = _context.Blogs.Where(b => b.Id == 3).FirstOrDefault();
            if(blogToRemove != null)
            {
                _context.Blogs.Remove(blogToRemove);
                _context.SaveChanges();
            }
           


        }
    }
}
