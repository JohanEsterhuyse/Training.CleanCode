using MessagingService.Providers;
using System;

namespace MessagingService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Messaging Service POC!");

            while (0 == 0)
            {
                Console.WriteLine("Please enter the number/email");
                var number = Console.ReadLine();

                Console.WriteLine("Please enter the message");
                var message = Console.ReadLine();

                BL bl = new BL();

                bl.SendMessage(number, message);
            }
        }
    }
}
