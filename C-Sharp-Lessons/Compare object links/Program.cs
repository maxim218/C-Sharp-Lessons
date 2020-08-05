using System;

class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Student created: " + this.name + " " + this.age);
    }
}

namespace MyProject
{
    class Program
    {
        static int getIndex(Student[] elementsArray, Student link)
        {
            for(int i = 0; i < elementsArray.Length; i++)
            {
                Student element = elementsArray[i];
                if (link == element) return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Student[] mass = new Student[5];

            Student a = new Student("Maxim", 218);
            Student b = new Student("Maxim", 218);
            Student c = new Student("Maxim", 218);
            Student d = new Student("Maxim", 218);
            Student e = new Student("Maxim", 218);

            mass[0] = a;
            mass[1] = b;
            mass[2] = c;
            mass[3] = d;
            mass[4] = e;

            // оператор == проверяет для ссылочных типов равенство ссылок

            Console.WriteLine(getIndex(mass, e));
            Console.WriteLine(getIndex(mass, d));
            Console.WriteLine(getIndex(mass, c));
            Console.WriteLine(getIndex(mass, b));
            Console.WriteLine(getIndex(mass, a));
        }
    }
}