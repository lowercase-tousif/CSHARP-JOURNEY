using Inheritance;

var car = new Car();

car.Brand = "Toyota";
car.Model = "Corolla";
car.Year = 2021;
car.NumberOfDoors = 4;
car.NumberOfWheels = 4;

car.Start();
car.Stop();

var bike = new Bike();

bike.Brand = "Giant";
bike.Model = "Defy";
bike.Year = 2021;
bike.NumberOfWheels = 2;

bike.Start();
bike.Stop();