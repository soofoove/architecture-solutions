namespace Lab2.Controls;

using Lab2.Interfaces;

public abstract class ControlBase
{
    protected readonly IMediator _mediator;

    public bool IsActive { get; set; }
    public bool IsVisible { get; set; }
    public bool IsRequired { get; set; }

    protected ControlBase(IMediator mediator)
    {
        _mediator = mediator;
    }
}
