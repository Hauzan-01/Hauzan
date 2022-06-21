using System;
using System.Collections;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book book1 = new Book();
            book1.Title = "Jane Austen";
            book1.Author = "Pride and Prejudice";
            book1.ISBN = "0-000-00000-0";

            // ------------------- ArrayList -----------------------------------------------
            // arraylist can have many elements, even of different types.
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);         // problem for below loop, so we remove it.
            myArrayList.Remove(book1);

            foreach (Car caritem in myArrayList)
            {
                Console.WriteLine(caritem.Make);
            }
            
            // ---------------------- List<T> --------------------------------------------------
            // Generic list -> List<T> , we make it specific by giving T as our needed datatype.
            List<Car> myCarList = new List<Car> ();
            myCarList.Add(car1);
            myCarList.Add(car2);
            // myCarList.Add(book1); - cannot do now.

            foreach (Car caritem in myCarList)
            {
                Console.WriteLine(caritem.Model);
            }

            // -------------------- Dictionary<Tkey, TValue> ---------------------------
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add("N1", car1);
            myDictionary.Add("N2", car2);

            Console.WriteLine(myDictionary["N2"].VIN);

            // Object initializer syntax
            Car car3 = new Car() { Make = "Steele", Model = "Toyota", VIN = "C3" };

            // Collection initializer syntax
            List<Car> carsList = new List<Car>()
            {
                new Car() { Make = "Nothing", Model = "Worse", VIN = "D4"},
                new Car() { Make = "Boring", Model = "MadRunner", VIN = "E5"}
            };

            foreach(Car caritem in carsList)
            {
                Console.WriteLine("{0}, {1}, {2}", caritem.VIN, caritem.Make, caritem.Model);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}

