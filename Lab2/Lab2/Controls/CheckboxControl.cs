namespace Lab2.Services;

using Lab2.Controls;
using Lab2.Events;
using Lab2.Interfaces;

public class CheckboxControl : ControlBase
{
    public bool Checked { get; private set; }

    public CheckboxControl(IMediator mediator)
        : base(mediator)
    {
    }

    public void Check(bool @checked)
    {
        Checked = @checked;

        _mediator.Notify(this, new CheckboxEvent(@checked));
    }
}
