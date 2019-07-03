using System;
using Models;
using DAL;
using System.Collections.Generic;
namespace Business
{
    /// <summary>
    /// You can write all the business logic here
    /// </summary>
    public class BusinessLogic
    {
        private readonly DataAcccessLogic _dal;

        /// <summary>
        /// Here, you can initialize the DAL
        /// </summary>
        /// <param name="dal"></param>
        public BusinessLogic(DataAcccessLogic dal)
        {
            this._dal = dal;
        }

        /// <summary>
        /// This is to get all the products from DAL
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            //additional validation

            return _dal.GetProducts();
        }


        public void AddProduct(Product entity)
        {
            _dal.AddProduct(entity);
        }
       
    }
}
