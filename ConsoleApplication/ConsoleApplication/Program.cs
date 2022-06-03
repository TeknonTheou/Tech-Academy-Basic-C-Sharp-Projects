using System;


namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number between -19999999999999 and 199999999999999");
            string number = Console.ReadLine();
            double number1 = Convert.ToDouble(number);
            double product = number1 * 50;
            Console.WriteLine("Your number times 50 = " + product);
            double sum = number1 + 25;
            Console.WriteLine("Your number plus 25 = " + sum);
            double quotient = number1 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + quotient);
            bool greaterThan = number1 > 50;
            Console.WriteLine("Your number is greater than 50? " + greaterThan);
            long seven = (long)number1 / 7;
            int neves = (int)number1%7;
            Console.WriteLine("Your number divided by 7 is " + seven + " with a remainder of " + neves);
            Console.ReadLine();
        }
    }
}
