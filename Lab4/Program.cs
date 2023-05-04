namespace Lab4;

using Lab4.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        var selfPickupDeliveryType = new SelfPickupDeliveryType();
        var ownDeliveryType = new OwnDeliveryType();
        var otherVendorDeliveryType = new OtherVendorDeliveryType();

        var foodDelivery = new FoodDelivery(selfPickupDeliveryType);
        Console.WriteLine($"Self Pickup Cost: {foodDelivery.CalculateCost()}");

        foodDelivery.SetStrategy(ownDeliveryType);
        Console.WriteLine($"Own Delivery Cost: {foodDelivery.CalculateCost()}");

        foodDelivery.SetStrategy(otherVendorDeliveryType);
        Console.WriteLine($"Other Delivery Cost: {foodDelivery.CalculateCost()}");
    }
}
