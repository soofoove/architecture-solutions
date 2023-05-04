namespace Lab4.Services
{
    using System;
    using Lab4.Interfaces;

    internal class OtherVendorDeliveryType : IDeliveryType
    {
        public double CalculateCost()
        {
            return new Random().NextDouble();
        }
    }
}
