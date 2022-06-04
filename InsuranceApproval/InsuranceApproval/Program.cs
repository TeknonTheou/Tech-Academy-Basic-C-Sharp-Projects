using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age? (Full years only, please)");//ask age
            string howOld = Console.ReadLine();//read age
            int age = Convert.ToInt32(howOld);//convert age to integer
            bool mature = age > 15;//verify if age is over 15
            Console.WriteLine("True or False...you have had a DUI?");//ask about DUI
            string drink = Console.ReadLine();//Read DUI response
            bool dUi = bool.Parse(drink);//convert DUI response to bool
            bool sober = !dUi;//reverse bool (because a "false" answer to this question would mean "true" towards qualification)
            Console.WriteLine("How many speeding tickets do you have?");//Ask how many speeding tickets
            string fast = Console.ReadLine();//read how many tickets
            int speeding = Convert.ToInt32(fast);//convert number of tickets to integer
            bool tickets = speeding <=3;//verify no more than 3 tickets
            Console.WriteLine("Qualified?");
            Console.WriteLine(mature && sober && tickets);//verify qualification
            Console.ReadLine();
        }
    }
}
