using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Faux-Fox Bank");
            Console.WriteLine(" ");

            // Requesting User Information
            Program.RequestingInformation();


        }


        public static void RequestingInformation()
        {
            Console.Write("Please enter your name as written on your credit card: ");
            string nameOnCard = Console.ReadLine();
            string cleanNameOnCard = Regex.Replace(nameOnCard, @"[^a-zA-Z\s]", string.Empty);

            while (cleanNameOnCard.Length == 0)
            {
                Console.Write("Invalid entry.  Please try again: ");
                nameOnCard = Console.ReadLine();
                cleanNameOnCard = Regex.Replace(nameOnCard, @"[^a-zA-Z\s]", string.Empty);
            }

            Console.WriteLine(cleanNameOnCard);

            Console.WriteLine(" ");

            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();
            // This validates the card number.
             bool isCardValid = ATMKeypad.isCardNumberValid(cardNumber);

            string securityNumber = "";
            if (isCardValid)
            {
                Console.WriteLine(" ");

                Console.WriteLine("Please enter the three digit security ");
                Console.Write("code located on the back of your card: ");

                // This validates the card security number.
                securityNumber = Console.ReadLine();
                ATMKeypad.isSecurityCodeValid(securityNumber);
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }


            var newAccount = new Account(nameOnCard, cardNumber, securityNumber, 123, 123);

            Console.WriteLine(newAccount);
        }
    }
}
