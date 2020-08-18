using System;
using System.Text.Json;

class Point
{
    public string city { get; set; }
    public int x { get; set; }
    public int y { get; set; }
}

class GroupPoint
{
    public Point [] arr { get; set; }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupPoint groupPoint = new GroupPoint();

            groupPoint.arr = new Point[5];

            groupPoint.arr[0] = new Point { city = "Moscow", x = 57, y = 0};
            groupPoint.arr[1] = new Point { city = "Samara", x = 0, y = -123};
            groupPoint.arr[2] = new Point { city = "", x = 25, y = 30};
            groupPoint.arr[3] = new Point { city = null, x = -42, y = 0};
            groupPoint.arr[4] = new Point { city = "Piter", x = 0, y = 0 };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize <GroupPoint> (groupPoint, options);
            Console.WriteLine(jsonString);
        }
    }
}