using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age? (Full years only, please)");//ask age
            int age = Convert.ToInt32(Console.ReadLine());//read age and convert to integer
            bool mature = age > 15;//verify if age is over 15


            Console.WriteLine("True or False...you have had a DUI?");//ask about DUI
            bool dUi = bool.Parse(Console.ReadLine());//read DUI response and convert to bool


            Console.WriteLine("How many speeding tickets do you have?");//Ask how many speeding tickets
            int speeding = Convert.ToInt32(Console.ReadLine());//read number of tickets and convert to integer
            bool tickets = speeding <=3;//verify no more than 3 tickets

            Console.WriteLine("Qualified?");
            Console.WriteLine(mature && !dUi && tickets);//verify qualification
            Console.ReadLine();
        }
    }
}
