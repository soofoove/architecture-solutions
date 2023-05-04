namespace Lab2.Controls;

using Lab2.Events;
using Lab2.Interfaces;

public class DatepickerControl : ControlBase
{
    public DateTime Date { get; private set; }

    public DatepickerControl(IMediator mediator)
        : base(mediator)
    {
    }

    public void SelectDate(DateTime date)
    {
        Date = date;

        _mediator.Notify(this, new DatepickerEvent(date));
    }
}
