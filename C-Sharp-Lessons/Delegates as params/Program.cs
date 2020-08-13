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

        static int calculateAndRender(MyFunc myFunc, int firstParam, int secondParam)
        {
            int result = myFunc(firstParam, secondParam);
            return result;
        }
       

        static void Main(string[] args)
        {
            int f = 14;
            int s = 11;

            int sub = calculateAndRender(Calculator.substractElems, f, s);
            int mul = calculateAndRender(Calculator.multiplyElems, f, s);

            Console.WriteLine("Sub: " + sub);
            Console.WriteLine("Mul: " + mul);
        }
    }
}