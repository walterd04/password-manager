using PasswordManager.Core.Interfaces;
using PasswordManager.Core.Services;
using System;

namespace TestConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryption encryption = new Encryption();

            var crypt = encryption.Encrypt("Password");

            Console.ReadLine();
        }
    }
}
