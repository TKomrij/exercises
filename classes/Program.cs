using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Console.WriteLine("Welcome to BingBip: A balloon company");

            // Create three employees
            List<Employee> employees = new List<Employee>()
            {
               new Employee("Austin", "Parvin", "Manager", new DateTime(2012, 12, 24)),
               new Employee("Emily", "Loggins", "Saleswoman", new DateTime(2015, 6, 07)),
               new Employee("Maya", "Pace", "Saleswoman", new DateTime(1999, 3, 30))
            };

            Company BingBip = new Company("BingBip", new DateTime(1954, 7, 14), employees);

            // Assign the employees to the company


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            BingBip.ListEmployees(employees, BingBip);
        }
    }
}
