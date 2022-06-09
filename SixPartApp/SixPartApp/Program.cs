using System;
using System.Collections.Generic;

namespace SixPartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "The story so far: In the beginning, the universe was created. ", "A screaming comes across the sky. ", "It was a bright cold day in April, and the clocks were striking thirteen. ", "As Gregor Samsa awoke one morning from uneasy dreams, he found himself transformed in his bed into a gigantic insect. ", };
            Console.WriteLine("Please enter a line of text you think would be funny added to the end of the average book's first line");//Request input
            string silly = (Console.ReadLine());//read input
            for (int i=0; i<lines.Length; i++)//iterate through array
            {
                lines[i] = (lines[i] + silly);//add user input to end of each item in array
            }
            foreach (string line in lines)
            {
                Console.WriteLine(line + "\n");//display all items in array after change.
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            int count = 0;
            while (true)//create "infinite loop"
            {
                Console.WriteLine("Count = {0}.", count);
                count++;
                if (count > 50)//set break point for loop
                {
                    break;
                }
            }
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Please enter a positive number, and I will count to that number.");//request input
            int o = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
            if (o<0)//loop will not execute if negative number is entered
            {
                Console.WriteLine("You have entered a negative number.  This section of code will not execute");
            }
            else
            {
                int count1 = 0;
                while (count1<o+1)//create while loop that will display all numbers from zero up to user entered number
                {
                    Console.WriteLine("Count = {0}.", count1);
                    count1++;
                }
            }
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Please enter a negative number, and I will count backwards to that number.");//request input
            int n = Convert.ToInt32(Console.ReadLine());//read input and convert to integer
            if (n >= 0)//loop will not execute if positive number is entered
            {
                Console.WriteLine("You have entered a positve number.  This section of code will not execute");
            }
            else
            {
                int count2 = 0;
                while (n <= count2)//create while loop that will display all numbers from zero down to user entered number
                {
                    Console.WriteLine("Count = {0}.", count2);
                    count2--;
                }
            }
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            List<string> species = new List<string>() { "Orcs", "Men", "Hobbits", "Elves", "Dwarves", "Dragons", "Trolls", "Goblins", "Wargs", "Eagles", "Spiders", "Ents" };//set list
            Console.WriteLine("Please enter a word to search for:");//request search term
            string search = Console.ReadLine();//read user search term

            if (species.Contains(search))//check to see if search term is in list
            {
                for (int j = 0; j < species.Count; j++)//iterate through list
                {
                    if (species[j].Contains(search))//identify which index contains the search term
                    {
                        Console.WriteLine("The search term you are looking for is in index " + j + ".");//display index number that contains term
                    }
                }
            }
            else
            {
                Console.WriteLine("Search term not found.");//display if term not found
            }
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();

            List<string> fruit = new List<string>() { "apples", "bananas", "cherries", "dates", "figs", "dragonfruit", "apples", "cherries"};//set list
            Console.WriteLine("Please enter a word to search for:");//request search term
            string search2 = Console.ReadLine();//read user search term
            List<int> indexes = new List<int>();
            if (fruit.Contains(search2))//check to see if search term is in list
            {
                for (int k = 0; k < fruit.Count; k++)//iterate through list
                {
                    if (fruit[k].Contains(search2))//identify which index contains the search term
                    {
                        indexes.Add(k);//add to list of indexes
                    }
                }
            Console.WriteLine("The requested term exists in the following indexes:");
            foreach (var index in indexes)
            {
                Console.WriteLine(index);
            }
            }
            else
            {
                Console.WriteLine("Search term not found.");//display if term not found
            }
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();

            List<string> cars = new List<string>() { "Lamborghini", "Porsche", "Ferrari", "McLaren", "Aston Martin", "Maserati", "McLaren", "Porsche" };//create list
            List<string> checkList = new List<string>();//create checklist
            foreach (var car in cars)
            {
                Console.WriteLine(car + " has already appeared in this list?: " + (checkList.Contains(car)));//iterate through list, checking to see if item is on checklist
                checkList.Add(car);//add item to checklist
            }
            Console.ReadLine();
        }
    }
}
