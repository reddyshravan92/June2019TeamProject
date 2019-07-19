using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Models
{
    public class Repository : IRepository
    {
        private readonly List<Order> _orders;

        public Repository()
        {
            _orders = new List<Order>()
            {
                new Order(){Id = 1, ProductName ="Mobiles", Qty = 10},
                new Order(){Id = 2, ProductName = "Laptops", Qty =20}
            };
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order GetOrderById(int id)
        {
            var order = _orders.Where(o => o.Id == id).FirstOrDefault();
            return order;
        }

        public List<Order> GetOrders()
        {
            return _orders;
        }
    }
}
