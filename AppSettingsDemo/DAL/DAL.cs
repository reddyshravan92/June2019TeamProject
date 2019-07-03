using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
    public class DataAcccessLogic
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;
        public DataAcccessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection();
            _connection.ConnectionString = _configuration.GetConnectionString("DefaultConnectionString");
            _connection.Open();
        }


        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Product";
            command.CommandType = CommandType.Text;
            command.Connection = _connection;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Category = reader["Category"].ToString()

                });
            }
            reader.Close();
            command.Dispose();
            return products;
        }
        
        public void AddProduct(Product entity)
        {
            string query = $"INSERT INTO Product (Name, Price, Category) VALUES('{entity.Name}',{entity.Price}, '{entity.Category}')";

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = _connection;

            command.ExecuteNonQuery();
            command.Dispose();

        }

        public void Dispose()
        {
            _connection.Close();
        }
    }
}
