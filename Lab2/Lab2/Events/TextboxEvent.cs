namespace Lab2.Events;

public class TextboxEvent : EventBase
{
    public string Text { get; }

    public TextboxEvent(string text)
    {
        Text = text;
    }
}
