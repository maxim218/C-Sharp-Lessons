using System;
using System.Text;

interface IDivider {
    public void InitNumbers(int a, int b);
    public int CalculateDiv();
}

sealed class NumbersDivider : IDivider {
    private int _a = 0;
    private int _b = 0;

    public void InitNumbers(int a, int b) {
        _a = a;
        _b = b;
    }

    public int CalculateDiv() {
        int result = _a / _b;
        return result;
    }
}

class DecoratorNumbersDivider : IDivider {
    private NumbersDivider _numbersDivider = new NumbersDivider();

    public void InitNumbers(int a, int b) {
        _numbersDivider.InitNumbers(a, b);
    }

    public int CalculateDiv() {
        try {
            return _numbersDivider.CalculateDiv();
        } catch {
            return 0;
        }
    }
}

class ProgramMain {
    static void Main() {
        IDivider objA = new NumbersDivider();
        objA.InitNumbers(15, 7);
        Console.WriteLine(objA.CalculateDiv());

        IDivider objB = new DecoratorNumbersDivider();
        objB.InitNumbers(25, 0);
        Console.WriteLine(objB.CalculateDiv());

        IDivider objC = new DecoratorNumbersDivider();
        objC.InitNumbers(36, 10);
        Console.WriteLine(objC.CalculateDiv());
    }
}


