using System;


namespace AbstractClass
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };//instantiate employee object
            employee.SayName();//call SayName method and implement on employee object
            Console.ReadLine();
        }
    }
}
