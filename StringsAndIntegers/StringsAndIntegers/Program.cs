using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 30, 40, 60, 70, 90, 160, 750, 830};//create list
            Console.WriteLine("There is a list of numbers within this application.");
            try
            {
                Console.WriteLine("Pick a number by which the system will divide these numbers.");//request a number by which to divide numbers in list
                int numberOne = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
                foreach (var number in numbers)//create foreach loop to iterate through list
                {
                    Console.WriteLine(number + " divided by " + numberOne + " equals " + (number / numberOne));//show result of division
                }
                
            }
            catch (FormatException ex)//displays error if incorrect input (such as string) is entered.
            {
                Console.WriteLine(ex.Message + " Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)//displays error if user enters zero.
            {
                Console.WriteLine(ex.Message + " Please do not divide by zero");
            }
            catch (Exception ex)//displays general error messages
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I hope you liked this demonstration.");//displays final message
                Console.ReadLine();//requires hitting enter to close application
            }
        }
    }
}
