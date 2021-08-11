using System;

namespace SimpleATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Faux-Fox Bank");
            Console.WriteLine(" ");
            ATMKeypad.CardNumberValidation(0);

            // Requesting User Information
            Program.RequestingInformation();


            var newAccount = new Account("Gabriel Cornejo", 123, 123, 123, 123);

        }


        public static void RequestingInformation()
        {
            Console.Write("Please enter your name as written on your credit card: ");
            string name = Console.ReadLine();
            Console.WriteLine(" ");
            
            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Please enter the three digit security ");
            Console.Write("code located on the back of your card: ");
            string securityNumber = Console.ReadLine();
            Console.WriteLine(" ");
        }
    }
}
