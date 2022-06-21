using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            myString = "This is 'really' boring.";
            Console.WriteLine(myString);

            myString = "This is \"really\" boring.";        // note how '\' is used to use other characters for printing.
            Console.WriteLine(myString);

            myString = "This is a line which will be added\non a new line.";
            Console.WriteLine(myString);

            myString = String.Format("{0} + {1} = {2}", "four", "five", "nine");
            Console.WriteLine(myString);

            myString = String.Format("{1} + {0} = {2}", "four", "five", "nine");
            Console.WriteLine(myString);

            myString = String.Format("I currently have {0:C}.", 23.50);     // we use :C after {} for currency
            Console.WriteLine(myString);

            myString = String.Format("Number : {0:N}", 23456788323);        // :N for representing a number
            Console.WriteLine(myString);

            myString = String.Format("Percentage : {0:P}", 0.23);           // :P for representing a percentage
            Console.WriteLine(myString);

            myString = String.Format("Phone Number : {0:(###) ###-####}", 2344567412); // # sequence for representing a phone number format
            Console.WriteLine(myString);

            myString = String.Format("Phone Number : {0:(###) ###-####}", 23445674126674);   
            Console.WriteLine(myString);

            // Some built-ins
            myString = "  The tears in my eyes glisten, and carefully, if you listen.  ";
            string temp = myString.Substring(7, 12);       // just like substr(idx, count) in C++
            Console.WriteLine(temp);

            temp = myString.Replace(' ', '#');       // replace all old characters by new ones. 
            Console.WriteLine(temp);

            temp = myString.Remove(7, 12);          // just like parameters of Substring. remove elements from index, to count.
            Console.WriteLine(temp);

            temp = myString.ToUpper();                 // convert characters to upper case
            Console.WriteLine(temp);

            temp = myString.ToLower();                 // convert characters to lower case
            Console.WriteLine(temp);

            // Trim() method removes extra spaces
            temp = myString.Trim();
            Console.WriteLine(temp);           
            Console.WriteLine("Before trimming, length = {0}, After trimming, length = {1}.", myString.Length, temp.Length);

            // string concatenation takes huge processing.
            myString = "";
            for(int i=0; i<100; i++)
            {
                myString += "--" + i.ToString();
            }
            Console.WriteLine(myString);
            
            // to deal with above, use StringBuilder and its Append method
            StringBuilder myStr = new StringBuilder();
            for(int i=0; i<100; i++)
            {
                myStr.Append("--");
                myStr.Append(i);
            }
            Console.WriteLine(myStr.ToString());

            Console.ReadLine();
        }
    }
}
