using System;
using System.Text;

enum OperationType {
    Empty,
    InsertOne,
    DeleteOne,
    PrintAll
}

class Command {
    private OperationType _type = OperationType.Empty;
    private string _key = string.Empty;
    private string _value = string.Empty;

    public Command(OperationType type, string key, string value) {
        _type = type;
        _key = key;
        _value = value;
    }

    public Command(OperationType type, string key) {
        _type = type;
        _key = key;
        _value = string.Empty;
    }

    public Command(OperationType type) {
        _type = type;
        _key = string.Empty;
        _value = string.Empty;
    }

    public OperationType CommandType() => _type;
    public string CommandKey() => _key;
    public string CommandValue() => _value;
}

class StorageBase {
    private Dictionary<string, string> dictionary = new Dictionary<string, string>();
    private void RunInsertOne(string key, string value) => dictionary[key] = value;
    private void RunDeleteOne(string key) => dictionary.Remove(key);
    
    private void RunPrintAll() {
        foreach (KeyValuePair<string, string> keyValue in dictionary) {
            string message = $"{keyValue.Key} - {keyValue.Value}";
            Console.WriteLine(message);
        }
    }

    public void RunCommand(Command cmd) {
        try {
            switch (cmd.CommandType()) {
                case OperationType.InsertOne:
                    RunInsertOne(cmd.CommandKey(), cmd.CommandValue());
                    break;
                case OperationType.DeleteOne:
                    RunDeleteOne(cmd.CommandKey());
                    break;
                case OperationType.PrintAll:
                    RunPrintAll();
                    break;
            }
        } catch {
            /* Error while running operation */
        }
    }
}

class ProgramMain {
    static void Main() {
        StorageBase storageBase = new StorageBase();

        storageBase.RunCommand(new Command(OperationType.InsertOne, "Maxim", "21"));
        storageBase.RunCommand(new Command(OperationType.InsertOne, "George", "16"));
        storageBase.RunCommand(new Command(OperationType.InsertOne, "Nina", "47"));
        storageBase.RunCommand(new Command(OperationType.InsertOne, "Sergey", "88"));
        storageBase.RunCommand(new Command(OperationType.PrintAll));

        Console.WriteLine("------------------------------------------");

        storageBase.RunCommand(new Command(OperationType.DeleteOne, "George"));
        storageBase.RunCommand(new Command(OperationType.DeleteOne, "Sergey"));
        storageBase.RunCommand(new Command(OperationType.PrintAll));
    }
}


