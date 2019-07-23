using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Api.Models;

namespace eCommerce.Api.Contracts
{
    public interface IDataAccessLayer
    {
        Task<List<Category>> GetCategories();
        Task<List<Supplier>> GetSuppliers();

        Task AddOrder(Order order);
        Task<Order> GetOrderById(int id);
        Task<List<Order>> GetOrders();

        Task AddCustomer(Customer customer);
        Task<Customer> GetCustomerById(int id);
        Task<List<Order>> GetOrdersByCustomerId(int id);

        Task AddProduct(Product product);
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
    }
}
