using System;
using System.Text;

class Material {
    private string _color = string.Empty;
    private int _opacity = 0;
    private int _metalic = 0;
    public override string ToString() {
        string content = $"Color {_color} Opacity {_opacity} Metalic {_metalic}";
        return content;
    }
    private Material(string color, int opacity, int metalic) {
        _color = color;
        _opacity = opacity;
        _metalic = metalic;
    }
    public string GetColor() => _color;
    public int GetOpacity() => _opacity;
    public int GetMetalic() => _metalic;

    private static List<Material> materialsArray = new List<Material>();

    public static Material CreateMaterial(string color, int opacity, int metalic) {
        foreach (Material m in materialsArray) {
            bool materialsEqual = (m.GetColor() == color && m.GetOpacity() == opacity && m.GetMetalic() == metalic);
            if (materialsEqual) return m;
        }
        Material material = new Material(color, opacity, metalic);
        materialsArray.Add(material);
        return material;
    }

    public static void PrintAllExistingMaterials() {
        foreach (Material m in materialsArray) {
            Console.WriteLine("Material: " + m);
        }
    }
}

class BotEnemy {
    private string _login = string.Empty;
    private Material? _material = null;
    public BotEnemy(string login, Material material) {
        _login = login;
        _material = material;
    }
    public override string ToString() {
        string info = $"Bot {_login} has material - {_material}";
        return info.Trim();
    }
}

class ProgramMain {
    static void Main() {
        BotEnemy a = new BotEnemy("A", Material.CreateMaterial("red", 40, 30));
        BotEnemy b = new BotEnemy("B", Material.CreateMaterial("blue", 40, 30));
        BotEnemy c = new BotEnemy("C", Material.CreateMaterial("red", 40, 30));
        BotEnemy d = new BotEnemy("D", Material.CreateMaterial("blue", 40, 30));

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);

        Console.WriteLine("-----------------------------------------------------------------------");

        Material.PrintAllExistingMaterials();
    }
}


