namespace CarStorage
{
    public interface IVehicle
    {
        string CarName { get; }

        public int GetSpeed();

        public double GetSale();
    }
}