namespace AbaxOpptak;

public class Boat : VehicleWithTopSpeed
{
    private string _loadCapacity;

    public Boat(string name, string characteristics, string effect, int topSpeed, string loadCapacity) 
        : base(name, characteristics, effect, topSpeed, "Knots")
    {

        _loadCapacity = loadCapacity;
    }

    public override void PrintInfo()
    {
        Console.WriteLine();
        base.PrintInfo();
        Console.WriteLine($"Load capacity: {_loadCapacity}");
        Console.WriteLine();
    }
}