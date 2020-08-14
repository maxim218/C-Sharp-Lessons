using System;

public class Man
{
    public string manName;
    public int manAge;

    public Man(string manName, int manAge)
    {
        this.manName = manName;
        this.manAge = manAge;
    }
}

public static class ManExtension
{
    public static void renderFields(this Man man)
    {
        string nameString = "Name: " + man.manName;
        string ageString = "Age: " + man.manAge;
        string message = nameString + "\n" + ageString + "\n";
        Console.WriteLine(message);
    }

    public static void changeName(this Man man, string nameString)
    {
        man.manName = nameString;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Man george = new Man("George", 14);
            Man nina = new Man("Nina", 27);

            george.renderFields();
            nina.renderFields();

            Console.WriteLine("----------------------------------------\n");

            george.changeName("GeoGeoGeo");
            nina.changeName("NinNinNin");

            george.renderFields();
            nina.renderFields();
        }
    }
}