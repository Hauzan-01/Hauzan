using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now Time and printing Dates and Times - short and long way
            DateTime current = DateTime.Now;
            Console.WriteLine(current.ToString());
            Console.WriteLine(current.ToShortDateString());
            Console.WriteLine(current.ToLongDateString());
            Console.WriteLine(current.ToShortTimeString());
            Console.WriteLine(current.ToLongTimeString());

            // Add methods to manipulate datetime
            Console.WriteLine(current.AddDays(3).ToLongDateString());
            Console.WriteLine(current.AddHours(3).ToLongTimeString());
            Console.WriteLine(current.AddDays(-3).ToLongDateString());
            Console.WriteLine(current.AddHours(-3).ToLongTimeString());

            // get month as in integer
            Console.WriteLine(current.Month);

            // new DateTime creation
            DateTime mybirthday = new DateTime(2001, 10, 20);
            Console.WriteLine(mybirthday.ToShortDateString());

            // About TimeSpan
            TimeSpan myage = DateTime.Now.Subtract(mybirthday);
            Console.WriteLine(myage.ToString());
            Console.WriteLine("I am alive for " + myage.TotalDays + " days");

            Console.ReadLine();
        }
    }
}