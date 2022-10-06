using System;
using System.Security.Cryptography;

namespace ApplicationLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            Console.WriteLine("Enter your code to determine access to the program");
            code = Convert.ToInt32(Console.ReadLine());
            Application application = new Application(code);
            Console.WriteLine($"Your code : {code}");
            application.DoWork(10,2);
        }
    }
}
