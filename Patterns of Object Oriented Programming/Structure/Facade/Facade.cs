using System;
using System.Text;

static class FacadeCalculator {
    sealed class TwoSides {
        private int _a = 0;
        private int _b = 0;
        public TwoSides(int a, int b) {
            _a = a;
            _b = b;
        }
        public int A() => _a;
        public int B() => _b;
    }

    class PerimCalculate {
        private TwoSides _twoSides = new TwoSides(0, 0);
        public PerimCalculate(TwoSides ts) {
            _twoSides = ts;
        }

        public int CalcPerim() {
            int s = _twoSides.A() + _twoSides.B();
            int p = s * 2;
            return p;
        }
    }

    public static int CalculatePerim(int sideA, int sideB) {
        TwoSides twoSides = new TwoSides(sideA, sideB);
        PerimCalculate perimCalc = new PerimCalculate(twoSides);
        int perim = perimCalc.CalcPerim();
        return perim;
    }
}

class ProgramMain {
    static void Main() {
        int perim = FacadeCalculator.CalculatePerim(2, 3);
        Console.WriteLine("Perim: " + perim);
    }
}


