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
       

        public static bool isCardNumberValid(int numb)
        {
            string cardNum;
            cardNum = Convert.ToString(numb);
            
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
        public static bool isSecurityCodeValid(int numb)
        {
            string cardNum;
            cardNum = Convert.ToString(numb);

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
        /* 
                 public PinToAccount(int pin)
        {
            
        }
         */
    }
}
