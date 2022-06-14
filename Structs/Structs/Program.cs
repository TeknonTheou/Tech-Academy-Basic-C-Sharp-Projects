using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main()
        {
            Number number = new Number();//instantiate Number
            number.Amount = 2;//assign value of 2 to "Amount" property
            Console.WriteLine(number.Amount);//Print value of "Amount" to display.
            Console.ReadLine();
        }
    }

    struct Number//create struct Number
    {
        public decimal Amount { get; set; }//set "amount" property
    }
}

