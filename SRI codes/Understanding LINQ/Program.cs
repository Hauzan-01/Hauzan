using System;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 1998},
                new Car() { VIN = "B1", Make = "Toyota", Model = "360i", StickerPrice = 75000, Year = 2001},
                new Car() { VIN = "C1", Make = "BMW", Model = "451h", StickerPrice = 35000, Year = 2000},
                new Car() { VIN = "D1", Make = "BMW", Model = "590e", StickerPrice = 65000, Year = 2004},
                new Car() { VIN = "E1", Make = "Toyota", Model = "429n", StickerPrice = 70000, Year = 2006},
            };

            // ----------- selecting cars by make and year by condition - Where()
            // Linq query
            var bmws = from car in myCars where car.Make == "BMW" select car; // {FROM, WHERE, SELECT}

            Console.WriteLine("By Linq query:");
            foreach(var item in bmws)
            {
                Console.WriteLine("{0}, {1}, {2}", item.VIN, item.Make, item.Model);
            }

            Console.WriteLine("By Linq method:");
            // Linq method
            var BMWs = myCars.Where(p => p.Make == "BMW" && p.Year == 2004);
            foreach(var item in BMWs)
            {
                Console.WriteLine("{0}, {1}, {2}", item.VIN, item.Make, item.Model);
            }

            // ------------ OrderBy()

            Console.WriteLine("Orderby year using Linq query:");
            var orderedCars = from car in myCars orderby car.Year descending select car;
            foreach(var car in orderedCars)
            {
                Console.WriteLine("{0}, {1}", car.Year, car.Make);
            }

            Console.WriteLine("Orderby year using Linq method:");
            orderedCars = myCars.OrderByDescending(p => p.Year);
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0}, {1}", car.Year, car.Make);
            }

            // ---------------- TrueForAll()
            Console.Write("Does every car's year is less than 2015?: ");
            Console.WriteLine(myCars.TrueForAll(p => p.Year < 2015));

            // ------ printing all cars data from the container myCars - using ForEach()
            Console.WriteLine("Printing all Elements using ForEach method.");
            myCars.ForEach(p => Console.WriteLine("{0}, {1}, {2}", p.Make, p.Model, p.StickerPrice));

            // --------- Exists()
            Console.Write("Does any car have model SkyRocket? ");
            Console.WriteLine(myCars.Exists(p => p.Model == "SkyRocket"));

            // ----------- Sum()
            Console.WriteLine("Sum of prices: {0}", myCars.Sum(p => p.StickerPrice));

            // ----------- Min()
            Console.WriteLine("Minimum year: {0}", myCars.Min(p => p.Year));

            // ----------- Max()
            Console.WriteLine("Maximum year: {0}", myCars.Max(p => p.Year));

            // ------------ GetType()
            Console.WriteLine(myCars.GetType());
            Console.WriteLine(orderedCars.GetType());



            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
