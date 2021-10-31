using System;
using System.Collections.Generic;

namespace ConsoleApp 
{
    internal static class Program 
    {
        private static void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        private static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(15);

            foreach (int element in myList)
            {
                string message = "Element: " + element;
                Console.WriteLine(message);
            }

            DrawLine();
            
            for (int index = 0; index < myList.Count; index++)
            {
                string message = index + ") " + myList[index];
                Console.WriteLine(message);
            }
            
            DrawLine();

            for (int index = 0; index < myList.Count; index++)
            {
                if (20 == myList[index])
                    myList[index] = 0;
            }
            
            foreach (int element in myList)
            {
                string message = "Element: " + element;
                Console.WriteLine(message);
            }
            
            DrawLine();

            string msg = "Count: " + myList.Count;
            Console.WriteLine(msg);
        }
    }
}