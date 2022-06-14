using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main()
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };//create instance of Employee Object

            Employee different = new Employee() { FirstName = "Sample", LastName = "Student", ID = 2 };//create a second instance (to demonstrate ID info being taken in)

            sample.SayName();//run 'SayName' method on first employee
            different.SayName();//run 'SayName' method on second employee

            Console.WriteLine("Employee IDs are the same? {0}.", sample == different);//Employee class takes ID separately from "person" class, entered method to verify ID is same/different


            Console.ReadLine();
        }
    }
}
