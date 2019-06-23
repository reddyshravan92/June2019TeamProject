using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Models
{
    public class Customer : Person
    {
        public int Orders { get; set; }

        public Customer(int id, string firstName, string lastName, string email, int orders) : base(id, firstName,lastName,email)
        {
            this.Orders = orders;
        }

        public override string GetInfo()
        {
            //return base.GetInfo() + this.Orders;

            return $"Cust Id: {this.Id} Cust FirstName: {this.FirstName} Cust LastName: {this.LastName} Cust Email: {this.Email} Cust Orders: {this.Orders}";
        }
    }
}
