using System;
using System.IO;
using System.Net;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string sendGet(string urlValue)
            {
                WebRequest request = WebRequest.Create(urlValue);
                WebResponse response = request.GetResponse();
                using Stream stream = response.GetResponseStream();
                using StreamReader reader = new StreamReader(stream);
                string line = "";
                string buffer = "";
                while ((line = reader.ReadLine()) != null) buffer += (line + "\n");
                response.Close();
                return buffer;
            }

            string p = sendGet("http://localhost:5000/my/pyramid?x=p");
            Console.WriteLine(p);

            Console.WriteLine("--------------------------------------\n");

            string n = sendGet("http://localhost:5000/my/count?a=12&b=18");
            Console.WriteLine(n);

            Console.WriteLine("--------------------------------------\n");
        }
    }
}