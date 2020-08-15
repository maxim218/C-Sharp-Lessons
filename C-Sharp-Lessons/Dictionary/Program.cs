using System;
using System.Collections;
using System.Collections.Generic;

class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void renderPoint()
    {
        string message = " " + this.x + " " + this.y + "\n";
        Console.Write(message);
    }

    public void changeFields(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, Point> dictionary = new Dictionary <string, Point> ();

            dictionary["Moscow"] = new Point(100, 200);
            dictionary["Berlin"] = new Point(1234, 5678);
            dictionary["Samara"] = new Point(25, 43);

            foreach(KeyValuePair <string, Point> keyValue in dictionary)
            {
                string key = keyValue.Key;
                Point value = keyValue.Value;
                Console.Write(key);
                value.renderPoint();
            }

            Console.WriteLine("---------------------------------------");

            try
            {
                string k = Console.ReadLine();
                Point v = dictionary[k];
                Console.Write(k);
                v.renderPoint();
            }
            catch
            {
                Console.WriteLine("Element not found");
            }

            Console.WriteLine("---------------------------------------");

            Point b = dictionary["Berlin"];
            b.changeFields(111111, 2222222);

            foreach (KeyValuePair<string, Point> keyValue in dictionary)
            {
                string key = keyValue.Key;
                Point value = keyValue.Value;
                Console.Write(key);
                value.renderPoint();
            }

            Console.WriteLine("---------------------------------------");
        }
    }
}