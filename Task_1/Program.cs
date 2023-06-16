using System;

namespace Task_1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Small Quiz!");
            Console.WriteLine("What is 1+1 equal to?");
            String v = Console.ReadLine();
            if (v == "2")
            {
                Console.WriteLine("Congrats your answer is correct!");
            }
            else
            {
                Console.WriteLine("Sorry! Try again next time.");
            }
            Console.ReadKey();
        }
    }
}