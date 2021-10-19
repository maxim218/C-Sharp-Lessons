using System;
using System.Collections;

internal class Man
{
    private int _age = 0;
    public int Age
    {
        get => _age;
        set
        {
            bool positiveCondition = (value > 0);
            _age = positiveCondition ? value : 0;
        }
    }
}

namespace ConsoleApp 
{
    internal static class Program 
    {
        private static void Main(string[] args)
        {
            Man a = new Man();
            Man b = new Man();
            Man c = new Man();
            Man d = new Man();

            a.Age = -45;
            b.Age = 55;
            c.Age = -23;
            d.Age = 77;
            
            Console.WriteLine(a.Age);
            Console.WriteLine(b.Age);
            Console.WriteLine(c.Age);
            Console.WriteLine(d.Age);
        }
    }
}