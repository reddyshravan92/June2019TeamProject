using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace AppSettingsDemo
{
    public class Program
    {
        private static IConfiguration configuration;
        static void Main(string[] args)
        {
            Initialize();
            //Console.WriteLine(configuration.GetConnectionString("DefaultConnectionString"));
            //Console.WriteLine(configuration["EmailSettings:SmtpServer"]);
            SqlConnection connection = null;
            SqlCommand command = null;
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = configuration.GetConnectionString("DefaultConnectionString");

                connection.Open();
                Console.WriteLine("connetion is open");

                command = new SqlCommand();
                command.CommandText = "SELECT * FROM [dbo].Product";
                command.CommandType = CommandType.Text;
                command.Connection = connection;

               SqlDataReader reader = command.ExecuteReader();

                if(reader != null)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                    }

                    reader.Close();
                }

               
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                command.Dispose();
                connection.Close();
                Console.WriteLine("connection is closed");
            }
        }

        static void Initialize()
        {
            var builder = new ConfigurationBuilder()
                           .SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();
        }
    }
}
