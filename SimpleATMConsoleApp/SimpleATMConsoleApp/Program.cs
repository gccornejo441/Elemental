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

            Console.WriteLine("How much would you like to deposit?");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Account.CheckingAccount = deposit;

            Console.WriteLine(Account.Balance);


        }

        public static void RequestingInformation()
        {    
            string nameOnCard = ATMKeypad.requestingName();

            string cardNumber = ATMKeypad.requestingCardNumber();

            string securityNumber = ATMKeypad.requestingSecurityNumber();

            string expirationDate = ATMKeypad.requestingExpirationDate();

            string pin = ATMKeypad.requestingPin();

            var addAccount = new Account(nameOnCard, cardNumber, securityNumber, expirationDate, pin);

            Console.WriteLine(addAccount.newAccount);

            Account.AccountLogin(addAccount);

        }
    }
}
