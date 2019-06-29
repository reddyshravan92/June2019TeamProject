using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LinqDemos
{
    public class Category
    {
       public int Id { get; set; }
       public string Name { get; set; }
        public string Description { get; set; }

        dynamic dynamic = 100;

        public Category()
        {
            this.dynamic = "satya";
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //var evenData = from item in arr
            //               where item % 2 == 0
            //               select item;

            //evenData = evenData.OrderByDescending(ed => ed);
            //evenData = evenData.Select(ed => ed * ed);

            //foreach(var im in evenData)
            //{
            //    Console.WriteLine(im);
            //}

            //string [] names = { "John", "James", "Satya", "Ron", "Sarah" };

            //IEnumerable<string> resultSet = from name in names
            //                                where name.Length == 4
            //                                select name;


            //Console.WriteLine(resultSet.Count());

            List<Category> categories = new List<Category>()
            {
                new Category(){ Id = 1, Name ="Tech", Description = "Technology"},
                new Category(){ Id = 2, Name ="Texttile", Description="Texttile"}
            };


            List<Product> products = new List<Product>()
            {
                new Product(){Id=1001, Name = "IPad", Price = 1000, CategoryId = 1},
                new Product(){Id=1002,Name="IPhone", Price = 1500, CategoryId = 1 },
                new Product(){Id = 1003, Name = "Tommy", Price = 200, CategoryId = 2},
                new Product(){Id= 1004, Name = "American Eagle", Price= 500, CategoryId =2}
            };

            var resultData = from prod in products
                            join cat in categories on prod.CategoryId equals cat.Id
                            select new { ProductName = prod.Name, ProductPrice = prod.Price, CategoryName = cat.Name, CategoryDesc = cat.Description };
            resultData =  resultData.OrderBy(r => r.ProductName);
            resultData = resultData.TakeWhile( r => r.ProductPrice <= 1000);
            resultData = resultData.Skip(1);
            resultData = resultData.Where(r => r.CategoryName == "Tech");

            var fewElements = resultData.Select(r => new { Name = r.ProductName });
            
            foreach(var item in resultData)
            {
                Console.WriteLine(item.ProductName + " " + item.ProductPrice + " " + item.CategoryName);
            }


            ArrayList list = new ArrayList()
            {
                1100,
                "satya",
                200,
                "john",
                new Category(){Id = 1, Name = "Tech", Description="Technology"}
            };

            IEnumerable<int> listResult = list.OfType<int>();
            IEnumerable<string> listResult1 = list.OfType<string>();
            IEnumerable<Category> listResult2 = list.OfType<Category>();

            var nextREsult = listResult.Where(item => item % 2 == 0).ToList();

            list.Add(300);
            list.Add(101);
            Console.WriteLine(listResult.Count());
            Console.WriteLine(nextREsult.Count());



            //Grouping
            IEnumerable<IGrouping<int, Product>> productsByCategory = from prod in products
                                                                      group prod by prod.CategoryId
                                                                      into prodGroup
                                                                      select prodGroup;

            foreach(var prodData in productsByCategory)
            {
                Console.WriteLine($"Key {prodData.Key} ");
                var subTotal = prodData.Sum(p => p.Price);
                Console.WriteLine($"Sub total in category: {subTotal}");
                foreach(var prod in prodData)
                {
                    Console.WriteLine($"{prod.Name} {prod.Price}");
                }
            }


           











        }
    }
}
