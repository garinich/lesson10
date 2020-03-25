﻿using System;

namespace CarStorage
{
    public class Car : IVehicle
    {
        private int _price = 0;

        public string Color { get; set; }

        public virtual string CarName => "Car";
        public virtual int GetSpeed()
        {
            return 100;
        }

        public int Price {
            get => _price; 
            set {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Wrong value = {0} !!", value);
                }
            }
        }

        public string Name { get; set; }
        public int ID { get; set; }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);

            return Price - (saleSum / 100.0 * Price);
        }

        protected bool IsColorValid(string color)
        {
            return Enum.TryParse(color, out CarColors result);
        }

        public Car(int id, string name, int price)
        {
            Name = name;
            ID = id;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {ID}, Name: {Name}, Price: {Price}";
        }
    }
}
