using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Console.WriteLine("Now we will input user name and city.");
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            // we have also used some function overloading concept.
            Display(reverseString(firstname), reverseString(lastname), reverseString(city));
            Console.WriteLine();
            Display(reverseString(firstname) + " " + reverseString(lastname) + " " + reverseString(city));

            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        private static string reverseString(string s)
        {
            string ans = "";
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            foreach (char c in chars)
            {
                ans += c;
            }
            return ans;
        }

        private static void Display(string a, string b, string c)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", a, b, c));
        }

        private static void Display(string a)
        {
            Console.Write("Results: ");
            Console.WriteLine(a);
        }
    }
}

