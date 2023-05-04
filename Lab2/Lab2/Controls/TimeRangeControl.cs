namespace Lab2.Controls;

using Lab2.Events;
using Lab2.Interfaces;
using Lab2.Models;

public class TimeRangeControl : ControlBase
{
    public List<TimeRange> TimeRanges { get; set; } = new();
    public TimeRange SelectedTimeRange { get; private set; }

    public TimeRangeControl(IMediator mediator)
        : base(mediator)
    {
    }

    public void SelectTimeRange(TimeRange timeRange)
    {
        SelectedTimeRange = timeRange;

        _mediator.Notify(this, new TimeRangeEvent(timeRange));
    }
}
