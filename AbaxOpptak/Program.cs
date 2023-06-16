using AbaxOpptak;

var cars = new[]
{
    new Car("car 1", "NF123456", "147kw", 200, "light vehicle", "green"),
    new Car("car 2", "NF654321", "150kw", 195, "light vehicle", "blue")
};

var airplane = new Airplane("Jet plane", "LN1234", "1000kw", "30m", "2000kg", "10000kg", "Jet plane");

var boat = new Boat("Boat", "ABC123", "100kw", 30, "500kg");

foreach (var car in cars)
{
    car.PrintInfo();
}

Console.WriteLine(cars[0] == cars[1] ? "These cars are the same car" : $"These cars are not the same car.");

airplane.PrintInfo();
airplane.Drive();
cars[0].Drive();
boat.PrintInfo();

