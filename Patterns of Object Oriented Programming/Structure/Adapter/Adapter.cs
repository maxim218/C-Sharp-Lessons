using System;
using System.Text;
using System.Text.Json;

class Rectangle {
    private int _sideA = 0;
    private int _sideB = 0;

    public Rectangle(int aVal, int bVal) {
        _sideA = aVal;
        _sideB = bVal;
    }

    public int SideA() => _sideA;
    public int SideB() => _sideB;
}

class PerimetrCalculator {
    private List<int>? sidesValues = null;

    public PerimetrCalculator(List<int> sides) {
        sidesValues = sides;
    }

    public int CalcPerimetr() {
        int sumSides = 0;
        if (sidesValues != null) { 
            foreach (int side in sidesValues) sumSides += side; 
        }
        return sumSides;
    }
}

static class SidesAdapter {
    public static List<int> AdaptSidesForPerimetr(Rectangle rectangle) {
        int a = rectangle.SideA();
        int b = rectangle.SideB();
        List<int> sides = new List<int>{ a, a, b, b };
        return sides;
    }
}

class ProgramMain {
    static void Main() {
        Rectangle figureRectangle = new Rectangle(9, 6);
        int p = new PerimetrCalculator(
            SidesAdapter.AdaptSidesForPerimetr(figureRectangle)
        ).CalcPerimetr();
        Console.WriteLine("Perimetr: " + p);
    }
}


