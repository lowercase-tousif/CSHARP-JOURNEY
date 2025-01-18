using Polymorphism;

List<object> vehicles = new List<object>();

vehicles.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2021, NumberOfDoors = 4, NumberOfWheels = 4 });
vehicles.Add(new Motorcycle { Brand = "Harley Davidson", Model = "sportster", Year = 2021 });


foreach (var vehicle in vehicles)
{
    if (vehicle is Car)
    {
        var car = (Car)vehicle;
        car.Start();
    }
    else if (vehicle is Motorcycle)
    {
        var motorcycle = (Motorcycle)vehicle;
        motorcycle.Start();
    }
}

Console.WriteLine("--------------------------------------------------");

// Polymorphism

List<Vehicle> vehicles1 = new List<Vehicle>();
vehicles1.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2021, NumberOfDoors = 4, NumberOfWheels = 4 });
vehicles1.Add(new Motorcycle { Brand = "Harley Davidson", Model = "sportster", Year = 2021 });

foreach (var vehicle in vehicles1)
{
    vehicle.Start();
    vehicle.Stop();
}

