using System;
using System.Linq;
using System.Linq.Expressions;

class ElementsSummer
{
    private int a;
    private int b;

    public ElementsSummer(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void printResult()
    {
        int a = this.a;
        int b = this.b;
        int result = a + b;
        Console.WriteLine($"A: {a}  B: {b}  Result: {result}");
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementsSummer first = new ElementsSummer(2, 3);
            ElementsSummer second = new ElementsSummer(20, 30);
            ElementsSummer third = new ElementsSummer(200, 300);
            first.printResult();
            second.printResult();
            third.printResult();
        }
    }
}
