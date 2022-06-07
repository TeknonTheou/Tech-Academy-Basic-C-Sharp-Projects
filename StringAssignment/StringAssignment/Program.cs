using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");//request first name
            StringBuilder name = new StringBuilder(Console.ReadLine());//read first name string 
            Console.WriteLine("What is your middle name?");//request middle name
            name.Append(" " + Console.ReadLine());//add middle name to name string
            Console.WriteLine("What is your last name?");//request last name
            name.Append(" " + Console.ReadLine());//add last name to name string
            string word1 = "Hello, ";//assign word1
            string word2 = ", I hope you are doing well.";//assign word2
            string sentence = word1.ToUpper() + name + word2;//Concatenate word1 (in all caps) with name string and word 2.
      
            Console.WriteLine(sentence);//output completed sentence.
            Console.ReadLine();
        }
    }
}
