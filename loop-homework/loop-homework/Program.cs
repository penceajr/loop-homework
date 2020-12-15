using System;

namespace loop_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string CorrectUserName = "penceac";
            string CorrectPassword = "!Renata123";

            Console.WriteLine();
            ForLoop.GetUserNameAndPassword("enter", CorrectUserName.Trim(),CorrectPassword.Trim());
        }
    }
}
