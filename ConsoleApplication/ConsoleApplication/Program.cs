using System;


namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number between -19999999999999 and 199999999999999");
            string number = Console.ReadLine();
            double number1 = Convert.ToDouble(number);
            double product = number1 * 50;
            Console.WriteLine("Your number times 50 = " + product);
            double sum = number1 + 25;
            Console.WriteLine("Your number plus 25 = " + sum);
            double quotient = number1 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + quotient);
            bool greaterThan = number1 > 50;
            Console.WriteLine("Your number is greater than 50? " + greaterThan);
            long seven = (long)number1 / 7;
            int neves = (int)number1%7;
            Console.WriteLine("Your number divided by 7 is " + seven + " with a remainder of " + neves);
            int num1 = 7;
            if (num1<18 && ((num1==7)||num1==2)&& ((num1==8 && num1>20) || (num1<20 && num1>2)))
            { Console.WriteLine("Wow, that was confusing.");}
            int num2 = 12;
            int num3 = 2;
            int num4 = 8;
            if (num1 <= num2 && num4 >= num3)
            { Console.WriteLine("The if statement ran.");}
            else { Console.WriteLine("The else statement ran.");}
            string result = num1>num2? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            if (name == "Billy")
            { Console.WriteLine("You must be this computer's owner...");}
            else if (name == "Molly")
            { Console.WriteLine("You must be the computer owner's wife...");}
            else 
            { Console.WriteLine("You are not this computer's owner.  What are you doing on here? :-P");}
            Console.ReadLine();
        }
    }
}
