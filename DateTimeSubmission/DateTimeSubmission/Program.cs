using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The current time is: " + DateTime.Now);//display current time to console
            Console.WriteLine("Greetings!  Please enter a whole number.");//request number
            bool validInput = false;//sets default boolean to false
            string input = "";//instantiates string variable "input"
            int number = 0;//instantiates integer variable "number"
            while (!validInput)//loop through try/catch until validInput is true
            {
                try
                {
                    input = Console.ReadLine();//read user input
                    number = Convert.ToInt32(input);//convert user input to integer if possible
                    validInput = true; change validInput to true if able to convert
                }
                catch
                {
                    Console.WriteLine("Whole numbers only, please!");//request a whole number again
                    validInput = false;//keeps validInput as false
                }
            }

            TimeSpan hours = TimeSpan.FromHours(number);//set number of hours to match input integer

            Console.WriteLine("In {0} hours, it will be {1}", number, DateTime.Now + hours);//output what time it will be in the number of hours entered.
            Console.ReadLine();
        }
    }
}
