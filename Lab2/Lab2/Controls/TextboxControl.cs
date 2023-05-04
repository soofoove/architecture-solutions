namespace Lab2.Controls;

using Lab2.Interfaces;

public class TextboxControl : ControlBase
{
    public string Text { get; private set; }

    public TextboxControl(IMediator mediator)
        : base(mediator)
    {
    }

    public void ChangeText(string text)
    {
        Text = text;


    }
}
