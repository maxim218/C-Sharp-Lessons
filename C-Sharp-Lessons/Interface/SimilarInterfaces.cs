using System;

internal interface IPowSecond {
    int Calculate();
}

internal interface IPowThird {
    int Calculate();
}

internal class Power : IPowSecond, IPowThird {
    private int _value = 0;

    private void SetValue(int value) {
        _value = value;
    }
    
    public Power(int value) {
        SetValue(value);
    }

    int IPowSecond.Calculate() {
        return _value * _value;
    }

    int IPowThird.Calculate() {
        return _value * _value * _value;
    }
}

namespace ConsoleApp {
    internal static class Program {
        private static void Main(string[] args) {
            // create and init
            const int val = 5;
            Power powerObject = new Power(val);

            // calc pow
            int pow2 = ((IPowSecond)powerObject).Calculate();
            int pow3 = ((IPowThird)powerObject).Calculate();

            // render
            string message = pow2 + " " + pow3;
            Console.WriteLine(message);
        }
    }
}