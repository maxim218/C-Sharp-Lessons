using System;

class Printer
{
    public delegate void RenderFunc(int element);

    private int[] arr;
    private RenderFunc renderFunc;

    public Printer(int[] arr, RenderFunc renderFunc)
    {
        this.arr = arr;
        this.renderFunc = renderFunc;
    }
    
    public void renderArray()
    {
        for (int i = 0; i < arr.Length; i++) renderFunc(arr[i]);
    }
}


namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            mass[0] = 100;
            mass[1] = 10;
            mass[2] = 200;
            mass[3] = 20;
            mass[4] = 300;

            int index = 0;

            Printer printer = new Printer(mass, delegate(int x) {
                string message = "element " + index + " is " + x;
                Console.WriteLine(message);
                index++;
            });

            printer.renderArray();
        }
    }
}