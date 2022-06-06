using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight in pounds:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight<=50)
            {
                Console.WriteLine("Please enter the package width in inches");
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
        }
    }
}
