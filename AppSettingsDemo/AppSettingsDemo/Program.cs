using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using Models;
using Business;
using DAL;
using System.Linq;

namespace AppSettingsDemo
{
    public class Program
    {
        private static IConfiguration configuration;
        static void Main(string[] args)
        {
            Initialize();

            DataAcccessLogic _dal = new DataAcccessLogic(configuration);

            BusinessLogic _business = new BusinessLogic(_dal);

            var products = _business.GetProducts();

            Console.WriteLine(products.Count);
            Console.WriteLine(products.FirstOrDefault()?.Name);

            _business.AddProduct(new Product() {Name="Keyboard", Price = 100, Category = "Hardware" });
            _dal.Dispose();


            CategoryDAL _categoryDAL = new CategoryDAL(configuration);
            CategoryBusiness categoryBusiness = new CategoryBusiness(_categoryDAL);
            var categories = categoryBusiness.GetCategories();

            Console.WriteLine(categories.Count);
            Console.WriteLine(categories.FirstOrDefault()?.Name);

        }

        static void Initialize()
        {
            var builder = new ConfigurationBuilder()
                           .SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();
        }
    }
}
