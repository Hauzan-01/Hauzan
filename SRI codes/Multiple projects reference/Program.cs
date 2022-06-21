using System;
using ScrapeLibrary;

namespace myClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebPage("http://www.google.com");
            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}