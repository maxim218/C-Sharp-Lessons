using System;
using System.Text;

class CommandTypeSet {
    private string _commandText = string.Empty;
    private string _variableName = string.Empty;
    private int _variableIntValue = 0;

    public CommandTypeSet(string commandText) {
        _commandText = commandText.Trim();
        Parse();
    }

    private void Parse() {
        string[] parts = _commandText.Split('=');
        _variableName = parts[0];
        _variableIntValue = int.Parse(parts[1]);
    }

    public string GetVarName() => _variableName;
    public int GetVarIntVal() => _variableIntValue;
}

class CommandTypeCaclulation {
    private string _commandText = string.Empty;

    private string _main = string.Empty;
    private string _left = string.Empty;
    private string _right = string.Empty;

    public string KeyMain() => _main;
    public string KeyLeft() => _left;
    public string KeyRight() => _right;

    public CommandTypeCaclulation(string commandText) {
        _commandText = commandText;
        Parse();
    }
    private void Parse() {
        char [] separators = {'=', '+', '-', '*'};
        string[] parts = _commandText.Split(separators);
        _main = parts[0];
        _left = parts[1];
        _right = parts[2];
    }

    public char GetOperation() {
        if (_commandText.Contains('+')) return '+';
        if (_commandText.Contains('-')) return '-';
        if (_commandText.Contains('*')) return '*';
        throw new Exception("Not correct operation Error");
    }
}

class RunnerProgram {
    private Dictionary<string, int> variablesDict = new Dictionary<string, int>();
    private string _fullComand = string.Empty;

    public RunnerProgram(string fullComand) {
        _fullComand = fullComand.Trim();
        _fullComand = DeleteSpaces();
    }

    private string DeleteSpaces() {
        string[] parts = _fullComand.Split(' ');
        StringBuilder builder = new StringBuilder();
        foreach (string p in parts) builder.Append(p);
        return builder.ToString();
    }

    public Dictionary<string, int> RunCommands() {
        string[] parts = _fullComand.Split(';');
        foreach (string p in parts) {
            if(string.IsNullOrEmpty(p) == false) {
                if(p.Contains('+') || p.Contains('-') || p.Contains('*')) {
                    CommandTypeCaclulation cmd = new CommandTypeCaclulation(p);
                    if(cmd.GetOperation() == '+')
                        variablesDict[cmd.KeyMain()] = variablesDict[cmd.KeyLeft()] + variablesDict[cmd.KeyRight()];
                    if(cmd.GetOperation() == '-')
                        variablesDict[cmd.KeyMain()] = variablesDict[cmd.KeyLeft()] - variablesDict[cmd.KeyRight()];
                    if(cmd.GetOperation() == '*')
                        variablesDict[cmd.KeyMain()] = variablesDict[cmd.KeyLeft()] * variablesDict[cmd.KeyRight()];
                } else {
                    CommandTypeSet cmd = new CommandTypeSet(p);
                    string key = cmd.GetVarName();
                    int value = cmd.GetVarIntVal();
                    variablesDict[key] = value;
                }
            }
        }
        return variablesDict;
    }
}

class ProgramMain {
    static void RenderDictionary(Dictionary<string, int> variablesDict) {
        foreach (KeyValuePair<string, int> keyValue in variablesDict) {
            string message = $"{keyValue.Key} : {keyValue.Value}";
            Console.WriteLine(message);
        }
        const string line = "------------------------------------------";
        Console.WriteLine(line);
    }

    static void Main() {
        RenderDictionary(new RunnerProgram("A = 5; B = 7; C = A * B;").RunCommands());
        RenderDictionary(new RunnerProgram("SIDE_A = 12; SIDE_B = 3; SUM = SIDE_A + SIDE_B; TWO = 2; PERIM = SUM * TWO;").RunCommands());
        RenderDictionary(new RunnerProgram("BIG = 100; DA = 12; DB = 17; BIG = BIG - DA; BIG = BIG - DB;").RunCommands());
        RenderDictionary(new RunnerProgram("X = 10; Y = 3; Z = X - Y;").RunCommands());
    }
}
