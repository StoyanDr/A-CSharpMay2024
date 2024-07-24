using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace Vehicles;

public class StartUp
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Car car = new(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

        input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Truck truck = new(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

        input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Bus bus = new(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "Refuel")
            {
                if (input[1] == "Car") car.Refuel(double.Parse(input[2]));
                else if (input[1] == "Truck") truck.Refuel(double.Parse(input[2]));
                else bus.Refuel(double.Parse(input[2]));
            }
            else if (input[0] == "Drive")
            {
                if (input[1] == "Car") car.Drive(double.Parse(input[2]));
                else if(input[1] == "Truck") truck.Drive(double.Parse(input[2]));
                else bus.DriveFull(double.Parse(input[2]));
            }
            else bus.Drive(double.Parse(input[2]));
        }
        Console.WriteLine($"Car: {car.Fuel:F2}");
        Console.WriteLine($"Truck: {truck.Fuel:F2}");
        Console.WriteLine($"Bus: {bus.Fuel:F2}");
    }
}
