using System;

class Man
{
    private string login;
    private int age;

    public Man(string login, int age)
    {
        this.login = login;
        this.age = age;
    }

    public void setLoginAge(string login, int age)
    {
        this.login = login;
        this.age = age;
    }

    public void printInfo()
    {
        string messageLogin = "Login: " + this.login;
        string messageAge = "Age: " + this.age;
        Console.WriteLine(messageLogin + "  " + messageAge);
    }
}

namespace MyProject
{
    class Program
    {
        static Man returnLink(Man man)
        {
            return man;
        }

        static void Main(string[] args)
        {
            // создаем объект
            Man man = new Man("AAA", 10);

            // выводим поля объекта на экран
            man.printInfo();

            // создаем ссылку
            // ссылка ссылается на объект man
            Man buffer = returnLink(man);

            // через ссылку изменяем поля объекта man
            buffer.setLoginAge("BBBB", 5678);

            // выводим измененные поля объетка man на экран
            man.printInfo();
        }
    }
}
