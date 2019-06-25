using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Models
{
    public class Employee : Person
    {
        private decimal _Salary;
        public decimal Salary
        {
            get
            {
                return _Salary;
            }

            set
            {
                if(value < 5000)
                {
                    throw new CustomException("Amount should be more than 5000");
                }
                else
                {
                    this._Salary = value;
                }
            }
        }
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
