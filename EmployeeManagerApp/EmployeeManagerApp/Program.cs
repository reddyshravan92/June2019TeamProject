using System;
using System.Collections;

namespace EmployeeManagerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager _manager = new EmployeeManager(new Employee()
            {
                Id = 101, 
                Name = "Satya",
                Title = "Project Lead",
                Salary = 100000
            });

            //_manager.Callback = Notify;
            _manager.Callback = ((string message) => Console.WriteLine(message));


            //_manager.UpdateTitle("Scrum Master", Callback);
            //_manager.UpdateTitle("Project Lead", Notify);

            _manager.UpdateTitle("Scrum Master", ( (msg) => Console.WriteLine(msg)));
            _manager.UpdateTitle("Project Lead", ((msg) => Console.WriteLine("From " + msg)));

            _manager.UpdateSalary(5000);


            MathOp op1 = ((arg) => arg % 2 == 0);
            MathOp op2 = ((arg) => arg == 100);

            if (op1(7))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            if (op2(102))
            {
                Console.WriteLine("Valid");
            }


            ArrayList list = new ArrayList();
            list.Add("pne");

            Hashtable table = new Hashtable();
            table.Add(1, "SAtya");
            Console.WriteLine(table.Count);


            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Length) ;


        }

        public static void Callback(string message)
        {
            Console.WriteLine(message);
        }

        public static void Notify(string message)
        {
            Console.WriteLine("Notified from server " + message);
        }
    }
}
