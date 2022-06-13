using System;
using System.Collections.Generic;


namespace GenericParameters
{
    public class Employee<T> : Person
    {
        public int ID { get; set; }
        public List<T> Things { get; set; }

        public void ListThings()//create loop to display list of things to console
        {
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
            }
        }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)//add operator that checks IDs to determine if same or different
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)//add operator that checks IDs to determine if same or different
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            return false;
        }
    }
}
