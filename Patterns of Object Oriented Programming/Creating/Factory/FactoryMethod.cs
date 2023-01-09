using System;
using System.Text;

sealed class Figure {
    private const string CIRCLE = "CIRCLE";
    private const string RECTANGLE = "RECTANGLE";

    private float _figureParam = 0;
    private string _figureType = string.Empty;

    private Figure(float figureParam, string figureType) {
        _figureParam = figureParam;
        _figureType = figureType;
    }

    public float CalcSquare() {
        if (CIRCLE == _figureType)
            return 3.14f * _figureParam * _figureParam;
        if (RECTANGLE == _figureType)
            return _figureParam * _figureParam;
        return 0;
    }

    public override string ToString() {
        if (CIRCLE == _figureType)
            return "Circle with radius " + _figureParam;
        if (RECTANGLE == _figureType)
            return "Rectangle with side " + _figureParam;
        return string.Empty;
    }

    // fabric method
    public static Figure CreateCircle(float value) {
        return new Figure(value, CIRCLE);
    }

    // fabric method
    public static Figure CreateRectangle(float value) {
        return new Figure(value, RECTANGLE);
    }
}

class ProgramMain {
    static void Main() {
        Figure r = Figure.CreateRectangle(5);
        Figure c = Figure.CreateCircle(10);

        Console.WriteLine(r);
        Console.WriteLine(r.CalcSquare());

        Console.WriteLine(c);
        Console.WriteLine(c.CalcSquare());
    }
}


