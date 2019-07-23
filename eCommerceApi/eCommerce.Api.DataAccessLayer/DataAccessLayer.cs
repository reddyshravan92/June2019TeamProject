using System;
using eCommerce.Api.Models;
using eCommerce.Api.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce.Api.DataAccessLayer
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly IConfiguration _configuration;
        private readonly eCommerceDbContext _context;

        public DataAccessLayer(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._context = new eCommerceDbContext(this._configuration.GetConnectionString("DefaultConnectionString"));
        }
        public async Task AddCustomer(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task AddOrder(Order order)
        {
            _context.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task AddProduct(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public Task<List<Category>> GetCategories()
        {
            return this._context.Categories.ToListAsync();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByCustomerId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.Include("Category").Include("Supplier").ToListAsync();
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            return await _context.Suppliers.ToListAsync();
        }
    }
}
