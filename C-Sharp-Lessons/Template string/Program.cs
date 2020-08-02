using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string manName = "Maxim";
            int manAge = 23;
            int manMark = 5;

            string messageContent = $"Pupil {manName} with age {manAge} got mark {manMark} yesterday";
            Console.WriteLine(messageContent);
        }
    }
}
