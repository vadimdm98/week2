using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Birth year:");
            int result = Convert.ToInt32(Console.ReadLine());

            if (2022 - result > 18)
            {
                Console.WriteLine("You can drive");
            }
            else if (2022 - result < 18)
            {
                Console.WriteLine("You are not allowed to drive yet!");
            }
            else Console.WriteLine("Congrats! You can legally drive your vehicle");
        }
    }
}
