using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOInput
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a whole number.");//request a number
            bool validInput = false;//sets default boolean to false
            string input = "";//instantiates string variable "input"
            while (!validInput)//loop through try/catch until validInput is true
            {
                try
                {
                    input = Console.ReadLine();//read user input
                    Convert.ToInt32(input);//convert user input to integer if possible
                    validInput = true;//change validInput to true if able to convert
                }
                catch
                {
                    Console.WriteLine("Whole numbers only!");//request a whole number again
                    validInput = false;//keeps validInput as false
                }
            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\Tekno\source\repos\Tech-Academy-Basic-C-Sharp-Projects\FileIOInput\number.txt", false))
            {
                file.WriteLine(input);//write input to file listed above
            }

            string fileText = File.ReadAllText(@"C:\Users\Tekno\source\repos\Tech-Academy-Basic-C-Sharp-Projects\FileIOInput\number.txt");
            Console.WriteLine("The number you entered was {0}", fileText);//print number from file listed above
            Console.ReadLine();
        }
    }
}
