using System;

class Perimetr
{
    private int first;
    private int second;

    public Perimetr(int a, int b)
    {
        this.first = a;
        this.second = b;
    }

    public int getPerimetrValue()
    {
        int sumElems(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        int mulTwo(int s)
        {
            int mul = s * 2;
            return mul;
        }

        int sss = sumElems(first, second);
        int mmm = mulTwo(sss);

        return mmm;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Perimetr perimetr = new Perimetr(4, 11);
            int result = perimetr.getPerimetrValue();
            Console.WriteLine("Result: " + result);
        }
    }
}