namespace Lab4.Services
{
    using Lab4.Interfaces;

    public class OwnDeliveryType : IDeliveryType
    {
        public double CalculateCost()
        {
            return new Random().NextDouble();
        }
    }
}
