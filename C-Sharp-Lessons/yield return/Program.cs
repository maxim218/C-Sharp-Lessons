using System;
using System.Collections;

class Man {
    private readonly string _name;
    private readonly int _age;
    
    public Man(string name, int age) {
        _name = name;
        _age = age;
    }

    public string GetName() {
        return _name;
    }

    public int GetAge() {
        return _age;
    }
}

class People {
    private readonly ArrayList _arrayList;

    public People() {
        _arrayList = new ArrayList();
    }

    public void AddMan(string name, int age) {
        Man man = new Man(name, age);
        _arrayList.Add(man);
    }

    public IEnumerable VisitPeople() {
        int count = _arrayList.Count;
        for (int i = 0; i < count; i++) {
            yield return (Man) _arrayList[i];
        }
    }
}

namespace ConsoleApp1 {
    static class Program {
        static void Main(string[] args) {
            People people = new People();
            
            people.AddMan("Maxim", 10);
            people.AddMan("Nina", 30);
            people.AddMan("George", 20);
            people.AddMan("Alex", 40);

            foreach (Man man in people.VisitPeople()) {
                string message = man.GetName() + " " + man.GetAge();
                Console.WriteLine(message);
            }
        }
    }
}