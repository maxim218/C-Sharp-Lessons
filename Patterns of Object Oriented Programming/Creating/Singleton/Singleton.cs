using System;
using System.Text;
using System.Text.Json;

class InfoStorage {
    private Dictionary<string, string>? _storage = null;

    public InfoStorage() {
        Console.WriteLine("Creating storage dictionary");
        _storage = new Dictionary <string, string>(){
            {"M", "Maxim"},
            {"N", "Nina"},
            {"G", "George"},
            {"K", "Kate"},
            {"A", "Ann"}
        };
    }

    public string GetByKey(string key) {
        try {
            if(_storage == null) return string.Empty;
            return _storage[key];
        } catch {
            return string.Empty;
        }
    }
}

static class SingletonForStorage {
    private static InfoStorage? _infoStorage = null;

    public static InfoStorage GetStorage() {
        if (_infoStorage == null) _infoStorage = new InfoStorage();
        return _infoStorage;
    }
}

class ProgramMain {
    static void Main() {
        string m = SingletonForStorage.GetStorage().GetByKey("M");
        string g = SingletonForStorage.GetStorage().GetByKey("G");
        string a = SingletonForStorage.GetStorage().GetByKey("A");

        string message = $"{m} {g} {a}";
        Console.WriteLine(message.Trim());
    }
}


