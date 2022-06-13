using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the current day of the week.");//request input from user
            DayOfTheWeek day = 0;//instantiate day object
            bool validInput = false;//default value set to false
            while (!validInput)//will loop through try/catch until a valid response is entered
            {
                try
                {
                    string input = Console.ReadLine();//read user input
                    input = input.ToLower();//converts input to lower case (this prevents error due to camel casing, lower case input, all caps, etc.)
                    string firstLetter = input.ToUpper().Substring(0, 1);//capitalizes first letter only
                    input = firstLetter + input.Substring(1);//input now has capitol letter at front
      
                    validInput = Enum.TryParse(input, out day);//Enum.TryParse(takes in "input", attempts to convert to/return enum "day")
                    if (!validInput) throw new Exception();
                }
                catch
                {
                    validInput = false;
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

            Console.WriteLine("You have entered " + day + ".");

            Console.ReadLine();
        }
    }
    public enum DayOfTheWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
}
