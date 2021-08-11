using System;
using System.Collections.Generic;
using System.Text;

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
       

        public static bool CardNumberValidation(int cardNum)
        {
            bool validated = false;
            while (!validated)
            {
                if(cardNum <= 0)
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid card number of length 13-19: {0}", validated);
                    cardNum = Convert.ToInt32(Console.ReadLine());
                }
                else if (cardNum < 13)
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid card number of length 13-19: {0}", validated);
                    cardNum = Convert.ToInt32(Console.ReadLine());
                }
                else if (13 <= cardNum || cardNum <= 19)
                {
                    validated = true;
                    Console.WriteLine("That worked!!");
                }
                else
                {
                    validated = false;
                    Console.WriteLine("Please enter a valid card number of length 13-19: {0}", validated);
                    cardNum = Convert.ToInt32(Console.ReadLine());
                }
            }
            return validated;
        }
        /* 
                 public PinToAccount(int pin)
        {
            
        }
         */
    }
}
