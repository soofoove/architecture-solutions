namespace Lab2.Services;

using Lab2.Controls;
using Lab2.Events;
using Lab2.Interfaces;
using Lab2.Models;

public class FlowerOrderPage : IMediator
{
    private readonly DatepickerControl _orderDate;
    private readonly TimeRangeControl _orderTimeRange;
    private readonly CheckboxControl _otherRecipient;
    private readonly TextboxControl _recipientName;
    private readonly TextboxControl _recipientPhone;
    private readonly CheckboxControl _orderSelfPick;

    public FlowerOrderPage()
    {
        _orderDate = new DatepickerControl(this);
        _orderTimeRange = new TimeRangeControl(this);
        _otherRecipient = new CheckboxControl(this);
        _recipientName = new TextboxControl(this);
        _recipientPhone = new TextboxControl(this);
        _orderSelfPick = new CheckboxControl(this);
    }
    public void Notify(ControlBase sender, EventBase eventBase)
    {
        if (sender == _orderDate) OnOrderDateSelected(sender as DatepickerControl, eventBase as DatepickerEvent);
        else if (sender == _otherRecipient) OnOtherRecipientChecked(sender as CheckboxControl, eventBase as CheckboxEvent);
        else if (sender == _orderSelfPick) OnOrderSelfPickChecked(sender as CheckboxControl, eventBase as CheckboxEvent);
    }

    private void OnOrderDateSelected(DatepickerControl sender, DatepickerEvent @event)
    {
        // calculate new order time ranges
        _orderTimeRange.TimeRanges = new List<TimeRange>
            { new TimeRange { TimeFrom = DateTime.Now, TimeTo = DateTime.Now.AddHours(2) } };
    }

    private void OnOtherRecipientChecked(CheckboxControl sender, CheckboxEvent @event)
    {
        if (sender.Checked)
        {
            _recipientName.IsVisible = true;
            _recipientName.IsRequired = true;

            _recipientPhone.IsVisible = true;
            _recipientPhone.IsRequired = true;
        }
    }

    private void OnOrderSelfPickChecked(CheckboxControl sender, CheckboxEvent @event)
    {
        if (sender.Checked)
        {
            _orderDate.IsActive = false;
            _orderTimeRange.IsActive = false;
            _otherRecipient.IsActive = false;
            _recipientName.IsActive = false;
            _recipientPhone.IsActive = false;
        }
    }
}
