using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

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


        // Requesting name on card as written
        public static string requestingName()
        {
            Console.Write("Please enter your name as written on your credit card: ");
            string nameOnCard = Console.ReadLine();
            string cleanNameOnCard = Regex.Replace(nameOnCard, @"[^a-zA-Z\s]", string.Empty);

            while (cleanNameOnCard.Length == 0)
            {
                Console.Write("Invalid entry, please try again: ");
                nameOnCard = Console.ReadLine();
                cleanNameOnCard = Regex.Replace(nameOnCard, @"[^a-zA-Z\s]", string.Empty);
            }

            Console.WriteLine(cleanNameOnCard);
            return cleanNameOnCard;
        }

        public static string requestingCardNumber()
        {
            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();
            // This validates the card number.
            bool isCardValid = ATMKeypad.isCardNumberValid(cardNumber);

            return cardNumber;
        }

        public static string requestingSecurityNumber()
        {
            string securityNumber = "";

            Console.WriteLine(" ");

            Console.WriteLine("Please enter the three digit security ");
            Console.Write("code located on the back of your card: ");

            // This validates the card security number.
            securityNumber = Console.ReadLine();
            ATMKeypad.isSecurityCodeValid(securityNumber);
            Console.WriteLine(" ");

            return securityNumber;
        }

        public static string requestingExpirationDate()
        {
            Console.Write("Please enter your experation date: ");
            string expDate = Console.ReadLine();
                    Console.WriteLine("afdafaf: {0}",expDate.Length);

            if(expDate.Length != 4)
            {
                while (expDate.Length != 4 || expDate.Length <= 0)
                {
                    Console.Write("Invalid entry, please enter two digits for the month and two digit for the year: ");
                    expDate = Regex.Replace(Console.ReadLine(), @"[^0-9\s]", string.Empty);
                    if (expDate.Length == 4) break;
                }
            }

            List<char> expDateList = new List<char>();

            foreach (char abc in expDate)
            {
                expDateList.Add(abc);
            }

            string formattedDate = expDateList[0] + "" +  expDateList[1] + "/" + expDateList[2] + expDateList[3];
            Console.WriteLine(formattedDate);

            return expDate;
        }

        public static string requestingPin()
        {
            Console.Write("Please enter a four digit security code: ");
            string pin = Console.ReadLine();

            return pin;
        }


        public static void RequestingInformation()
        {
            
            string expirationDate = requestingExpirationDate();
            string nameOnCard = requestingName();

            string cardNumber = requestingCardNumber();

            string securityNumber = requestingSecurityNumber();


            string pin = requestingPin();

            var addAccount = new Account(nameOnCard, cardNumber, securityNumber, expirationDate, pin);

            Console.WriteLine(addAccount.newAccount);
        }
    }
}
