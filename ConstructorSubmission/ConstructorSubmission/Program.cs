using System;
using System.Collections.Generic;


namespace ConstructorSubmission
{
    class Program
    {
        static void Main()
        {
            const string storeName = "Billy's Pet Shop";//create const variable for store name
            Animal bird = new Animal("Polly the parrot", 2);//build new Animal
            Animal dog = new Animal("Bailey the beagle");//build second animal
            var animals = new List<Animal>() { bird, dog };//create list of animals under "var"


            Console.WriteLine("Welcome to {0}, This is our current inventory.", storeName);//display const variable
            Console.WriteLine("Animals:");
            foreach (Animal animal in animals)//write each animal in list to console.
            {
                Console.WriteLine("Name: {0}, Number of legs: {1}", animal.Name, animal.NumLegs);
            }

            Console.WriteLine("Wow, we could really use some more animals...");
            Console.ReadLine();
        }
    }
}
