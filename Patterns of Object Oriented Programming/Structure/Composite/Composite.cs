using System;
using System.Text;

interface ISalary {
    public int GetSalary();
}

class Person : ISalary {
    private int _salary = 0;

    public Person(int salary) {
        _salary = salary;
    }

    public int GetSalary() => _salary;
}

class Department : ISalary {
    private List<ISalary> objectsSalaries = new List<ISalary>();

    public Department AddInfo(ISalary elemWithSalary) {
        objectsSalaries.Add(elemWithSalary);
        return this;
    }

    public int GetSalary() {
        int sumSalaries = 0;
        foreach (ISalary obj in objectsSalaries) sumSalaries += obj.GetSalary();
        return sumSalaries;
    }
}


class ProgramMain {
    static void Main() {
        Person maxim = new Person(120);
        Person nina = new Person(80);
        Person george = new Person(50);
        Person ann = new Person(110);
        Person alex = new Person(170);

        Department A = new Department();
        A.AddInfo(maxim).AddInfo(nina).AddInfo(george);

        Department B = new Department();
        B.AddInfo(ann).AddInfo(alex);

        Department C = new Department();
        C.AddInfo(A).AddInfo(B);

        string resultMessage = "Total salary: " + C.GetSalary();
        Console.WriteLine(resultMessage);
    }
}


