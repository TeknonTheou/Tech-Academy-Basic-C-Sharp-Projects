using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Collections;


namespace FinalChallengeStudentDatabase
{
     class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Billy McMillen" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!");

                var query = from i in ctx.Students
                          orderby i.StudentName
                          select i;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }


            }
        }
    }

}
