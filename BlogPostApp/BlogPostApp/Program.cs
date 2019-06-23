using System;
using BlogPost.Models;
using BlogPost.Business;

namespace BlogPostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BlogBusiness business = new BlogBusiness();
            //Blog result = business.AddBlog(new Blog(1000, "React", "john@mgailcom") { BlogType = BlogType.Private});
            ////Console.WriteLine($"{result.Id} {result.Name} {result.CreatedBy} {result.CreatedDate}");
            //Console.WriteLine(result.BlogDetails);
            //Console.WriteLine($"MY blog type is: {result.BlogType} ");
            //Console.WriteLine((int)result.BlogType);
            //Console.WriteLine(Blog.Category);

            //switch (result.BlogType)
            //{
            //    case BlogType.Public:
            //        Console.WriteLine("YOu are creating public blog");
            //        break;
            //    case BlogType.Private:
            //        Console.WriteLine("private blog");
            //        break;
            //}



            //PostBusiness postBusiness = new PostBusiness(34567, "Api", "Satya");
            //Post post = postBusiness?.GetPost();
            ////if(post != null)
            ////{
            ////    Console.WriteLine(post.Id + " " + post.Title + " " + post.Author);
            ////}

            //Console.WriteLine(post?.Id + " " + post?.Title + " " + post?.Author);

            //inheritance
            //Employee employee = new Employee(111, "john", "smith", "john@gmail.com", 10000);
            //Console.WriteLine(employee.GetInfo());

            //inheritance
            //Customer customer = new Customer(101, "satya", "ps", "satya.p@gmailcom", 10);
            //Console.WriteLine(customer.GetInfo());

            //Overloading
            //BlogPost.Models.Math math = new BlogPost.Models.Math();
            //Console.WriteLine(math.Concate(1, 2));
            //Console.WriteLine(math.Concate("hello", "world"));


            Person p = new Person(1, "John", "Smith", "John@gmail.com");
            Console.WriteLine(p.GetInfo());

            Person emp = new Employee(1, "Scott", "John", "sctot@gmaic.com", 3343);
            Console.WriteLine(emp.GetInfo());

            Person cust = new Customer(2, "james", "james", "james@gmail.com" ,10);
            Console.WriteLine(cust.GetInfo());


        }
    }
}
