using System;
using System.Collections.Generic;

namespace CarStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<IVehicle>
            {
                new Van(
                    new Insurance(DateTime.Now, DateTime.Now, "Test"), 
                    600, 
                    500, 
                    "myVan",
                    123,
                    1000
                ),
                new Minivan(6, "myMinivan", 456, 5000),
                new Car(789, "myCar", 200),
                new Bicycle(),
                new Motorbike()
            };

            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName);
                Console.WriteLine($"Speed: {car.GetSpeed()}");
                Console.WriteLine($"Sale: {car.GetSale()}");
            }
        }
    }
}