class Program
{
    static void Main(string[] args)
    {
        Light livingRoomLight = new Light();
        Fan ceilingFan = new Fan();

        ICommand lightCommand = new LightCommand(livingRoomLight);
        ICommand fanCommand = new FanCommand(ceilingFan);

        RemoteControl remoteControl = new RemoteControl();
        remoteControl.SetCommand(lightCommand);

        remoteControl.PressButton(); // Turns on the light

        remoteControl.SetCommand(fanCommand);
        remoteControl.PressButton(); // Turns on the fan

        //todo: disable
        //todo: Undo
    }
}
