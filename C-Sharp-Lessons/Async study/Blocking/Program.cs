using System;
using System.Threading;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            void myWaitAndPrint(string messageValue, int waitValue)
            {
                Thread.Sleep(waitValue);
                Console.WriteLine(messageValue);
            }

            myWaitAndPrint("A", 7000);
            myWaitAndPrint("B", 4000);
            myWaitAndPrint("C", 2000);
        }
    }
}