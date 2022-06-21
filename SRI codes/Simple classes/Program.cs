using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake c = new Cake();
            c.name = "Choco-moco";
            c.flavor = "Chocolate";
            c.price = 34.50F;
            c.weight = 3;

            Console.WriteLine("Cake properties: ");
            Console.WriteLine(c.name);
            Console.WriteLine(c.flavor);
            Console.WriteLine(c.price);
            Console.WriteLine(c.weight);

            Console.WriteLine("Final price: ${0}", c.getPrice());
            Console.ReadLine();
        }
    }

    class Cake
    {
        public string name { get; set; }
        public string flavor { get; set; }
        public float price { get; set; }
        public float weight { get; set; }

        public float getPrice()
        {
            if (weight > 2.5)
                return price + 50;
            else
                return price; 
        } 
    }
}

