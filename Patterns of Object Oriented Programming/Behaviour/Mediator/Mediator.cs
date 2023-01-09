using System;
using System.Collections;
using System.Text;

class Person {
    private string _name = string.Empty;
    private int _money = 0;
    public Person(string name, int money) {
        _name = name;
        _money = money;
    }
    public void AddMoney(int moneyPlus) {
        _money += moneyPlus;
    }
    public void SubsubstractMoney(int moneyMinus) {
        _money -= moneyMinus;
    }
    public string GetName() => _name;
    public void PrintInfo() {
        string info = $"{_name} : {_money}";
        Console.WriteLine(info);
    }
}

class MediatorFinans {
    private List<Person> _personsList = new List<Person>();

    public void AddPerson(Person person) {
        _personsList.Add(person);
    }
    public void PrintPersonsInfo() {
        foreach (Person p in _personsList) p.PrintInfo();
        const string line = "------------------------------------------";
        Console.WriteLine(line);
    }
    public void MoneyTransfer(string nameFrom, string nameTo, int moneyDelta) {
        Person fromPerson = FindPersonByName(nameFrom);
        Person toPerson = FindPersonByName(nameTo);
        fromPerson.SubsubstractMoney(moneyDelta);
        toPerson.AddMoney(moneyDelta);
    }
    private Person FindPersonByName(string name) {
        Person? result = null;
        foreach (Person p in _personsList) {
            if (p.GetName() == name) result = p;
        }
        return result;
    }
}

class ProgramMain {
    static void Main() {
        MediatorFinans mediator = new MediatorFinans();

        Person maxim = new Person("Maxim", 3000);
        Person nina = new Person("Nina", 2500);
        Person george = new Person("George", 4500);
        Person alex = new Person("Alex", 1000);

        mediator.AddPerson(maxim);
        mediator.AddPerson(nina);
        mediator.AddPerson(george);
        mediator.AddPerson(alex);

        mediator.PrintPersonsInfo();

        mediator.MoneyTransfer("Maxim", "Nina", 2700);
        mediator.MoneyTransfer("George", "Alex", 3300);

        mediator.PrintPersonsInfo();
    }
}
