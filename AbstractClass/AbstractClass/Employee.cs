using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee: Person//inherit from Person class
    {
        public override void SayName()//"override" the inherited SayName method
        {
            base.SayName();//call the inherited SayName method
        }
    }
}
