using System;

class ShopProduct
{
    // Статический счетчик экземпляров класса
    private static int elementsCount = 0;
    // Статический массив для хранения ссылок на экземпляры класса
    private static ShopProduct[] arr = new ShopProduct[100];

    public static int getElementsCount()
    {
        return elementsCount;
    }

    public static void printAllElements()
    {
        for(int i = 0; i < elementsCount; i++)
        {
            string nameMessage = "Name: " + arr[i].name;
            string costMessage = "Cost: " + arr[i].cost;
            string fullMessage = nameMessage + "  " + costMessage;
            Console.WriteLine(fullMessage);
        }
    }

    private string name;
    private int cost;

    public ShopProduct(string name, int cost)
    {
        this.name = name;
        this.cost = cost;

        arr[elementsCount] = this;
        elementsCount = elementsCount + 1;
    }
}

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopProduct a = new ShopProduct("Oranges", 45);
            ShopProduct b = new ShopProduct("Apples", 123);
            ShopProduct c = new ShopProduct("Bananas", 77);

            ShopProduct.printAllElements();

            int count = ShopProduct.getElementsCount();
            Console.WriteLine("Count: " + count);
        }
    }
}
