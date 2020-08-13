using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            try
            {
                int x = a / b;
                Console.WriteLine("Result: " + x);
            } 
            catch
            {
                Console.WriteLine("Error of zero");
            }

            Console.WriteLine("Finish program");
        }
    }
}