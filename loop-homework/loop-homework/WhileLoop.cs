using System;

namespace loop_homework
{
    public static class WhileLoop
    {

        public static void UsingWhileLoop(string CorrectUserName, string CorrectPassword)
        {
            //return a bool value if the inserted username and pass are correct
            bool correctUserAndPass = Utils.GetUserNameAndPassword("enter", CorrectUserName, CorrectPassword);

            while (!correctUserAndPass)
            {
                Console.WriteLine();
                Console.WriteLine("Username or password are not correct");
                correctUserAndPass = Utils.GetUserNameAndPassword("renter", CorrectUserName, CorrectPassword);

            }

            Console.WriteLine();
            Console.WriteLine("Your credentials are correct. Welcome!");
        }


        
    }
}
