using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            void myWaitAndPrint(string messageValue, int waitValue)
            {
                Thread.Sleep(waitValue);
                Console.WriteLine(messageValue);
            }

            Console.WriteLine("--------------------------");

            // запускаем задачи параллельно
            Task tA = Task.Run(() => myWaitAndPrint("A", 7000));
            Task tB = Task.Run(() => myWaitAndPrint("B", 4000));
            Task tC = Task.Run(() => myWaitAndPrint("C", 2000));

            // ждем завершения выполнения задач
            tA.Wait();
            tB.Wait();
            tC.Wait();

            Console.WriteLine("--------------------------");
        }
    }
}