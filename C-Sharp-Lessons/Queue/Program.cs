using System;
using System.Collections.Generic;

namespace ConsoleApp 
{
    internal static class Program
    {
        private static void RenderInfo(Queue<string> peopleQueue)
        {
            const string lineString = "-----------------------------";
            Console.WriteLine(lineString);
            
            int count = peopleQueue.Count;
            Console.WriteLine("Count: " + count);
            
            foreach(string elementString in peopleQueue)
                Console.WriteLine(elementString);
        }

        private static void DeleteFirstElement(Queue<string> peopleQueue)
        {
            if(peopleQueue.Count > 0)
            {
                string elementString = peopleQueue.Dequeue();
                Console.WriteLine("Delete first: " + elementString);
            }
        }

        private static void ClearQueue(Queue<string> peopleQueue)
        {
            while (peopleQueue.Count > 0)
                peopleQueue.Dequeue();
        }
        
        private static void Main(string[] args)
        {
            Queue<string> peopleQueue = new Queue<string>();

            peopleQueue.Enqueue("Maxim");
            peopleQueue.Enqueue("Nina");
            peopleQueue.Enqueue("Alexandr");
            peopleQueue.Enqueue("Ann");
            peopleQueue.Enqueue("George");
            peopleQueue.Enqueue("Maxim");
            peopleQueue.Enqueue("Nina");

            RenderInfo(peopleQueue);
            
            const string lineStringA = "-----------------------------";
            Console.WriteLine(lineStringA);

            DeleteFirstElement(peopleQueue);
            DeleteFirstElement(peopleQueue);
            DeleteFirstElement(peopleQueue);
            
            RenderInfo(peopleQueue);
            
            const string lineStringB = "-----------------------------";
            Console.WriteLine(lineStringB);
            
            DeleteFirstElement(peopleQueue);
            
            RenderInfo(peopleQueue);

            ClearQueue(peopleQueue);
            
            RenderInfo(peopleQueue);
        }
    }
}