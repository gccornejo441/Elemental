using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATMConsoleApp
{
    public class Account
    {
        public string NameOnCard { get; }
        public int CreditCardNumber { get; }
        public int SecurityNumber { get; }
        public int ExperationDate { get; }
        public int Pin { get; }

        // Default Constructor.
        public Account(string nameOnCard, int creditCardNumber, int securityNumber, int experationDate, int pin)
        {
            this.NameOnCard = nameOnCard;
            this.CreditCardNumber = creditCardNumber;
            this.SecurityNumber = securityNumber;
            this.ExperationDate = experationDate;
            this.Pin = pin;
        }
    }
}
