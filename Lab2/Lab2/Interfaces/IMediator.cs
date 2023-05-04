namespace Lab2.Interfaces;

using Lab2.Controls;
using Lab2.Events;
using Lab2.Services;

public interface IMediator
{
    void Notify(ControlBase controlBase, EventBase eventBase);
}
