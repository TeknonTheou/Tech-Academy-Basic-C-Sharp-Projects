using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Console.WriteLine("Please enter a whole number.");//request number from user
            int choice = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
            Console.WriteLine("Your number + 5 = " + number.addFive(choice) + ".");//run addFive method (adds 5)
            Console.WriteLine("Your number multiplied by 5 = " + number.timesFive(choice) + ".");//run timesFive method (multiplies by 5)
            Console.WriteLine("Your number divided by 2 = " + number.divTwo(choice) + ".");//run divTwo method (divides by 2)
            Console.ReadLine();
        }
    }
}
