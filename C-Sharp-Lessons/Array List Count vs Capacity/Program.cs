using System;
using System.Collections;

class Boy
{
    private string login;
    private int age;

    public Boy(string login, int age)
    {
        this.login = login;
        this.age = age;
    }

    public void printBoy()
    {
        string a = "Login: " + login;
        string b = "Age: " + age;
        string message = a + "  " + b;
        Console.WriteLine(message);
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Count: " + arrayList.Count);
            Console.WriteLine("Capacity: " + arrayList.Capacity);
            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Boy boy = new Boy("user_" + i, 18 + i);
                arrayList.Add(boy);
                Console.WriteLine("Count: " + arrayList.Count);
                Console.WriteLine("Capacity: " + arrayList.Capacity);
                Console.WriteLine("---------------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            for(int i = 0; i < arrayList.Count; i++)
            {
                Boy boy = (Boy) arrayList[i];
                boy.printBoy();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}