namespace CarStorage
{
    public class Motorbike : IVehicle
    {
        public string CarName => "Motorbike!";
        public int GetSpeed()
        {
            return 85;
        }

        public double GetSale()
        {
            return 33.3;
        }
    }
}