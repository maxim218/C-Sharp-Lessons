using System;
using System.Collections;
using System.Text;
using System.Text.Json;

class Purchase {
    public string? name { get; set; } = string.Empty;
    public int count { get; set; } = 0;
}

class HistoryManager {
    private Stack<string> _historyStack = new Stack<string>();
    public void SaveState(PurchasesManager purchasesManager) {
        string snapshot = purchasesManager.ToString();
        _historyStack.Push(snapshot);
    }
    public void UndoState(PurchasesManager purchasesManager) {
        if(_historyStack.Count > 0) 
            _historyStack.Pop();
        if (_historyStack.Count > 0) {
            string state = _historyStack.Peek();
            purchasesManager.SetContent(state);
            return;
        } else {
            string state = "[]";
            purchasesManager.SetContent(state);
            return;
        }
    }
    public void RenderStates() {
        foreach (string state in _historyStack) Console.WriteLine(state);
        const string line = "------------------------------------------------------------";
        Console.WriteLine(line);
    }
}

class PurchasesManager {
    private List<Purchase> _listPurchases = new List<Purchase>();
    public void AddPurchase(string name, int count) {
        Purchase p = new Purchase();
        p.name = name;
        p.count = count;
        _listPurchases.Add(p);
    }
    public void AddCountToPurchase(string name, int countDelta) {
        foreach (Purchase p in _listPurchases) {
            if (name == p.name) p.count = countDelta + p.count;
        }
    }
    public override string ToString() {
        string jsonString = JsonSerializer.Serialize<List<Purchase>>(_listPurchases);
        return jsonString;
    }
    public void SetContent(string content) {
        string jsonString = content;
        List <Purchase> ? list = JsonSerializer.Deserialize<List<Purchase>>(jsonString);
        if (list != null) _listPurchases = list;
    }
    public void PrintPurchases() {
        if(_listPurchases.Count > 0) {
            foreach (Purchase p in _listPurchases) Console.WriteLine($"{p.name} : {p.count}");
        } else {
            Console.WriteLine("Empty");
        }
        Console.WriteLine("----------------------------------------------");
    }
}

class ProgramMain {
    static void Main() {
        PurchasesManager purchasesManager = new PurchasesManager();
        HistoryManager historyManager = new HistoryManager();

        purchasesManager.AddPurchase("apples", 8);
        purchasesManager.AddPurchase("bananas", 2);
        purchasesManager.AddPurchase("oranges", 7);
        historyManager.SaveState(purchasesManager);

        purchasesManager.AddCountToPurchase("apples", 210);
        purchasesManager.AddCountToPurchase("oranges", 560);
        historyManager.SaveState(purchasesManager);

        purchasesManager.AddCountToPurchase("bananas", 2020);
        historyManager.SaveState(purchasesManager);

        historyManager.RenderStates();

        purchasesManager.PrintPurchases();
        historyManager.UndoState(purchasesManager);
        purchasesManager.PrintPurchases();
        historyManager.UndoState(purchasesManager);
        purchasesManager.PrintPurchases();
        historyManager.UndoState(purchasesManager);
        purchasesManager.PrintPurchases();
        historyManager.UndoState(purchasesManager);
        purchasesManager.PrintPurchases();
    }  
}
