using System;

namespace OOPConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car defaultCar = new Car();
            Car customCar = new Car("Toyota", "Corolla", 2022);

            Console.WriteLine($"Default Car: {defaultCar.Make}, {defaultCar.Model}, {defaultCar.Year}");
            Console.WriteLine($"Custom Car: {customCar.Make}, {customCar.Model}, {customCar.Year}");
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
