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
        static void initMan(Man man, string loginParam, int ageParam)
        {
            man.setLoginAge(loginParam, ageParam);
        }

        static void Main(string[] args)
        {
            // создаем два объекта
            Man george = new Man("George", 18);
            Man nina = new Man("Nina", 75);

            // выводим поля объектов на экран
            george.printInfo();
            nina.printInfo();

            // отчеркиваем вывод
            Console.WriteLine("-----------------------------------------");

            // изменяем поля объектов через вспомогательную функцию
            initMan(george, "GeorgeHello", 1800);
            initMan(nina, "NinaDrawing", 7500);

            // поля объектов успешно изменились
            // выводим измененные поля объектов на экран
            george.printInfo();
            nina.printInfo();
        }
    }
}
