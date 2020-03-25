using System;

namespace CarStorage
{
    public class Van : Car
    {
        private int mileage = 0;
        private int maxCarrying = 5000;
        private int carrying = 100;
        
        public override string CarName => "Van";
        
        public override int GetSpeed()
        {
            return 70;
        }
        
        public Insurance Insurance { get; set; }
        
        public int Carrying 
        {
            get => carrying;
            set
            {
                if (value < 0 || value > maxCarrying)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    carrying = value;
                }
            }
        }

        public int Mileage
        {
            get => mileage;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    mileage = value;
                }
            }
        }
        
        public Van(Insurance insurance, int carrying, int mileage, string name, int id, int price) : base(id, name, price)
        {
            Insurance = insurance;
            Carrying = carrying;
            Mileage = mileage;
        }
        
        /*public override string ToString()
        {
            return base.ToString() + $", Number Of Seats: {NumberOfSeats}";
        }*/
    }
}