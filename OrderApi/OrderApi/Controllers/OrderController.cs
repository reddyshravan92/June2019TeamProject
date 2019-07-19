using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    /// <summary>
    /// This is an overall API for order management
    /// </summary>
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IRepository _repository;
        public OrderController(IRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// This is an API for exposing order data
        /// </summary>
        /// <returns></returns>
        [Route("api/orders")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return _repository.GetOrders();
        }


        /// <summary>
        /// This is an api for exposing order details for a givnen order
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/orders/{id}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<Order> GetOrderById(int id)
        {
            var order = _repository.GetOrderById(id);
            if(order == null)
            {
                return BadRequest("Invalid Order");
            }

            return order;
        }

        /// <summary>
        /// This is an api for creating a new order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [Route("api/orders")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult CreateOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model");
            }

            _repository.AddOrder(order);
            return Ok("Created");
        }
    }
}