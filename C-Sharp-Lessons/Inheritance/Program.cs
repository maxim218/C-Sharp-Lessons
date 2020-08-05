using System;

class Rectangle
{
    protected int a;
    protected int b;

    public void initFields(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void printFields()
    {
        string message = $"A: {this.a}  B: {this.b}";
        Console.WriteLine(message);
    }
}

class Counter : Rectangle
{
    public int getSum()
    {
        int result = this.a + this.b;
        return result;
    }

    public int getMul()
    {
        int result = this.a * this.b;
        return result;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter obj = new Counter();
            obj.initFields(4, 6);
            obj.printFields();
            int sum = obj.getSum();
            int mul = obj.getMul();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Mul: " + mul);
        }
    }
}