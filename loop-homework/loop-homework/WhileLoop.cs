using System;
using System.Collections.Generic;
using System.Text;

namespace loop_homework
{
    public static class WhileLoop
    {

        public static bool GetUserNameAndPassword(string UserAndPassLabel, string CorrectUserName, string CorrectPassword)
        {
            if (string.IsNullOrWhiteSpace(UserAndPassLabel))
            {
                UserAndPassLabel = "enter";
            }
          
            string userName = Utils.ReadUserName(UserAndPassLabel);
            string password = Utils.ReadPassword(UserAndPassLabel);
            bool correctUserAndPass;
            
            correctUserAndPass = Utils.CheckEquality(userName.Trim(), password.Trim(), CorrectUserName, CorrectPassword);
            return correctUserAndPass;
        }

        public static void UsingWhileLoop(string CorrectUserName, string CorrectPassword)
        {
            bool correctUserAndPass = GetUserNameAndPassword("enter", CorrectUserName, CorrectPassword);

            while (!correctUserAndPass)
            {
                Console.WriteLine();
                Console.WriteLine("Username or password are not correct");
                correctUserAndPass = GetUserNameAndPassword("renter", CorrectUserName, CorrectPassword);

            }

            Console.WriteLine();
            Console.WriteLine("Your credentials are correct. Welcome!", 20);
        }


        
    }
}
