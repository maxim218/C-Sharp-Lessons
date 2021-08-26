using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

internal class Man {
    public Man(string loginParam, int ageParam) {
        Login = loginParam;
        Age = ageParam;
    }
    
    public string Login { get; } = string.Empty;

    public int Age { get; } = 0;
}

namespace ConsoleApp1 {
    internal static class Program {

        private static void RenderManArray(Man [] arr) {
            Console.WriteLine("            ");
            foreach (Man man in arr) {
                Console.WriteLine(man.Login + " " + man.Age);
            }
            Console.WriteLine("            ");
        }
        
        private static void RenderManArray(IEnumerable <Man> arr) {
            Console.WriteLine("            ");
            foreach (Man man in arr) {
                Console.WriteLine(man.Login + " " + man.Age);
            }
            Console.WriteLine("            ");
        }

        private static void Main(string[] args) {

            Man[] arr = new Man[5];

            arr[0] = new Man("Maxim", 25);
            arr[1] = new Man("Nina", 47);
            arr[2] = new Man("George", 16);
            arr[3] = new Man("Alex", 18);
            arr[4] = new Man("Dmitry", 33);

            RenderManArray(arr);

            IEnumerable<Man> filteredArray = arr.Where(man => (man.Age > 20)).OrderBy(man => -1 * man.Age);
            RenderManArray(filteredArray);
            
            int count = filteredArray.Count();
            Console.WriteLine("Count: " + count);

            int sum = filteredArray.Sum(man => man.Age);
            Console.WriteLine("Sum: " + sum);
        }
        
    }
}