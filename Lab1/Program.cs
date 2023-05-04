using Lab1.Interfaces;
using Lab1.Models;
using Lab1.Services;

namespace Lab1;

public static class Program
{
    public static void Main(string[] args)
    {
        var places = new List<Place>
        {
            new Place { Name = "Kyiv" }, new Place { Name = "Lviv" }, new Place { Name = "Odesa" },
            new Place { Name = "Kharkiv" }, new Place { Name = "Uzhgorod" }
        };
        var placesCollection = new PlacesCollection(places);

        IIterator<Place> ownChoiceIterator = placesCollection.GetByOwnChoiceIterator();
        IIterator<Place> navigatorRecommendationIterator = placesCollection.GetByNavigatorRecommendationIterator();
        IIterator<Place> localGuideIterator = placesCollection.GetByLocalGuideIterator();

        Console.WriteLine("Own choice places:");
        while (ownChoiceIterator.HasNext())
        {
            Console.WriteLine(ownChoiceIterator.Next().Name);
        }

        Console.WriteLine("\nNavigator recommended places:");
        while (navigatorRecommendationIterator.HasNext())
        {
            Console.WriteLine(navigatorRecommendationIterator.Next().Name);
        }

        Console.WriteLine("\nLocal guide places:");
        while (localGuideIterator.HasNext())
        {
            Console.WriteLine(localGuideIterator.Next().Name);
        }
    }
}