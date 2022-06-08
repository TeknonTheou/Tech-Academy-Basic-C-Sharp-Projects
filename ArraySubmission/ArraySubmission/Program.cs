using System;
using System.Collections.Generic;

namespace ArraySubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hello.", "Hi There!", "Yo!", "Howdy!", "Greetings!" };//create array of strings
            Console.WriteLine("Please select a number between 0 and 4");//advise user to select a number that will pull from that index
            int i = Convert.ToInt32(Console.ReadLine());//read number and convert to integer
            if ((i > stringArray.Length-1) || (i < 0))//determine if number is within range of array
            {
                Console.WriteLine("You have selected an invalid number, assigned function will not execute.");//print error if number is outside of array range
            }
            else
            {
                Console.WriteLine(stringArray[i]);//print string located at index if number is within array range
            }

            int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };//create array of integers
            Console.WriteLine("Please select a number between 0 and 6");//advise user to select a number that will pull from that index
            int o = Convert.ToInt32(Console.ReadLine());//read number and convert to integer
            if ((o > numArray.Length-1) || (o < 0))//determine if number is within range of array
            {
                Console.WriteLine("You have selected an invalid number, assigned function will not execute.");//print error if number is outside of array range
            }
            else
            {
                Console.WriteLine(numArray[o]);//print number located at index if number is within array range
            }

            List<string> stringList = new List<string>();//create list of strings
            stringList.Add("Konnichiwa");
            stringList.Add("Hola");
            stringList.Add("Nin Hao");
            stringList.Add("Merhaba");
            stringList.Add("Salut");
            Console.WriteLine("Please select a number between 0 and 4");//advise user to select a number that will pull from that index
            int p = Convert.ToInt32(Console.ReadLine());//read number and convert to integer
            if ((p > 4) || (p < 0))//determine if number is within range of list
            {
                Console.WriteLine("You have selected an invalid number, assigned function will not execute.");//print error if number is outside of list index range
            }
            else
            {
                Console.WriteLine(stringList[p]);//print string located at index if number is within array range
            }
            
            Console.ReadLine();
        }
    }
}
