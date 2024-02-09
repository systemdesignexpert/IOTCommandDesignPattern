using System.Collections.Generic;

public class LightCommand : ICommand
{
    private Light _light;

    public LightCommand(Light light)
    {
        _light = light;
    }

    public void Enable()
    {
        _light.LightsOn();
    }

    public void Disable()
    {
        _light.LightsOff();
    }
}
