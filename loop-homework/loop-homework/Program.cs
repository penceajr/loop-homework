using System;

namespace loop_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string CorrectUserName = "user";
            string CorrectPassword = "pass";

            Console.WriteLine();
           //ForLoop.GetUserNameAndPassword("enter", CorrectUserName.Trim(),CorrectPassword.Trim());
           WhileLoop.UsingWhileLoop(CorrectUserName.Trim(),CorrectPassword.Trim());
        }
    }
}
