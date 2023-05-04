namespace Lab2.Events;

public class CheckboxEvent : EventBase
{
    public bool Checked { get; }

    public CheckboxEvent(bool @checked) : base()
    {
        Checked = @checked;
    }
}
