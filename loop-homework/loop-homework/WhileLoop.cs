using System;
using System.Collections.Generic;
using System.Text;

namespace loop_homework
{
    public static class WhileLoop
    {

        public static void GetUserNameAndPassword(string UserAndPassLabel, string CorrectUserName, string CorrectPassword, bool isCorrectUserAndPass)
        {
            if (string.IsNullOrWhiteSpace(UserAndPassLabel))
            {
                UserAndPassLabel = "enter";
            }
          
            string userName = Utils.ReadUserName(UserAndPassLabel);
            string password = Utils.ReadPassword(UserAndPassLabel);
            UsingWhileLoop(userName.Trim(), password.Trim(), CorrectUserName, CorrectPassword, isCorrectUserAndPass);
        }

        public static void UsingWhileLoop(string user, string pass, string CorrectUser, string CorrectPass, bool correctUserAndPass)
        {
            
            while (correctUserAndPass)
            {
                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    correctUserAndPass = true;
                    Console.WriteLine();
                    Console.WriteLine("Username or password are not correct");
                    GetUserNameAndPassword("renter", CorrectUser, CorrectPass, correctUserAndPass);
                }
                else if (!string.Equals(user, CorrectUser, StringComparison.InvariantCultureIgnoreCase) ||
                   !string.Equals(pass, CorrectPass))
                {
                    correctUserAndPass = true;
                    Console.WriteLine();
                    Console.WriteLine("Username or password are not correct");
                    GetUserNameAndPassword("renter", CorrectUser, CorrectPass, correctUserAndPass);
                }
                else
                {
                    
                    Console.WriteLine();
                    Console.WriteLine("Welcome!");
                    correctUserAndPass = false;
                    break;
                    
                }
            }
        }

    }
}
