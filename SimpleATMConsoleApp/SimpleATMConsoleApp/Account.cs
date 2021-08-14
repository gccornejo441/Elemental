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
        public static decimal CheckingAccount { get; set; }

        private static List<decimal> currentBalance = new List<decimal>();

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

        public static string Balance
        {
            get
            {
                decimal balance = 0;
                currentBalance.Add(CheckingAccount);
                foreach(var item in currentBalance)
                {
                    balance += item;
                }
                return $"You have ${balance} in your checking account.";
            }
        }


        static void LoopBackError(string propterty, string input)
        {
            if (input != propterty)
            {
                int tries = 1;
                while (input != propterty)
                {
                    Console.WriteLine(tries);

                    if (tries == 5)
                    {
                        Console.WriteLine("You have entered an invalid entry too many times.  Try again later.");
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Please try again: ");
                    input = Console.ReadLine();
                    tries++;
                }
            }

        }

        public static bool AccountLogin(Account account)
        {
            Console.WriteLine("We would first like to authenticate the name on the account and card number.");
            Console.WriteLine(" ");

            Console.WriteLine("Please enter the name on the account: ");
            string accountName = Console.ReadLine();

            Account.LoopBackError(account.NameOnCard, accountName);

            Console.WriteLine("Please enter your card number: ");
            string cardNumber = Console.ReadLine();

            Account.LoopBackError(account.CreditCardNumber, cardNumber);

            Console.WriteLine("Please enter your pin: ");

            string pin = Console.ReadLine();

            Account.LoopBackError(account.Pin, pin);

            return true;
        }
    }
}
