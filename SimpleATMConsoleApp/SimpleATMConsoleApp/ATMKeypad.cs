using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SimpleATMConsoleApp
{
    class ATMKeypad
    {
        public string NameOnCard { get; }
        public int SecurityNumber { get; }
        public int CreditCardNumber { get; }
        public int CreditCardPin { get; }

        public ATMKeypad(int pin)
        {
            int CreditCardPIn = pin;
        }
       

        public static bool isCardNumberValid(string cardNum)
        {
            
            bool validated = false;
            while (!validated)
            {
                if (cardNum.Length <= 0)
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid card number of length 13-19: {0}", validated);
                    cardNum = Console.ReadLine();
                }
                else if (cardNum.Length < 13)
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid card number of length 13-19: {0}", validated);
                    cardNum = Console.ReadLine();
                }
                else if (13 <= cardNum.Length && cardNum.Length <= 19)
                {
                    validated = true;
                    Console.WriteLine("That worked!!");
                }
                else
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid card number of length 13-19: {0}", validated);
                    cardNum = Console.ReadLine();
                }
            }
            return validated;
        }
        public static bool isSecurityCodeValid(string cardNum)
        {

            bool validated = false;
            while (!validated)
            {
                if (cardNum.Length <= 0)
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid security number greater than 0: {0}", validated);
                    cardNum = Console.ReadLine();
                }
                else if (cardNum.Length < 3)
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid security number greater than 0 but less than 3: {0}", validated);
                    cardNum = Console.ReadLine();
                }
                else if (cardNum.Length == 3)
                {
                    validated = true;
                    Console.WriteLine("That worked!!");
                }
                else
                {
                    validated = false;
                    Console.WriteLine("Please enter the valid three digit number located on the back of your card: {0}", validated);
                    cardNum = Console.ReadLine();
                }
            }
            return validated;
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
            Console.Write("Please enter your expiration date: ");
            string expDate = Console.ReadLine();

            if (expDate.Length != 4)
            {
                while (expDate.Length != 4 || expDate.Length <= 0)
                {
                    Console.Write("Invalid entry, please enter two digits for the month and two digit for the year: ");
                    expDate = Regex.Replace(Console.ReadLine(), @"[^0-9\s]", string.Empty);
                    if (expDate.Length == 4) break;
                }
            }

            List<char> expDateList = new List<char>();

            foreach (char n in expDate)
            {
                expDateList.Add(n);
            }

            string formattedDate = expDateList[0] + "" + expDateList[1] + "/" + expDateList[2] + expDateList[3];
            return expDate;
        }

        public static string requestingPin()
        {
            Console.Write("Please enter a four digit security code: ");
            string pin = Console.ReadLine();

            Regex rgx = new Regex(@"^\d{4}(?:\d{2})?$");
            bool isPinValid = rgx.IsMatch(pin);

            while (!isPinValid)
            {
                Console.Write("Invalid try again: ");
                rgx = new Regex(@"^\d{4}(?:\d{2})?$");
                isPinValid = rgx.IsMatch(Console.ReadLine());
                Console.WriteLine(isPinValid);
            }

            return pin;
        }

    }
}
