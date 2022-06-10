using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideByTwo divide = new DivideByTwo();
            int firstAnswer = 0;
            int secondAnswer = 0;
            Console.WriteLine("Input a whole number to be divided by two: ");//request whole number (note...result of operation  not displayed on screen. Display not noted in assignment requirements)
            firstAnswer = Convert.ToInt32(Console.ReadLine());//convert input to integer
            Console.WriteLine("Input a second whole number to display on the screen");//request whole number
            secondAnswer = Convert.ToInt32(Console.ReadLine());//convert input to integer
            divide.Divide(firstAnswer, secondAnswer);//call method passing input numbers
            divide.Divide(first: 6, second: 2);//call method, specifying parameters by name
            Console.ReadLine();
        }
    }
}
