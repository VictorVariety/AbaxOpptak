using System.Drawing;

namespace AbaxOpptak;

public class Vehicle
{
    protected string Name;
    protected string Characteristics;
    protected string Effect;

    public Vehicle(string name, string characteristics, string effect)
    {
        Name = name;
        Characteristics = characteristics;
        Effect = effect;
    }

    public void Drive()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name} is driving");
        Console.WriteLine();
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}\n" +
                          $"Reg.nr: {Characteristics}\n" +
                          $"Effect: {Effect}");
    }
}