using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Models
{
    public interface IRepository
    {
        List<Order> GetOrders();
        Order GetOrderById(int id);

        void AddOrder(Order order);

    }
}
