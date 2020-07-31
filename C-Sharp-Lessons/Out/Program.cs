using System;

class ControllerDivMod
{
    private int a, b;

    public ControllerDivMod(int aaa, int bbb)
    {
        a = aaa;
        b = bbb;
    }

    public void getDivMod(out int divValue, out int modValue)
    {
        divValue = a / b;
        modValue = a % b;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            ControllerDivMod controller = new ControllerDivMod(a, b);
            int dd;
            int mm;
            controller.getDivMod(out dd, out mm);

            Console.WriteLine(dd);
            Console.WriteLine(mm);
        }
    }
}
