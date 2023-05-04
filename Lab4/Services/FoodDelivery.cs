namespace Lab4.Services
{
    using Lab4.Interfaces;

    public class FoodDelivery
    {
        private IDeliveryType _type;

        public FoodDelivery(IDeliveryType type)
        {
            _type = type;
        }


        public void SetStrategy(IDeliveryType type)
        {
            _type = type;
        }

        public double CalculateCost()
        {
            return _type.CalculateCost();
        }
    }
}
