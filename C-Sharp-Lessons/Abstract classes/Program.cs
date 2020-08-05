using System;

abstract class Counter
{
    public abstract void initFields(int a, int b);
    public abstract void printFields();
    public abstract int calcResult();
}

class Summer : Counter
{
    private int a;
    private int b;

    public override void initFields(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public override void printFields()
    {
        string s = "Summer ------- A: " + a + "  B: " + b;
        Console.WriteLine(s);
    }

    public override int calcResult()
    {
        int s = a + b;
        return s;
    }
}

class Muller : Counter
{
    private int a;
    private int b;

    public override void initFields(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public override void printFields()
    {
        string s = "Muller ------- A: " + a + "  B: " + b;
        Console.WriteLine(s);
    }

    public override int calcResult()
    {
        int m = a * b;
        return m;
    }
}

namespace MyProject
{
    class Program
    {
        static void printCounter(Counter counter)
        {
            counter.printFields();
        }

        static void Main(string[] args)
        {
            Counter first = new Summer();
            first.initFields(2, 5);
            first.printFields();
            int sum = first.calcResult();
            Console.WriteLine("Sum: " + sum);

            Console.WriteLine("------------------------------------");

            Counter second = new Muller();
            second.initFields(5, 8);
            second.printFields();
            int mul = second.calcResult();
            Console.WriteLine("Mul: " + mul);

            Console.WriteLine("------------------------------------");

            printCounter(first);
            printCounter(second);
        }
    }
}