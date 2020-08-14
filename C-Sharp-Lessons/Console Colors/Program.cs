using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n-------------------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red message");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green message");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue message");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------\n\n");
        }
    }
}