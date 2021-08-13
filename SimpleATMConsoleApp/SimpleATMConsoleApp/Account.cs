using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATMConsoleApp
{
    public class Account
    {
        public string NameOnCard { get; set; }
        public string CreditCardNumber { get; set; }
        public string SecurityNumber { get; set; }
        public string ExperationDate { get; set; }
        public string Pin { get; set; }


        // Default Constructor.
        public Account(string nameOnCard, string creditCardNumber, string securityNumber, string experationDate, string pin)
        {
            this.NameOnCard = nameOnCard;
            this.CreditCardNumber = creditCardNumber;
            this.SecurityNumber = securityNumber;
            this.ExperationDate = experationDate;
            this.Pin = pin;
        }

        public string newAccount
        {
            get
            {
                return NameOnCard + " " + CreditCardNumber + " " + SecurityNumber + " " + ExperationDate + " " + Pin;
            }
        }
        public static bool AccountLoginName(Account account)
        {
            Console.WriteLine("We would first like to authenticate the name on the account and card number.");
            Console.WriteLine(" ");

            Console.WriteLine("Please enter the name on the account: ");
            string accountName = Console.ReadLine();
            if (accountName != account.NameOnCard)
            {
                int tries = 0;
                while (accountName != account.NameOnCard)
                {
                    Console.WriteLine(tries);

                    Console.WriteLine("Please try again: ");
                    accountName = Console.ReadLine();

                    if (tries == 5)
                    {
                        Console.WriteLine("You have entered an invalid entry too many times.  Try again later.");
                        Environment.Exit(0);
                    }
                    tries++;
                }
            }
            return true;
        }

        public static bool AccountLoginCard(Account account)
        {
            Console.WriteLine("Please enter your card number: ");
            string cardNumber = Console.ReadLine();
            if (cardNumber != account.CreditCardNumber)
            {
                int tries = 0;
                while (cardNumber != account.CreditCardNumber)
                {
                    Console.WriteLine(tries);

                    Console.WriteLine("Please try again: ");
                    cardNumber = Console.ReadLine();

                    if (tries == 5)
                    {
                        Console.WriteLine("You have entered an invalid entry too many times.  Try again later.");
                        Environment.Exit(0);
                    }
                    tries++;
                }
            }
            return true;
        }
    }

}
