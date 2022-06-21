using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string text =
            "A class is the most powerful data type in C#. Like a structure, " +
            "a class defines the data and behavior of the data type. ";

            File.WriteAllText("WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://google.com");
            File.WriteAllText("WriteText.txt", reply);
            Console.WriteLine(reply);

            Console.ReadLine();
        }
    }
}
