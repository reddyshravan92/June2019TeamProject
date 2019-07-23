using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Api.Models;
using eCommerce.Api.Contracts;

namespace eCommerceApi.Controllers
{
    [Route("api/eCommerce/")]
    [ApiController]
    public class eCommerceController : ControllerBase
    {
        private readonly IBusinessLayer _businessLayer;

        public eCommerceController(IBusinessLayer businessLayer)
        {
            this._businessLayer = businessLayer;
        }
        
        /// <summary>
        /// Api to return list of categories.
        /// </summary>
        /// <returns></returns>
        [Route("categories")]
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await this._businessLayer.GetCategories();
        }

        /// <summary>
        /// Api to return list of Suppliers.
        /// </summary>
        /// <returns></returns>
        [Route("suppliers")]
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSuppliers()
        {
            return await this._businessLayer.GetSuppliers();
        }

        /// <summary>
        /// Add New Product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("products")]
        [HttpPost]
        public async Task<ActionResult> AddProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model");
            }

            await _businessLayer.AddProduct(model);

            return Ok("Added");
        }

        /// <summary>
        /// Get the list of products
        /// </summary>
        /// <returns></returns>
        [Route("products")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _businessLayer.GetProducts();
        }


        /// <summary>
        /// This is for adding an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [Route("orders")]
        [HttpPost]
        public async Task<ActionResult> AddOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }

            await _businessLayer.AddOrder(order);
            return Ok("added an order");
        }
    }
}