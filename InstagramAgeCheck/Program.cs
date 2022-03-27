using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleace enter your age:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 13) 
            {
                Console.WriteLine("Your are too young for instagram.");
            }else if (userAge > 13)
            {
                Console.WriteLine("Welcome to instagram!");
            }
            else
            {
                Console.WriteLine("Congratulations! You may use instagram now.");
            }
        }
    }
}
