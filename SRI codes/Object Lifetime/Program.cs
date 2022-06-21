using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car myCar = new Car();

            myCar.Make = "BuildKill";
            myCar.Model = "BM67Ferrari";
            myCar.year = 1997;
            myCar.color = "blue";

            Console.WriteLine("My car details : {0}, {1}, {2}, {3}.", myCar.Make, myCar.Model, myCar.year, myCar.color);

            Car newCar = myCar;     // both objects reference to same location. and have same data.
            // if one is manipulated, other is manipulated as well.

            Console.WriteLine("After assigning: {0}, {1}, {2}, {3}.", newCar.Make, newCar.Model, newCar.year, newCar.color);

            newCar.color = "red";
            Console.WriteLine("After making changes: {0}, {1}, {2}, {3}.", myCar.Make, myCar.Model, myCar.year, myCar.color);

            newCar = null;          // null deleted references of objects to its class.
            //Console.WriteLine("After assigning: {0}, {1}, {2}, {3}.", newCar.Make, newCar.Model, newCar.year, newCar.color);
            */

            // Learning about constructors
            Car myCar = new Car();
            Console.WriteLine("Car details: {0}, {1}, {2}, {3}.", myCar.Make, myCar.Model, myCar.year, myCar.color);

            Car car2 = new Car("Flight", "BulletSky", 2002, "Purple");
            car2.Print();

            // calling static methods in a class without objects/instances creation
            Car.myStaticMethod();

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public string color { get; set; }

        public Car()
        {
            Console.WriteLine("Default constructor called.");
            this.Make = "NONE";
            this.Model = "NONE";
            this.year = 0;
            this.color = "NONE";
        }

        public Car(string make, string model, int year, string color)
        {
            Console.WriteLine("Parametrized construcotr called.");
            Make = make;
            Model = model;
            this.year = year;
            this.color = color;
        }

        public void Print()
        {
            Console.WriteLine("Car Details: {0}, {1}, {2}, {3}.", Make, Model, year, color);
        }

        // a static method
        public static void myStaticMethod()
        {
            Console.WriteLine("This is the myStaticMethod.");
        }
    }
}