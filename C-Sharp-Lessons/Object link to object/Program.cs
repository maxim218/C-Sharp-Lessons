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
        static void Main(string[] args)
        {
            // создаем два объекта
            Man maxim = new Man("Maxim", 20);
            Man ann = new Man("Ann", 45);

            // выводим поля объектов на экран
            maxim.printInfo();
            ann.printInfo();

            // отделяем вывод
            Console.WriteLine("------------------------------------");

            // ссылка в никуда
            Man buffer = null;

            // теперь ссылка ссылается на объект maxim
            // изменяем поля объекта maxim
            buffer = maxim;
            buffer.setLoginAge("Maximius", 2000);

            // теперь ссылка ссылается на объект ann
            // изменяем поля объекта ann
            buffer = ann;
            buffer.setLoginAge("Anastasia", 4500);

            // выводим поля объектов на экран
            // поля объектов были изменены через вспомогательную ссылку
            maxim.printInfo();
            ann.printInfo();
        }
    }
}
