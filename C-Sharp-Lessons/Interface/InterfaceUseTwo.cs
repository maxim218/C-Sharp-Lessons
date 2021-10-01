using System;

internal interface ISum {
    public int CalcSum();
}

internal interface IMul {
    public int CalcMul();
}

internal class Calculator : ISum, IMul {
    private int _a = 0;
    private int _b = 0;

    public void InitFields(int a, int b) {
        _a = a;
        _b = b;
    }

    public void RenderFields() {
        string message = "A: " + _a + "  B: " + _b;
        Console.WriteLine(message);
    }
    
    public int CalcSum() {
        int sum = _a + _b;
        return sum;
    }

    public int CalcMul() {
        int mul = _a * _b;
        return mul;
    }
}

namespace ConsoleApp {
    internal static class Program {
        private static void UseSum(ISum obj) {
            int sum = obj.CalcSum();
            Console.WriteLine("Sum: " + sum);
        }

        private static void UseMul(IMul obj) {
            int mul = obj.CalcMul();
            Console.WriteLine("Mul: " + mul);
        }

        private static void Main(string[] args) {
            // create and init
            Calculator calculator = new Calculator();
            calculator.InitFields(2, 7);
            calculator.RenderFields();
            
            // interfaces using
            UseSum(calculator);
            UseMul(calculator);
        }
    }
}