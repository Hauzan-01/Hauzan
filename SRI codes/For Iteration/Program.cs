using System;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // just like regularly known 'for' loop

            Console.WriteLine("Table of 26:");
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine("26 x {0} = {1}", k, 26*k);
            }

            Console.WriteLine("Adding numbers from 1 to 25 using a for loop:");
            int sum = 0;
            for(int k = 1; k<26; k++)
            {
                sum += k;
            }
            Console.WriteLine("The answer is: {0}", sum);

            Console.ReadLine();
        }
    }
}
