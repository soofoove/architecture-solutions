namespace Lab2.Events;

public class DatepickerEvent : EventBase
{
    public DateTime Date { get; }

    public DatepickerEvent(DateTime date) : base()
    {
        Date = date;
    }
}
