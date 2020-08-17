using System;
using System.Text.Json;

class Man
{
    public string login { get; set; }
    public int age { get; set; } 
}

class Family
{
    public Man mother { get; set; }
    public Man father { get; set; }
}

class GroupMan
{
    public Man[] arr { get; set; }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем двух людей
            Man aaa = new Man { login = "Ann", age = 25 };
            Man ggg = new Man { login = "George", age = 37 };

            // создаем семью из двух людей
            Family objFamily = new Family { mother = aaa, father = ggg };

            // получаем семью в формате строки JSON
            string jsonString = JsonSerializer.Serialize <Family> (objFamily);
            Console.WriteLine(jsonString);

            Console.WriteLine("\n-------------------------------------------------\n");

            // получаем объект из строки JSON
            Family familyResult = JsonSerializer.Deserialize <Family> (jsonString);
            Console.WriteLine(familyResult.mother.login + " " + familyResult.mother.age);
            Console.WriteLine(familyResult.father.login + " " + familyResult.father.age);

            Console.WriteLine("\n-------------------------------------------------\n");

            // создаем экземпляр класса (внутри него массив)
            GroupMan groupMan = new GroupMan();
            // выделяем память под массив на 3 ячейки
            groupMan.arr = new Man[3];
            // заполняем ячейки массива
            groupMan.arr[0] = new Man { login = "Piter", age = 45 };
            groupMan.arr[1] = new Man { login = "Alex",  age = 12 };
            groupMan.arr[2] = new Man { login = "Nina",  age = 78 };

            // преобразуем объект (внутри которого массив) в строку JSON
            string groupJsonString = JsonSerializer.Serialize<GroupMan>(groupMan);
            Console.WriteLine(groupJsonString);

            Console.WriteLine("\n-------------------------------------------------\n");

            // получаем из строки JSON объект
            GroupMan resultGroup = JsonSerializer.Deserialize <GroupMan> (groupJsonString);
            // пробегаемся по всем ячейкам массива (находящегося внутри объекта)
            for (int i = 0; i < resultGroup.arr.Length; i++)
            {
                Man man = resultGroup.arr[i];
                Console.WriteLine(man.login + " " + man.age);
            }

            Console.WriteLine("\n-------------------------------------------------\n");
        }
    }
}