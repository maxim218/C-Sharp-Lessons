using System;
using System.Text;

class Point {
    private string _name = string.Empty;
    private int _x = 0;
    private int _y = 0;

    public Point(string name, int x, int y) {
        _name = name;
        _x = x;
        _y = y;
    }

    public Point(Point copyFrom) {
        _name = copyFrom._name;
        _x = copyFrom._x;
        _y = copyFrom._y;
    }

    public void SetName(string name) {
        _name = name;
    }

    public override string ToString() {
        string content = $"Name: {_name} X: {_x} Y: {_y}";
        return content;
    }
}

class ProgramMain {
    static void Main() {
        Point a = new Point("A", 5, 7);

        Point b = new Point(a);
        b.SetName("B");

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}


