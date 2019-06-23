using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Models
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public Employee(int id, string firstName, string lastName, string email, decimal salary) : base(id, firstName, lastName, email)
        {
            this.Salary = salary;
        }

        public override string GetInfo()
        {
            //return base.GetInfo() + this.Salary;
            return $"Emp Id: {this.Id} Emp FirstName: {this.FirstName} Emp LastName: {this.LastName} Emp Email: {this.Email} Emp Salary: {this.Salary}";
        }
    }
}
