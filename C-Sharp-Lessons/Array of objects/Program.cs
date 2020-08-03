using System;

class Man
{
    private string name;
    private int age;

    public Man()
    {
        this.name = "User";
        this.age = 18;
        Console.WriteLine("New man created");
    }

    public void printInfo()
    {
        string a = "Name: " + this.name;
        string b = "Age: " + this.age;
        string s = a + "  " + b;
        Console.WriteLine(s);
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Man[] arr = new Man[3];

            Console.WriteLine("--------------------------");

            arr[0] = new Man();
            arr[1] = new Man();
            arr[2] = new Man();

            Console.WriteLine("--------------------------");

            arr[0].printInfo();
            arr[1].printInfo();
            arr[2].printInfo();
        }
    }
}
