using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slightly different notations in C#.
            
            // ---------- When size is provided -------------------------------
            int[] nums = new int[5];        // array of 5 integers
            nums[0] = 12;
            nums[1] = -56;
            nums[2] = 67;
            nums[3] = 109;
            nums[4] = -876;

            // to get size of array, we use Length attribute.
            int n = nums.Length;
            // printing array elements
            for(int i=0; i<n; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine("");

           
            //-------------- When size is not provided but array elements are provided ----------------------
            int[] numbers = new int[] {2, 3, 6, 78, 98, -45, 21, 67};
            Console.WriteLine("Size of numbers array: {0}", numbers.Length);
            Console.Write("Numbers array: ");
            
            // new way to access and print elements in array
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("");

            // ------------- Array of strings -----------------------------
            string[] names = { "Bob", "Charlie", "David", "Harry", "John", "Alex" };
            Console.Write("Students in class: ");
            foreach(string name in names)
            {
                Console.Write("{0} ", name);
            }
            Console.WriteLine("");

            //------------------ String to CharArray and Reversing an Array ---------------------------

            string str = "One can move mountains with determination.";

            char[] chararray = str.ToCharArray();           // method to convert string to its character array
            Array.Reverse(chararray);                       // method to reverse an array

            Console.Write("Reversed character array: ");
            foreach(char c in chararray)
            {
                Console.Write(c);
            }
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}

