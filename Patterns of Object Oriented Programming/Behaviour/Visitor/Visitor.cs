using System;
using System.Text;
using System.Collections;

interface IAcceptVisitor {
    public void AcceptVisitor(Visitor visitor);
}

class Rectangle : IAcceptVisitor {
    private int _a = 0;
    private int _b = 0;
    public Rectangle(int a, int b) {
        this._a = a;
        this._b = b;
    }
    public int CalcRectangleSquare() {
        int square = this._a * this._b;
        return square;
    }
    public void AcceptVisitor(Visitor visitor) => visitor.RunForRectangle(this);
}

class Kv : IAcceptVisitor {
    private int _side = 0;
    public Kv(int side) {
        this._side = side;
    }
    public int CalcKvSquare() {
        int square = this._side * this._side;
        return square;
    }
    public void AcceptVisitor(Visitor visitor) => visitor.RunForKv(this);
}

class Visitor {
    private Action <int> ? _action = null;
    public Visitor(Action <int> action) {
        _action = action;
    }
    public void RunForRectangle(Rectangle rectangle) {
        int s = rectangle.CalcRectangleSquare();
        if(null != _action) _action(s);
    }
    public void RunForKv(Kv kv) {
        int s = kv.CalcKvSquare();
        if (null != _action) _action(s);
    }
}

class ProgramMain {
    static void Main() {
        Visitor visitor = new Visitor(square => Console.WriteLine("Square: " + square));

        IAcceptVisitor r = new Rectangle(5, 7);
        IAcceptVisitor k = new Kv(4);

        r.AcceptVisitor(visitor);
        k.AcceptVisitor(visitor);
    }
}
