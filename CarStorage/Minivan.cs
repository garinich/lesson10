using System;

namespace CarStorage
{
    public class Minivan : Car
    {
        private int maxNumberOfSeats = 10;
        private int numberOfSeats = 4;
        
        public override string CarName => "Minivan";
        
        public override int GetSpeed()
        {
            return 50;
        }
        
        public int NumberOfSeats
        {
            get => numberOfSeats;
            set
            {
                if (value < 0 || value > maxNumberOfSeats)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }

        public Minivan(int numberOfSeats, string name, int id, int price) : base(id, name, price)
        {
            NumberOfSeats = numberOfSeats;
        }
        
        public override string ToString()
        {
            return base.ToString() + $", Number Of Seats: {NumberOfSeats}";
        }
    }
}