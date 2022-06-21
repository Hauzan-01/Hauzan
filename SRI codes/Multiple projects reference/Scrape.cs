using System;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebPage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://google.com");
            reply += " THAT'S ALL FOLKS....!!!";
            return reply;
        }
    }
}