using System;
using System.Collections.Generic;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<String> sample = new Employee<String>() { FirstName = "Doctor", LastName = "Seuss", ID = 1 };////create instance of Employee Object
            sample.Things = new List<string> { "One Fish", "Two Fish", "Red Fish", "Blue Fish" };//assign list of strings to "Things"

            Employee<int> different = new Employee<int>() { FirstName = "Theodor", LastName = "Geisel", ID = 2 };//create a second instance
            different.Things = new List<int> { 1, 2, 77, 45 };//assign list of integers to "Things"

            sample.SayName();//run 'SayName' method on first employee
            sample.ListThings();//run 'ListThings' method on first employee

            Console.WriteLine("");

            different.SayName();//run 'SayName' method on second employee
            different.ListThings();//run 'ListThings' method on second employee

            Console.WriteLine("\nEmployee IDs are the same? {0}.", sample.ID == different.ID);//compare employee ID numbers to verify if same or different

            Console.ReadLine();
        }
    }
}
