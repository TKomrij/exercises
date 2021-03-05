using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public Employee(string firstName, string lastName, string title, DateTime hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            HireDate = hireDate;
        }

    }
}
