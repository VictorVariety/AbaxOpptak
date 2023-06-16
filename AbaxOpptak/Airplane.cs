using System.Drawing;

namespace AbaxOpptak;

public class Airplane : Vehicle
{
    private string _wingspan;
    private string _loadCapacity;
    private string _weight;
    private string _type;

    public Airplane(string name, string characteristics, string effect, string wingspan, string loadCapacity, string weight, string type) 
        : base(name, characteristics, effect)
    {
        _wingspan = wingspan;
        _loadCapacity = loadCapacity;
        _weight = weight;
        _type = type;
    }

    public override void PrintInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {Name}\n" +
                          $"Reg.nr: {Characteristics}\n" +
                          $"Effect: {Effect}\n" +
                          $"Wingspan: {_wingspan}\n" +
                          $"Load capacity: {_loadCapacity}\n" +
                          $"Weight {_weight}\n" + 
                          $"Type: {_type}");
        Console.WriteLine();
    }
}