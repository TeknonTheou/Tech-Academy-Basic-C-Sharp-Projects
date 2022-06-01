using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What is your name?"); //ask name
            string name = Console.ReadLine(); //save name
            Console.WriteLine("What course are you on?"); //ask course name 
            string course = Console.ReadLine(); //save course
            Console.WriteLine("What page number are you on?"); //ask page number
            string pageNum = Console.ReadLine(); //save page number string
            int page = Convert.ToInt32(pageNum); //convert page number to integer
            Console.WriteLine("Do you need help with anything? Please answer true (if you do need help) or false (if you don't)."); //ask if help needed
            string Help = Console.ReadLine(); //save string true or false for help needed
            bool needHelp = Convert.ToBoolean(Help);// convert help needed response to boolean
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");//ask for positive experiences
            string positive = Console.ReadLine(); //save positive experience response
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");//ask for additional feedback
            string feedback = Console.ReadLine();//save additional feedback
            Console.WriteLine("How many hours did you study today?");//ask how many hours studied
            string study = Console.ReadLine();//save hours studied response
            int hours = Convert.ToInt32(study);//convert hours studied to integer
            Console.WriteLine("Thank you for your answers, "+ name+ ". An Instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Page Nubmer: " + page);
            Console.WriteLine("Need Help?: " + needHelp);
            Console.WriteLine("Positive Experience: " + positive);
            Console.WriteLine("Additional Feedback: " + feedback);
            Console.WriteLine("Hours Studied: " + hours);
            Console.Read();
        }
    }
