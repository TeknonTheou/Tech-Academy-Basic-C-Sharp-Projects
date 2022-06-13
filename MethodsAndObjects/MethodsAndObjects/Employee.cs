using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)//add operator that checks IDs to determine if same or different
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee employee1, Employee employee2)//C# requires matching operator to be defined.
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            return false;
        }
    }
}
