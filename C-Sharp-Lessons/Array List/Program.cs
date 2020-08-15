using System;
using System.Collections;

class Man
{
    private string login;
    private int age;

    public Man(string login, int age)
    {
        this.login = login;
        this.age = age;
    }

    public void mulAge()
    {
        this.age = this.age * 100;
    }

    public void renderMan()
    {
        string message = this.login + " " + this.age;
        Console.WriteLine(message);
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Man nina = new Man("Nina", 45);
            Man alex = new Man("Alex", 12);
            Man george = new Man("George", 78);
            Man maxim = new Man("Maxim", 37);

            ArrayList arrayList = new ArrayList();

            arrayList.Add(nina);
            arrayList.Add(alex);
            arrayList.Add(george);
            arrayList.Add(maxim);

            int count = arrayList.Count;
            Console.WriteLine("Count: " + count + "\n");

            Console.WriteLine("---------------------------------------\n");

            for(int i = 0; i < count; i++)
            {
                Man man = (Man) arrayList[i];
                man.renderMan();
            }

            Console.WriteLine("\n---------------------------------------\n");

            for (int i = 0; i < count; i++)
            {
                Man man = (Man) arrayList[i];
                man.mulAge();
            }

            nina.renderMan();
            alex.renderMan();
            george.renderMan();
            maxim.renderMan();

            Console.WriteLine("\n\n");
        }
    }
}