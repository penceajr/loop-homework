using System;

namespace loop_homework
{
    public static class DoWhileLoop
    {
        public static void UsingDoWhileLoop(string CorrectUserName, string CorrectPassword)
        {
            bool correctUserAndPass = true;

            do
            {
                string label = "";
                if (!correctUserAndPass)
                {
                    Console.WriteLine();
                    Console.WriteLine("Username or password are not correct");
                    label = "renter";
                }

                //return a bool value if the inserted username and pass are correct
                correctUserAndPass = Utils.GetUserNameAndPassword(label, CorrectUserName, CorrectPassword);

                

            } while (!correctUserAndPass);

            Console.WriteLine();
            Console.WriteLine("Your credentials are correct. Welcome!");
        }



    }
}
