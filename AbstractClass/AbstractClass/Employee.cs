using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee: Person, AbstractClass.IQuittable //inherit from Person class and IQuittable interface
    {
        public override void SayName()//"override" the inherited SayName method from abstract Person class
        {
            base.SayName();//call the inherited SayName method
        }
        public void Quit()//"override" the inherited Quit method from IQuittable interface
        {
            Console.WriteLine("Employee {0} {1} has left the company.", FirstName, LastName);
        }
    }
}
