using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight in pounds:");//request package weight
            float weight = float.Parse(Console.ReadLine());//read package weight
            if (weight>50)//determine if package exceeds 50 pound weight limit
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//if package too heavy, advise and end quote program
            }
            else
            {
                Console.WriteLine("Please enter the package width in inches");//request package width
                float width = float.Parse(Console.ReadLine());//read package width

                Console.WriteLine("Please enter the package height in inches");//request package height
                float height = float.Parse(Console.ReadLine());//read package height

                Console.WriteLine("Please enter the package length in inches");//request package length
                float length = float.Parse(Console.ReadLine());//read package length

                float size = width + height + length;//determine total size of package
                float price = (width * height * length * weight)/100;//determine price of shipping

                string result = size>50 ? "Package is too big to be shipped via Package Express" : "Your estimated total for shipping this package is: $" + price + ". \nThank you!";//if package too large, advise and end program - otherwise, give quote
                Console.WriteLine(result);//print size advice or quote
            }
            Console.ReadLine();
        }
    }
}
