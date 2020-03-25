using System;

namespace CarStorage
{
    public class Bicycle : IVehicle
    {
        public string CarName => "Bicycle!";
        
        public virtual int GetSpeed()
        {
            return 10;
        }
        
        public double GetSale()
        {
            return 10.0;
        }
    }
}