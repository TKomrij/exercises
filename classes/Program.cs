﻿using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Console.WriteLine("Welcome to BingBip: A balloon company");

            // Create three employees
            List<Employee> employees = new List<Employee>
            {
               new Employee("Austin", "Parvin"),
               new Employee("Emily", "Loggins"),
               new Employee("Maya", "Pace")
            };
            Console.WriteLine(employees[0].FullName);

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
