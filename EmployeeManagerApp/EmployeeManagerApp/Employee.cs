using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagerApp
{
    public delegate void PropertyChanged(string message);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
    }

    public class EmployeeManager
    {
        private readonly Employee _employee;
        public PropertyChanged Callback { get; set; }

        public EmployeeManager(Employee employee)
        {
            _employee = employee;
        }

        public void UpdateSalary(decimal salary)
        {
            _employee.Salary = salary;
            Callback("Salary is updated");
        }

        public void UpdateTitle(string title, PropertyChanged propertyChanged)
        {
            
            if(_employee.Title != title)
            {
                //notify user
                propertyChanged($"Title is updated from {_employee.Title} to {title}");
                
            }
            _employee.Title = title;
            //Callback("Title is updated");
        }
    }
}
