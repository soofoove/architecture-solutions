namespace Lab1.Services;

using Lab1.Interfaces;
using Lab1.Models;

public class NavigatorRecommendationIterator : IIterator<Place>
{
    private List<Place> _places;
    private int _position;

    public NavigatorRecommendationIterator(List<Place> places)
    {
        _places = places;
        _position = 0;
    }

    public bool HasNext()
    {
        return _position < _places.Count;
    }

    public Place? Next()
    {
        // implement custom logic
        if (HasNext())
        {
            return _places[_position++];
        }

        return null;
    }
}
