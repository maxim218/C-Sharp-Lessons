using System;
using System.Collections;
using System.Text;

interface IStorage {
    public void SaveToStorage(int info);
    public void RenderStorage();
}

class EmptyStorage : IStorage {
    public void SaveToStorage(int info) { /* empty */ }
    public void RenderStorage() { /* empty */ }
}

class Storage : IStorage {
    private List<int> _list = new List<int>();
    public void SaveToStorage(int info) => _list.Add(info);
    public void RenderStorage() {
        for (int index = 0; index < _list.Count; index++) Console.WriteLine($"Your count {index} - {_list[index]}");
    }
}

class BankCount {
    private int _count = 0;
    private IStorage ? _storage = null;
    public BankCount(IStorage storage) {
        _storage = storage;
        _storage.SaveToStorage(_count);
    }
    public void AddToCount(int delta) {
        _count += delta;
        _storage.SaveToStorage(_count);
    }
    public int GetCount() => _count;
    public void RenderHistory() => _storage.RenderStorage();
}

class ProgramMain {
    static void Main() {
        const bool useStorage = true;

        IStorage storage = useStorage ? new Storage() : new EmptyStorage();

        BankCount bankCount = new BankCount(storage);
        bankCount.AddToCount(40);
        bankCount.AddToCount(100);
        bankCount.AddToCount(60);
        Console.WriteLine("Money: " + bankCount.GetCount());
        bankCount.RenderHistory();
    }  
}
