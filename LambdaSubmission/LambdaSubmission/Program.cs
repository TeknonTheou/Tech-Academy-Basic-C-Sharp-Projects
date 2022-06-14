using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Bales", ID = 1 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Smith", ID = 2 };
            Employee employee3 = new Employee() { FirstName = "James", LastName = "Kirk", ID = 3 };
            Employee employee4 = new Employee() { FirstName = "Montgomery", LastName = "Scott", ID = 4 };
            Employee employee5 = new Employee() { FirstName = "Hikaru", LastName = "Sulu", ID = 5 };
            Employee employee6 = new Employee() { FirstName = "Leonard", LastName = "McCoy", ID = 6 };
            Employee employee7 = new Employee() { FirstName = "Christine", LastName = "Chapel", ID = 7 };
            Employee employee8 = new Employee() { FirstName = "Pavel", LastName = "Chekov", ID = 8 };
            Employee employee9 = new Employee() { FirstName = "Christopher", LastName = "Pike", ID = 9 };
            Employee employee10 = new Employee() { FirstName = "Nyota", LastName = "Uhura", ID = 10 };
            List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

           
            Console.WriteLine("Ships Crew:"); //Display full list
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID:" + employee.ID);
            }
            Console.WriteLine();

            
            List<Employee> namedJoe = new List<Employee>();//create Joe list
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    namedJoe.Add(employee);
                }
            }

            
            Console.WriteLine("Guys Named Joe:");//display joe list
            foreach (Employee guy in namedJoe)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName + " ID:" + guy.ID);
            }
            Console.WriteLine();

            
            List<Employee> namedJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();//create Joe list 2

           
            Console.WriteLine("Guys Named Joe from lambda:"); //display joe list 2
            foreach (Employee guy in namedJoe2)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName + " ID:" + guy.ID);
            }
            Console.WriteLine();

           
            List<Employee> ID5 = employees.Where(x => x.ID > 5).ToList(); //create ID5 List

            
            Console.WriteLine("Employees with ID > 5:");//display ID5 List
            foreach (Employee employee in ID5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID:" + employee.ID);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
