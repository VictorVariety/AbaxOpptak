namespace AbaxOpptak;

public class Car : VehicleWithTopSpeed
{
    private string _type;
    private string _color;

    public Car(string name, string regNr, string effect, int topSpeed, string type, string color)
        : base(name, regNr, effect, topSpeed, "Km/t")
    {
        _type = type;
        _color = color;
    }

    public override void PrintInfo()
    {
        Console.WriteLine();
        base.PrintInfo();
        Console.WriteLine($"Type: {_type}\n" +
                          $"Color: {_color}");
        Console.WriteLine();
    }
}