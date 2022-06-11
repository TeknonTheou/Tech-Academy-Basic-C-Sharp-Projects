using System;


namespace Page285Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider divider = new Divider();//Instantiate class Divider
            Console.WriteLine("Input a whole number to be divided by two.");//request user input
            int input = Convert.ToInt32(Console.ReadLine());//read user input and convert to integer
            int result;//create variable for method result
            divider.DivTwo(input, out result);//call Method

            Console.WriteLine("Answer: {0}", result);//display results of method

            Console.WriteLine("Input a whole number to be divided by three.");//request user input
            input = Convert.ToInt32(Console.ReadLine());//read user input and convert to integer
            int remainder;//create variable for method remainder
            StaticDivider.DivThree(input, out result, out remainder);//call Method

            Console.WriteLine("Answer: {0}", result);//display results of method
            Console.WriteLine("Remainder: {0}", remainder);//display remainder of method

            Console.WriteLine("Input a floating point number to be divided by three.");//request user input
            float floatInput = Convert.ToSingle(Console.ReadLine());//read user input and convert to float
            float floatResult;//create variable for method result
            StaticDivider.DivThree(floatInput, out floatResult);//call Method

            Console.WriteLine("Answer: {0}", floatResult);//display results of method

            Console.ReadLine();
        }
    }
}
