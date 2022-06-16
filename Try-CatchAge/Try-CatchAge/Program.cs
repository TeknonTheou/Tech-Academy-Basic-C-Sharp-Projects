using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_CatchAge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("What is your age on your birthday this year?");//request user's age
                    int age = Convert.ToInt32(Console.ReadLine());//read input and convert age to integer
                    if (age < 1) throw new NotSupportedException();//throw exception if age under 1 year
                    TimeSpan ageInYears = TimeSpan.FromDays(age * 365);//convert age integer into years
                    DateTime yearOfBirth = DateTime.Now - ageInYears;//determine year of birth by subtracting from current year
                    Console.WriteLine("You were born in {0}", yearOfBirth.Year);//display user's year of birth
                    Console.ReadLine();
                    validInput = true;//convert validInput to true to end loop.

                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Please input at least one year.");//request positive number for years
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occured, please run around in circles until you enter a valid format.");//loop until valid format (whole number) is entered.
                    Console.ReadLine();
                }
            }
        }
    }
}
