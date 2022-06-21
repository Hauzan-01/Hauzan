using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // Constructors

        public Book()
        {
            Console.WriteLine("A book is created.");
        }

        public Book(string Title, string Author, int Pages)
        {
            Console.WriteLine("A book is created.");
            this.title = Title; 
            this.author = Author;   
            this.pages = Pages;
        }
    }
}
