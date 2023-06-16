namespace AbaxOpptak;

public class VehicleWithTopSpeed : Vehicle
{
    protected int TopSpeed;
    protected string SpeedUnit;

    public VehicleWithTopSpeed(string name, string characteristics, string effect, int topSpeed, string speedUnit) 
        : base(name, characteristics, effect)
    {
        TopSpeed = topSpeed;
        SpeedUnit = speedUnit;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Top speed: {TopSpeed} {SpeedUnit}");
    }

}