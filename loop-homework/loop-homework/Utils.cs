using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

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
    }
}
