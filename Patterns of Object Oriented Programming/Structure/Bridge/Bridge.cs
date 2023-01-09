using System;
using System.Text;
using System.Text.Json;

class SidesStorage {
    public float A = 0;
    public float B = 0;
}

interface ICalculator {
    public float Calculate();
    public string OperationType();
}

class SquareCounter : SidesStorage, ICalculator {
    public float Calculate() {
        float square = A * B;
        return square;
    }

    public string OperationType() => "Square";
}

class PerimCounter : SidesStorage, ICalculator {
    public float Calculate() {
        float perim = (A + B) * 2;
        return perim;
    }

    public string OperationType() => "Perimetr";
}

interface IMessagePrinter {
    public void PrintMessage(string calcType, float calcValue);
}

class MessageShortPrinter : SidesStorage, IMessagePrinter {
    public void PrintMessage(string calcType, float calcValue) {
        string message = $"A = {A} B = {B} Type = {calcType} Answer = {calcValue}";
        Console.WriteLine(message);
    }
}

class MessageLongPrinter : SidesStorage, IMessagePrinter {
    public void PrintMessage(string calcType, float calcValue) {
        string message = $"Value A = {A} Value B = {B} Operation type = {calcType} Calculation answer = {calcValue}";
        Console.WriteLine(message);
    }
}

class Bridge {
    private ICalculator? _calculator = null;
    private IMessagePrinter? _messagePrinter = null;

    private float _calculationResult = 0;

    public Bridge(ICalculator calculator, IMessagePrinter messagePrinter) {
        _calculator = calculator;
        _messagePrinter = messagePrinter;
    }

    public Bridge CalculateFigureData() {
        if(null != _calculator) 
            _calculationResult = _calculator.Calculate();
        return this;
    }

    public void MessageToConsole() {
        if(null != _messagePrinter && null != _calculator) 
            _messagePrinter.PrintMessage(_calculator.OperationType(), _calculationResult);
    }
}

class ProgramMain {
    static void Main() {
        const int a = 5;
        const int b = 7;

        SquareCounter squareCounter = new SquareCounter { A = a, B = b };
        PerimCounter perimCounter = new PerimCounter { A = a, B = b };

        MessageShortPrinter shortMsg = new MessageShortPrinter { A = a, B = b };
        MessageLongPrinter longMsg = new MessageLongPrinter { A = a, B = b };

        new Bridge(squareCounter, shortMsg).CalculateFigureData().MessageToConsole();
        new Bridge(squareCounter, longMsg).CalculateFigureData().MessageToConsole();

        Console.WriteLine("-------------------------");

        new Bridge(perimCounter, shortMsg).CalculateFigureData().MessageToConsole();
        new Bridge(perimCounter, longMsg).CalculateFigureData().MessageToConsole();
    }
}


