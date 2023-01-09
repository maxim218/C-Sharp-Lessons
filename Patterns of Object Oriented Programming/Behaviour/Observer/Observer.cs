using System;
using System.Collections;
using System.Text;

class Storage {
    private List<int> _elements = new List<int>();

    public delegate void F(int element);
    public event F ? OnElementAdd;

    public void PushElement(int element) {
        _elements.Add(element);
        OnElementAdd?.Invoke(element);
    }
    public void RenderAll() {
        StringBuilder stringBuilder = new StringBuilder("Elements: ");
        foreach (int element in _elements) stringBuilder.Append(element + " ");
        string message = stringBuilder.ToString();
        Console.WriteLine(message);
    }
}

static class Operations {
    public static void PrintInfo(int element) {
        string message = "Save element " + element;
        Console.WriteLine(message);
    }
    public static void PrintModInfo(int element) {
        int mod = element % 2;
        string type = (0 == mod) ? "Zero" : "One";
        Console.WriteLine($"{element} mod is {type}");
    }
}

class Counter {
    private int _count = 0;
    public Counter() => _count = 0;
    public void IncCount(int element) => this._count++;
    public void RenderCount() => Console.WriteLine("Count: " + this._count);
}

class ProgramMain {
    static void Main() {
        Counter counter = new Counter();
        Storage storage = new Storage();

        storage.OnElementAdd += Operations.PrintInfo;
        storage.OnElementAdd += Operations.PrintModInfo;
        storage.OnElementAdd += counter.IncCount;

        storage.PushElement(10);
        storage.PushElement(17);
        storage.PushElement(19);
        storage.PushElement(40);

        storage.OnElementAdd -= Operations.PrintInfo;
        storage.OnElementAdd -= Operations.PrintModInfo;

        storage.PushElement(777);
        storage.PushElement(888);

        storage.OnElementAdd -= counter.IncCount;

        Console.WriteLine("----------------------------------------");
        storage.RenderAll();
        counter.RenderCount();
    }
}
