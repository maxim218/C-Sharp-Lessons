using System;

class Calculator
{
    public static int substractElems(int a, int b)
    {
        Console.WriteLine($"Substract elements: {a} {b}");
        int sub = a - b;
        return sub;
    }

    public static int multiplyElems(int x, int y)
    {
        Console.WriteLine($"Multiply elements: {x} {y}");
        int mul = x * y;
        return mul;
    }
}

namespace MyProject
{
    class Program
    {
        delegate int MyFunc(int first, int second);

        static void Main(string[] args)
        {
            MyFunc myFunc;

            myFunc = Calculator.substractElems;
            int sub = myFunc(12, 8);
            Console.WriteLine(sub);

            myFunc = Calculator.multiplyElems;
            int mul = myFunc(15, 6);
            Console.WriteLine(mul);
        }
    }
}