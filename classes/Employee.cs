using System;

namespace exercises
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
