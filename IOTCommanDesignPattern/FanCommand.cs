public class FanCommand : ICommand
{
    private Fan _fan;

    public FanCommand(Fan fan)
    {
        _fan = fan;
    }

    public void Enable()
    {
        _fan.TurnOn();
    }

    public void Disable()
    {
        _fan.TurnOff();
    }
}
