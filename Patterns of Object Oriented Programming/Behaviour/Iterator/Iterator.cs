using System;
using System.Collections;
using System.Text;

sealed class Rectangle {
    private int _a = 0;
    private int _b = 0;
    public Rectangle(int a, int b) {
        _a = a;
        _b = b;
    }
    public int A() => _a;
    public int B() => _b;
    public int CalcPerim() => 2 * (_a + _b);
    public int CalcSquare() => _a * _b;
}

sealed class RectanglesCollection {
    private List<Rectangle> arr = new List<Rectangle>();
    public void AddRectangle(Rectangle rect) => arr.Add(rect);
    public List<Rectangle> GetRectangles() => arr;
}

interface IRectanglesIterator {
    public IEnumerable VisitRectangles();
}

class PerimetrsIterator : IRectanglesIterator {
    private List<Rectangle>? _arr = null;

    public PerimetrsIterator(List<Rectangle> collection) {
        _arr = collection;
    }

    public IEnumerable VisitRectangles() {
        if (null == _arr)
            yield break;
        foreach (Rectangle rect in _arr) {
            int p = rect.CalcPerim();
            yield return p;
        }
    }
}

class SquaresIterator : IRectanglesIterator {
    private List<Rectangle>? _arr = null;

    public SquaresIterator(List<Rectangle> collection) {
        _arr = collection;
    }

    public IEnumerable VisitRectangles() {
        if (null == _arr)
            yield break;
        foreach (Rectangle rect in _arr) {
            int s = rect.CalcSquare();
            yield return s;
        }
    }
}

class SidesRectangleIterator : IRectanglesIterator {
    private List<Rectangle>? _arr = null;

    public SidesRectangleIterator(List<Rectangle> collection) {
        _arr = collection;
    }

    public IEnumerable VisitRectangles() {
        if (null == _arr)
            yield break;
        foreach (Rectangle rect in _arr) {
            int a = rect.A();
            int b = rect.B();
            (int, int) tuple = (a, b);
            yield return tuple;
        }
    }
}

class ProgramMain {
    static void Main() {
        RectanglesCollection collectionStore = new RectanglesCollection();
        collectionStore.AddRectangle(new Rectangle(5, 3));
        collectionStore.AddRectangle(new Rectangle(75, 40));
        collectionStore.AddRectangle(new Rectangle(200, 500));

        IRectanglesIterator sidesIterator = new SidesRectangleIterator(collectionStore.GetRectangles());
        IRectanglesIterator perimIterator = new PerimetrsIterator(collectionStore.GetRectangles());
        IRectanglesIterator squareIterator = new SquaresIterator(collectionStore.GetRectangles());

        Console.WriteLine("---------------------------------------------------");
        foreach((int, int) tuple in sidesIterator.VisitRectangles()) {
            int a = tuple.Item1;
            int b = tuple.Item2;
            Console.WriteLine($"A: {a} B: {b}");
        }

        Console.WriteLine("---------------------------------------------------");
        foreach(int perimetr in perimIterator.VisitRectangles()) 
            Console.WriteLine("Perimetr: " + perimetr);

        Console.WriteLine("---------------------------------------------------");
        foreach (int square in squareIterator.VisitRectangles()) 
            Console.WriteLine("Square: " + square);
    }
}
