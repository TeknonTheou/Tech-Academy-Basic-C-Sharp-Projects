using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person//create abstract class
    {
        public string FirstName { get; set; }//set parameter for first name
        public string LastName { get; set; }//set parameter for last name

        public virtual void SayName()//create SayName method
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);//write name to display
        }
    }
}
