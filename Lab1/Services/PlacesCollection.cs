namespace Lab1.Services;

using Lab1.Interfaces;
using Lab1.Models;

public class PlacesCollection
{
    private List<Place> _places;

    public PlacesCollection(List<Place> places)
    {
        _places = places;
    }

    public IIterator<Place> GetByOwnChoiceIterator()
    {
        return new OwnChoiceIterator(_places);
    }

    public IIterator<Place> GetByNavigatorRecommendationIterator()
    {
        return new NavigatorRecommendationIterator(_places);
    }

    public IIterator<Place> GetByLocalGuideIterator()
    {
        return new LocalGuideIterator(_places);
    }
}
