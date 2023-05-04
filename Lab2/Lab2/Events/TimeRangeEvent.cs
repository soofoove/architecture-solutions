namespace Lab2.Events;

using Lab2.Models;

public class TimeRangeEvent : EventBase
{
    public TimeRange SelectedTimeRange { get; }

    public TimeRangeEvent(TimeRange timeRange)
    {
        SelectedTimeRange = timeRange;
    }
}
