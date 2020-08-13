using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            try
            {
                if (a < 0) throw new Exception("my error A");
                if (b < 0) throw new Exception("my error B");
                if (c < 0) throw new Exception("my error C");
                int volume = a * b * c;
                Console.WriteLine("Volume: " + volume);
            } 
            catch (Exception ex)
            {
                string message = ex.Message;
                Console.WriteLine("Error: " + message);
            }

            Console.WriteLine("Finish program");
        }
    }
}