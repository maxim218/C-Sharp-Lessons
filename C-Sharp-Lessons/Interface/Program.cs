using System;

interface CounterInterface
{
    public void initFields(int a, int b);
    public int calculateResult();
    public void renderFields();
}

class Summer : CounterInterface
{
    private int a;
    private int b;

    public void initFields(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int calculateResult()
    {
        int sum = this.a + this.b;
        return sum;
    }

    public void renderFields()
    {
        string message = "Fields: " + this.a + " " + this.b;
        Console.WriteLine(message);
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterInterface obj = new Summer();
            obj.initFields(2, 8);
            obj.renderFields();
            int sum = obj.calculateResult();
            Console.WriteLine("Sum: " + sum);
        }
    }
}