using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // получаем дату и время в формате строки
            string s = DateTime.Now.ToString();
            Console.WriteLine(s);

            Console.WriteLine("------------------------------------");

            // модифицирую строку в собственный формат
            s = s.Replace(" ", "_");
            s = s.Replace(".", "_");
            s = s.Replace(",", "_");
            s = s.Replace(":", "_");
            Console.WriteLine(s);
        }
    }
}