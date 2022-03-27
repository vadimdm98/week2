using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleace enter your PIN:");
            string PIN = Console.ReadLine();
            if (PIN == "1234")
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Invalid PIN.");
            }

        }
    }
}
