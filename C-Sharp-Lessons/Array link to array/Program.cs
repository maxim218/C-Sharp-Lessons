using System;

namespace MyProject
{
    class Program
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.WriteLine(i + ") " + arr[i]);
        }

        static void Main(string[] args)
        {
            // создаем две ссылки на массивы
            // изначально ссылки указывают в никуда
            int[] first = null;
            int[] second = null;

            // теперь first ссылается на массив
            // задаем значения массива
            first = new int[4];
            first[0] = 10;
            first[1] = 20;
            first[2] = 30;
            first[3] = 40;

            // выводим элементы массива на экран
            printArray(first);

            // отчеркиваем вывод
            Console.WriteLine("-----------------------------");

            // теперь second ссылается на тот же массив
            second = first;

            // меняем некоторые ячейки массива
            second[1] = 2000;
            second[3] = 4000;

            // выводим элементы измененного массива на экран
            printArray(first);
        }
    }
}
