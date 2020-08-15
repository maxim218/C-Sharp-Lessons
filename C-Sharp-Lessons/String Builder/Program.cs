using System;
using System.Text;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hello ");
            stringBuilder.Append("beautiful ");
            stringBuilder.Append("gorgeous ");
            stringBuilder.Append("world ");

            string message = stringBuilder.ToString();
            Console.WriteLine(message);
        }
    }
}