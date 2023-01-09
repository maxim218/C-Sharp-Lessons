using System;
using System.Text;

interface ICalculator {
    public int Calculate();
}

sealed class FactorialCalculator : ICalculator {
    private int _n = 0;

    public FactorialCalculator(int k) {
        _n = k;
    }

    public int Calculate() {
        Console.WriteLine("Calculate factorial for " + _n);
        int value = 1;
        for (int i = 1; i <= _n; i++) value = i * value;
        return value;
    }
}

sealed class ProxyFactorialCalculator : ICalculator {
    private int _n = 0;

    public ProxyFactorialCalculator(int k) {
        _n = k;
    }

    private static Dictionary <int, int> dictionary = new Dictionary <int, int> ();

    public int Calculate() {
        try {
            int answer = dictionary[_n];
            Console.WriteLine("Get from dictionary value for " + _n);
            return answer;
        } catch {
            int data = new FactorialCalculator(_n).Calculate();
            dictionary[_n] = data;
            return dictionary[_n];
        }
    }
}

class ProgramMain {
    static void PrintInfo(int k) {
        int factorial = new ProxyFactorialCalculator(k).Calculate();
        Console.WriteLine($"{k} : {factorial}");
    }

    static void Main() {
        PrintInfo(3);
        PrintInfo(5);
        PrintInfo(7);
        PrintInfo(3);
        PrintInfo(5);
        PrintInfo(7);
    }
}


