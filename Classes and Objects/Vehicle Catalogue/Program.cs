string input = Console.ReadLine(); //{type}/{brand}/{model}/{horse power / weight}
Catalog catalog = new Catalog();

while (input != "end")
{
    string[] vehicleData = input.Split("/");
    string type = vehicleData[0];
    string brand = vehicleData[1];
    string model = vehicleData[2];
    int horsePowerOrWeight = int.Parse(vehicleData[3]);

    if (type == "Car")
    {
        Car currentCar = new Car()
        {
            Brand = brand,
            Model = model,
            HorsePower = horsePowerOrWeight
        };
        catalog.Cars.Add(currentCar);
    }
    else if (type == "Truck")
    {
        Truck currentTruck = new Truck()
        {
            Brand = brand,
            Model = model,
            Weight = horsePowerOrWeight
        };
        catalog.Trucks.Add(currentTruck);
    }
    input = Console.ReadLine();
}


if (catalog.Cars.Count > 0)
{
    List<Car> orderedCars = catalog.Cars
    .OrderBy(car => car.Brand)
    .ToList();

    Console.WriteLine($"Cars:");

    foreach (Car car in orderedCars)
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

if (catalog.Trucks.Count > 0)
{
    List<Truck> orderedTrucks = catalog.Trucks
    .OrderBy(truck => truck.Brand)
    .ToList();

    Console.WriteLine($"Trucks:");
    foreach (Truck truck in orderedTrucks)
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }


}

public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
public class Catalog
{
    public List<Car> Cars { get; set; } = new();
    public List<Truck> Trucks { get; set; } = new();
}
