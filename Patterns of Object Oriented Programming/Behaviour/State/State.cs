using System;
using System.Text;
using System.Collections;

enum StateType {
    Exit,
    MainMenu,
    AddingMoney,
    TakingMoney,
    ShowingBalance,
    ErrorScreen,
    OkScreen
}

class FinanceStateMachine {
    public int Count = 0;
    private Dictionary<StateType, IState> _states = new Dictionary<StateType, IState>();
    public FinanceStateMachine(int startCount) {
        Count = startCount;

        _states[StateType.MainMenu] = new MenuState();
        _states[StateType.ShowingBalance] = new ShowBalanceState();
        _states[StateType.AddingMoney] = new AddMoneyState();
        _states[StateType.TakingMoney] = new TakeMoneyState();
        _states[StateType.ErrorScreen] = new ErrorScreenState();
        _states[StateType.OkScreen] = new OkScreenState();

        _states[StateType.MainMenu].SetMachine(this);
        _states[StateType.ShowingBalance].SetMachine(this);
        _states[StateType.AddingMoney].SetMachine(this);
        _states[StateType.TakingMoney].SetMachine(this);
        _states[StateType.ErrorScreen].SetMachine(this);
        _states[StateType.OkScreen].SetMachine(this);
    }
    public void Run() {
        StateType currentState = StateType.MainMenu;
        _states[currentState].ShowInfo();
        currentState = _states[currentState].ReadAction();
        Console.WriteLine("---------------------------------------------------");
        while (StateType.Exit != currentState) {
            _states[currentState].ShowInfo();
            currentState = _states[currentState].ReadAction();
            Console.WriteLine("---------------------------------------------------");
        }
    }
}

interface IState {
    public void ShowInfo();
    public StateType ReadAction();
    public void SetMachine(FinanceStateMachine machine);
}

class MenuState : IState {
    private FinanceStateMachine ? _machine = null;
    public void SetMachine(FinanceStateMachine machine) => _machine = machine;
    public void ShowInfo() {
        StringBuilder builder = new StringBuilder();
        builder.Append("Choose operation:\n");
        builder.Append("1) add money\n");
        builder.Append("2) take money\n");
        builder.Append("3) show balance\n");
        string msg = builder.ToString();
        Console.WriteLine(msg);
    }
    public StateType ReadAction() {
        int action = int.Parse(Console.ReadLine());
        if (1 == action) return StateType.AddingMoney;
        if (2 == action) return StateType.TakingMoney;
        if (3 == action) return StateType.ShowingBalance;
        return StateType.Exit;
    }
}

class ShowBalanceState : IState {
    private FinanceStateMachine? _machine = null;
    public void SetMachine(FinanceStateMachine machine) => _machine = machine;
    public void ShowInfo() {
        string message = "Balance: " + _machine.Count;
        Console.WriteLine(message);
        StringBuilder builder = new StringBuilder();
        builder.Append("Choose operation:\n");
        builder.Append("1) go to main menu\n");
        string msg = builder.ToString();
        Console.WriteLine(msg);
    }
    public StateType ReadAction() {
        int action = int.Parse(Console.ReadLine());
        if (1 == action) return StateType.MainMenu;
        return StateType.Exit;
    }
}

class AddMoneyState : IState {
    private FinanceStateMachine? _machine = null;
    public void SetMachine(FinanceStateMachine machine) => _machine = machine;
    public void ShowInfo() {
        const string msg = "Input money amount to ADD";
        Console.WriteLine(msg);
    }
    public StateType ReadAction() {
        int moneyNumber = int.Parse(Console.ReadLine());
        _machine.Count = _machine.Count + moneyNumber;
        return StateType.OkScreen;
    }
}

class TakeMoneyState : IState {
    private FinanceStateMachine? _machine = null;
    public void SetMachine(FinanceStateMachine machine) => _machine = machine;
    public void ShowInfo() {
        const string msg = "Input money amount to TAKE";
        Console.WriteLine(msg);
    }
    public StateType ReadAction() {
        int moneyNumber = int.Parse(Console.ReadLine());
        if (_machine.Count < moneyNumber) {
            return StateType.ErrorScreen;
        } else {
            _machine.Count -= moneyNumber;
            return StateType.OkScreen;
        }
    }
}

class ErrorScreenState : IState {
    private FinanceStateMachine? _machine = null;
    public void SetMachine(FinanceStateMachine machine) => _machine = machine;
    public void ShowInfo() => Console.WriteLine("Error while Operation");
    public StateType ReadAction() => StateType.MainMenu;
}

class OkScreenState : IState {
    private FinanceStateMachine? _machine = null;
    public void SetMachine(FinanceStateMachine machine) => _machine = machine;
    public void ShowInfo() => Console.WriteLine("Operation OK");
    public StateType ReadAction() => StateType.MainMenu;
}

class ProgramMain {
    static void Main() {
        new FinanceStateMachine(1000).Run();
    }
}
