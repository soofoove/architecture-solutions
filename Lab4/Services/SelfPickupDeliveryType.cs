namespace Lab4.Services
{
    using Lab4.Interfaces;

    public class SelfPickupDeliveryType : IDeliveryType
    {
        public double CalculateCost()
        {
            return new Random().NextDouble();
        }
    }
}
