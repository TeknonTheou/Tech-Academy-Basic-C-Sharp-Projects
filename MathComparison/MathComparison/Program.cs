using System;


namespace MathComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");//Request hourly rate for person 1
            string hourlyPay1 = Console.ReadLine();//input hourly rate for person 1
            double pay1 = Convert.ToDouble(hourlyPay1);//convert hourly rate to number
            Console.WriteLine("Hours Worked per week?");//Request number of hours per week for person 1
            string hoursWorked1 = Console.ReadLine();//accept hours per week for person 1
            double hours1 = Convert.ToDouble(hoursWorked1);//convert hours per week to number
            double Annual1 = (pay1 * hours1) * 52;//multiply hours worked by pay rate, times 52 weeks per year
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");//Request hourly rate for person 2
            string hourlyPay2 = Console.ReadLine();//input hourly rate for person 2
            double pay2 = Convert.ToDouble(hourlyPay2);//convert hourly rate to number
            Console.WriteLine("Hours Worked per week?");//Request number of hours per week for person 2
            string hoursWorked2 = Console.ReadLine();//accept hours per week for person 2
            double hours2 = Convert.ToDouble(hoursWorked2);//convert hours per week to number
            double Annual2 = (pay2 * hours2) * 52;//multiply hours worked by pay rate, times 52 weeks per year
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(Annual1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(Annual2);
            bool greaterThan = Annual1 > Annual2;//compare annual salaries
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(greaterThan);
            Console.ReadLine();
        }
    }
}
