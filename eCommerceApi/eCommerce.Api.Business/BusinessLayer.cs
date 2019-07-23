using System;
using eCommerce.Api.Models;
using eCommerce.Api.Contracts;
using eCommerce.Api.DataAccessLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerce.Api.Business
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IDataAccessLayer _dataAccessLayer;

        public BusinessLayer(IDataAccessLayer dataAccessLayer)
        {
            this._dataAccessLayer = dataAccessLayer;
        }

        public Task AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task AddOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            await _dataAccessLayer.AddOrder(order);
        }

        public async Task AddProduct(Product product)
        {
            await _dataAccessLayer.AddProduct(product);
        }

        public async Task<List<Category>> GetCategories()
        {
            return await this._dataAccessLayer.GetCategories();
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

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dataAccessLayer.GetProducts();
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            return await _dataAccessLayer.GetSuppliers();
        }
    }
}
