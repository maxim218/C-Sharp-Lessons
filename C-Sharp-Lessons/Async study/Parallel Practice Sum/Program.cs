using System;
using System.Threading;
using System.Threading.Tasks;

class SummaFinder
{
    private int a;
    private int b;
    private int s;

    public SummaFinder(int a, int b)
    {
        this.a = a;
        this.b = b;
        s = 0;
    }

    public void findSumma()
    {
        s = 0;
        for (int i = a; i <= b; i++) s += i;
    }

    public int getResult()
    {
        return s;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SummaFinder aaa = new SummaFinder(1000, 2000);
            SummaFinder bbb = new SummaFinder(2001, 3000);
            SummaFinder ccc = new SummaFinder(3001, 4000);

            // запускаем задачи параллельно
            Task tA = Task.Run(() => aaa.findSumma());
            Task tB = Task.Run(() => bbb.findSumma());
            Task tC = Task.Run(() => ccc.findSumma());

            // ждем завершения выполнения задач
            tA.Wait();
            tB.Wait();
            tC.Wait();

            int a = aaa.getResult();
            int b = bbb.getResult();
            int c = ccc.getResult();

            long result = a + b + c;

            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine("Result: " + result);
        }
    }
}