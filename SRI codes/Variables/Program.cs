// See https://aka.ms/new-console-template for more information
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This is our first program to learn variables in C#.");
            int x = 5;
            int y = x + 7;
            Console.WriteLine(y);
            

            string firstname, lastname;
            Console.WriteLine("Let's see what your name is.");
            Console.Write("Enter your first name: ");
            firstname = Console.ReadLine();             // for scanning values
            Console.Write("Enter your last name: ");
            lastname = Console.ReadLine();

            Console.WriteLine("Hi, your name is " + firstname + " " + lastname + ".");
            Console.ReadLine();
        }
    }
}

