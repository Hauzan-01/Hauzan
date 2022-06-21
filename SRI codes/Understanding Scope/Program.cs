using System;

namespace UnderstandingScope
{
    class Program
    {
        private static int k;
        static void Main(string[] args)
        {
            int j = 0;
            for(int i=0; i<25; i++)
            {
                j = i;
                k = i;
                //Console.WriteLine(i);
            }

            //Console.WriteLine(i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("k = " + k);

            helperMethod();

            // using class scope, 
            Car myCar = new Car();
            myCar.Introduce();

            Console.ReadLine();
        }

        private static void helperMethod()
        {
            Console.WriteLine("k = " + k);
        }
    }

    class Car
    {
        public void Introduce()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello, world!";
        }
    }
}