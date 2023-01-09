using System;
using System.Text;
using System.Text.Json;

[Serializable]
class Point {
    public string login { get; set; } = string.Empty;
    public int x { get; set; } = 0;
    public int y { get; set; } = 0;

    public string ToJsonString() {
        string jsonString = JsonSerializer.Serialize(this);
        return jsonString;
    }

    public static Point CreateFromJson(string jsonString) {
        Point ? point = JsonSerializer.Deserialize<Point>(jsonString);
        return point;
    }

    public static Point CreatePoint(string loginParam, int xParam, int yParam) {
        Point point = new Point { login = loginParam, x = xParam, y = yParam };
        return point;
    }

    public override string ToString() {
        return ToJsonString();
    }
}

class ProgramMain {
    static void Main() {
        Point a = Point.CreatePoint("A", 5, 7);

        Point b = Point.CreateFromJson(a.ToJsonString());
        b.login = "B";

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}


