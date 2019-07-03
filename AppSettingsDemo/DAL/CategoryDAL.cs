using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class CategoryDAL
    {
        private readonly SqlConnection _connection;
        private readonly IConfiguration _configuration;

        public CategoryDAL(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection();
            _connection.ConnectionString = _configuration.GetConnectionString("DefaultConnectionString");
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", _connection);
            DataSet resultSet = new DataSet();
            adapter.Fill(resultSet, "category");
            DataTable categoryTable = resultSet.Tables["category"];
            for(var i = 0; i < categoryTable.Rows.Count; i++)
            {
                categories.Add(new Category()
                {
                    Id = Convert.ToInt32( categoryTable.Rows[i]["Id"]),
                    Name = categoryTable.Rows[i]["Name"].ToString(),
                    Description = categoryTable.Rows[i]["Description"].ToString()

                });
            }
            
            return categories;
        }
    }
}
