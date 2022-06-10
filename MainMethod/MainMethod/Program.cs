using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            Console.WriteLine("Please enter a whole number");//request number
            int choice = Convert.ToInt32(Console.ReadLine());//convert to integer
            Console.WriteLine(methods.mathOp(choice));//print results of method
            Console.WriteLine("Please enter a decimal number");//request decimal
            decimal choice1 = Convert.ToDecimal(Console.ReadLine());//convert to decimal
            Console.WriteLine(methods.mathOp(choice1));//print results of method
            Console.WriteLine("Please enter a whole number");//request number (all input is considered string)
            string choice2 = Console.ReadLine();//read input (does not convert)
            try
            {
                Console.WriteLine(methods.mathOp(choice2));//print results of method
            }
            catch (Exception)
            {
                Console.WriteLine("Item entered does not convert to a whole number.");//print if incorrect format entered.
            }
            Console.ReadLine();
        }   
    }
}
