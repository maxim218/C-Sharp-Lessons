using System;

namespace MyProject
{
    class Program
    {
        static void renderArrayElements(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                string message = i + ") " + mass[i];
                Console.WriteLine(message);
            }
        }

        static void changeArrayElements(int[] mass, int value)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = mass[i] * value;
            }
        }

        static void Main(string[] args)
        {
            int[] myArr = new int[5];
            myArr[0] = 90;
            myArr[1] = 80;
            myArr[2] = 70;
            myArr[3] = 60;
            myArr[4] = 50;

            Console.WriteLine("\nBefore:");
            renderArrayElements(myArr);

            changeArrayElements(myArr, 2);

            Console.WriteLine("\nAfter:");
            renderArrayElements(myArr);
        }
    }
}
