using NSC_Car;
using NSC_Car.Interface;
using System.Linq;

do
{
    Console.Clear();

    Console.Write($"Area Size (ex. 10 10): ");
    var areaMapSize = Console.ReadLine();
    var area = areaMapSize?.Split(new char[] { ' ' });
    if (area!=null && !area.All(n => int.TryParse(n.ToString(), out _)))
    {
        Console.Write($"Invalid Area value!");        
        continue;
    }

    Console.Write($"Car Initial Position (ex. 1 1): ");
    var carInitPosition = Console.ReadLine();
    var pos = carInitPosition?.Split(new char[] { ' ' });
    if (pos != null && !pos.All(n => int.TryParse(n.ToString(), out _)))
    {
        Console.Write($"Invalid Initial Position value!");        
        continue;
    }

    Console.Write($"Car Initial Direction (ex. N, E, S, or W): ");
    var carInitDirection = Console.ReadKey();

    Console.WriteLine();
    Console.Write("Car Drive directions (ex. RLF): ");
    var carDirections = Console.ReadLine();

    // Example usage with the provided input
    if (area != null && pos!=null)
    {
        IVehicle car = new Car(int.Parse(area[0]), int.Parse(area[1]), int.Parse(pos[0]), int.Parse(pos[1]), Char.ToUpper(carInitDirection.KeyChar));
        car.Driver.Drive(carDirections?.ToUpper());
        Console.WriteLine();
        Console.WriteLine($"Current Position: {car.GetCurrentLocation()}");
    }

    Console.WriteLine();
    Console.WriteLine("Do you want to do again (Y/N)?");

} while (Console.ReadKey().Key != ConsoleKey.N);
