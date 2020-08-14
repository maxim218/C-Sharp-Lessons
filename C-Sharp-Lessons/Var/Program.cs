using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new {login = "Moscow", x = 100, y = 200};
            var second = new {login = "Samara", x = 333, y = 444};

            string loginFirst = first.login;
            int xFirst = first.x;
            int yFirst = first.y;
            Console.WriteLine(loginFirst + " " + xFirst + " " + yFirst);

            string loginSecond = second.login;
            int xSecond = second.x;
            int ySecond = second.y;
            Console.WriteLine(loginSecond + " " + xSecond + " " + ySecond);
        }
    }
}