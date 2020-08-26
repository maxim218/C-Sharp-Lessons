using System;
using System.Net;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlValue = "http://localhost:5000/my/file";
            string nameValue = "myFile.txt";

            WebClient client = new WebClient();
            client.DownloadFile(urlValue, nameValue);
            Console.WriteLine("Файл загружен");
        }
    }
}