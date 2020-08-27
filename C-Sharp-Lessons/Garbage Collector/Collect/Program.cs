using System;

class Point
{
    public int x, y, z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем два объекта
            Point a = new Point(1, 2, 3);
            Point b = new Point(4, 5, 6);

            // выводим поколения объектов
            Console.WriteLine("A: " + GC.GetGeneration(a));
            Console.WriteLine("B: " + GC.GetGeneration(b));

            // вызываем метод сборки мусора
            GC.Collect();

            // отчеркиваем
            Console.WriteLine("-------------------------------------------");

            // выводим поколения объектов
            Console.WriteLine("A: " + GC.GetGeneration(a));
            Console.WriteLine("B: " + GC.GetGeneration(b));

            // вызываем метод сборки мусора
            GC.Collect();

            // отчеркиваем
            Console.WriteLine("-------------------------------------------");

            // выводим поколения объектов
            Console.WriteLine("A: " + GC.GetGeneration(a));
            Console.WriteLine("B: " + GC.GetGeneration(b));

            // отчеркиваем
            Console.WriteLine("-------------------------------------------");
        }
    }
}