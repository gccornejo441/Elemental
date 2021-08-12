using System;

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


            var newAccount = new Account("Gabriel Cornejo", 123, 123, 123, 123);

        }


        public static void RequestingInformation()
        {
            Console.Write("Please enter your name as written on your credit card: ");
            string name = Console.ReadLine();
            Console.WriteLine(" ");

            
            Console.Write("Please enter your card number: ");
            int cardNumber = Convert.ToInt32(Console.ReadLine());
            //This validates the card number.
             bool isCardValid = ATMKeypad.isCardNumberValid(cardNumber);
            if (isCardValid)
            {
                Console.WriteLine(" ");

                Console.WriteLine("Please enter the three digit security ");
                Console.Write("code located on the back of your card: ");

                //This validates the card security number.
                int securityNumber = Convert.ToInt32(Console.ReadLine());
                ATMKeypad.isSecurityCodeValid(securityNumber);
                Console.WriteLine(" ");

            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }

        }
    }
}
