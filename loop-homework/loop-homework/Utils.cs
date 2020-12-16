using System;
using System.Runtime.InteropServices;
using System.Security;

namespace loop_homework
{
    public static class Utils
    {
        public static string ReadUserName(string label)
        {
            Console.WriteLine();
            Console.Write($"Please {label} you username: ");
            string username = Console.ReadLine();
            return username;
        }

        public static string ReadPassword(string label)
        {
            Console.WriteLine();
            Console.Write($"Please {label} you password: ");

            var password = new SecureString();
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password.RemoveAt(password.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else if (i.KeyChar != '\u0000') // KeyChar == '\u0000' if the key pressed does not correspond to a printable character, e.g. F1, Pause-Break, etc
                {
                    password.AppendChar(i.KeyChar);
                    Console.Write("*");
                }
            }
             string pass =  SecureStringToString(password);
            return pass;
        }

        static String SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        public static bool CheckEquality(string user, string pass, string CorrectUserName, string CorrectPassword)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                return false;
            }

                if (string.Equals(user, CorrectUserName, StringComparison.InvariantCultureIgnoreCase) &&
                    string.Equals(pass, CorrectPassword))
                {
                return true;
                }
                else
                
                return false;
                }

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

    }
    }
