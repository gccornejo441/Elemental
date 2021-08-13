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

    }
}
