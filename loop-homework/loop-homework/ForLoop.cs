using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace loop_homework
{
    public static class ForLoop
    {

        public static void GetUserNameAndPassword(string UserAndPassLabel, string CorrectUserName, string CorrectPassword)
        {
            if (string.IsNullOrWhiteSpace(UserAndPassLabel))
            {
                UserAndPassLabel = "enter";
            }

            string userName = Utils.ReadUserName(UserAndPassLabel);
            string password = Utils.ReadPassword(UserAndPassLabel);
            UsingForLoop(userName.Trim(), password.Trim(), CorrectUserName, CorrectPassword);
        }

        public static void UsingForLoop(string user, string pass, string CorrectUser, string CorrectPass)
        {
            bool correctUserAndPass = true;
            for (; correctUserAndPass; )
            {
                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    correctUserAndPass = false;
                    Console.WriteLine();
                    Console.WriteLine("Username or password are not correct");
                    GetUserNameAndPassword("renter", CorrectUser, CorrectPass);
                }else if(!string.Equals(user, CorrectUser, StringComparison.InvariantCultureIgnoreCase) || 
                    !string.Equals(pass, CorrectPass))
                {
                    correctUserAndPass = false;
                    Console.WriteLine();
                    Console.WriteLine("Username or password are not correct");
                    GetUserNameAndPassword("renter", CorrectUser, CorrectPass);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Welcome!");
                    break;
                }

            }
        }

    }
}
