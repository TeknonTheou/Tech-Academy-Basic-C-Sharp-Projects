using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a positive number and I will count to it.");//ask user for a number
            int choice = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
            Console.WriteLine("I will now count to your number...press enter to continue.");
            Console.ReadLine();//allows user to hit enter to continue program execution

            int i = 0;
            while (i<=choice)//while loop prints numbers from 0 to user's selected number
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(" ");

            Console.WriteLine("Can you guess my age?");//ask user for guess on age
            int number = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
            bool isGuessed = number == 43;//sets answer for age

            do//do while statement will continue to offer user a chance to guess until they get the answer correct
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");//request new guess
                        number = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");//request new guess
                        number = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");//request new guess
                        number = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
                        break;
                    case 43:
                        Console.WriteLine("You guessed my age as 43. That is correct!");//advise correct answer was chosen
                        isGuessed = true;//changes state of variable to true to end program
                        break;
                    default:
                        Console.WriteLine("That is incorrect...");//request new guess
                        Console.WriteLine("Try again.");//read input and convert to integer
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);//loop will continue until correct answer is chosen.

            Console.Read();
        }
    }
}