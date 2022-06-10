using System;

namespace Page280Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageTwo averageTwo = new AverageTwo();

            int firstResponse = 0;//instantiate first input as 0
            int secondResponse = 0;//instantiate second input as 0
            string tempResponse = "";//instantiate blank entry

            bool validResponse = true;
            do
            {
                try
                {
                    Console.WriteLine("Input a whole number please.");//request first number
                    firstResponse = Convert.ToInt32(Console.ReadLine());//read user input and convert to integer as first input

                    Console.WriteLine("Second input is optional, type a whole number if you feel like it, then press enter.");//request second number
                    tempResponse = Console.ReadLine();
                    if (tempResponse != "") Convert.ToInt32(tempResponse); //this will throw an error and re-loop if user inputs a non whole number

                    validResponse = true;
                }
                catch
                {
                    validResponse = false;
                }


            } while (!validResponse);



            if (tempResponse == "")
            {
                Console.WriteLine("Averaged with 1: {0}", averageTwo.Average(firstResponse));//averages first number with default of 1 if no second number entered.
            }
            else
            {
                secondResponse = Convert.ToInt32(tempResponse);
                Console.WriteLine("Average: {0}", averageTwo.Average(firstResponse, secondResponse));//averages both numbers together
            }

            Console.ReadLine();
        }
    }
}
