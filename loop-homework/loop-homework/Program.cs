using System;

namespace loop_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string CorrectUserName = "user";
            string CorrectPassword = "pass";

            Console.WriteLine("For Loop started");
            ForLoop.GetUserNameAndPassword("enter", CorrectUserName.Trim(),CorrectPassword.Trim());
            Console.WriteLine();
            Console.WriteLine("For Loop ended");


            Console.WriteLine();
            Console.WriteLine("While Loop started");
            WhileLoop.UsingWhileLoop(CorrectUserName.Trim(),CorrectPassword.Trim());
            Console.WriteLine();
            Console.WriteLine("While Loop ended");

            Console.WriteLine();
            Console.WriteLine("DoWhile Loop started");
            DoWhileLoop.UsingDoWhileLoop(CorrectUserName.Trim(), CorrectPassword.Trim());
            Console.WriteLine();
            Console.WriteLine("DoWhile Loop ended");
        }
    }
}
