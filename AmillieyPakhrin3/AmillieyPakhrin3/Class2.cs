using System;
using System.Collections.Generic;
using System.Linq;

/*namespace LINQEmployee
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }

    class Q2
    {
        static void Main()
        {
            // Sample employee data
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ram", Address = "Kathmandu", Salary = 60000 },
                new Employee { Id = 2, Name = "Sita", Address = "Lalitpur", Salary = 55000 },
                new Employee { Id = 3, Name = "Hari", Address = "Kathmandu", Salary = 45000 },
                new Employee { Id = 4, Name = "Gita", Address = "Kathmandu", Salary = 70000 },
                new Employee { Id = 5, Name = "John", Address = "Pokhara", Salary = 80000 }
            };

            // LINQ query
            var filtered = from emp in employees
                           where emp.Salary > 50000 && emp.Address == "Kathmandu"
                           select emp;

            // Display result
            Console.WriteLine("Employees with salary > 50000 and address = Kathmandu:");
            foreach (var emp in filtered)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}, Salary: {emp.Salary}");
            }
        }
    }
}*/

