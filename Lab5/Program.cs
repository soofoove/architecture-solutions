namespace Lab5;

using Lab5.Handlers;
using Lab5.Models;

public static class Program
{
    public static void Main(string[] args)
    {
        var productRequest = new Product
        {
            Id = 1,
            Title = "SomeProduct",
            Price = 100500
        };
        var userRequest = new User
        {
            Id = 2,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@mail.com"
        };
        var orderRequest = new Order
        {
            Id = 3,
            Quantity = 1234
        };

        var productHandler = new ProductHandler();
        var userHandler = new UserHandler();
        var orderHandler = new OrderHandler();

        ClientAPI.Process(productHandler, productRequest);
        ClientAPI.Process(userHandler, userRequest);
        ClientAPI.Process(orderHandler, orderRequest);
    }
}

