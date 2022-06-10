using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Methods
    {
        public int mathOp(int num)//define mathOp method
        {
            return num + 5;//add 5
        }
        public int mathOp(decimal num)//define mathOp method
        {
            decimal num1 = num *5;//multiply by 5
            int num2 = Convert.ToInt32(num1);//convert to integer
            return num2;//return answer
        }
        public int mathOp(string num)//define mathOp method
        { 
            int number = Convert.ToInt32(num);//convert to integer
            return number + 10;//multiply by 10
        }
    }
}
