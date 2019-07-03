using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DAL;

namespace Business
{
    public class CategoryBusiness
    {
        private readonly CategoryDAL _dal;

        public CategoryBusiness(CategoryDAL dal)
        {
            this._dal = dal;
            
        }

        public List<Category> GetCategories()
        {
            return _dal.GetCategories();
        }
    }
}
