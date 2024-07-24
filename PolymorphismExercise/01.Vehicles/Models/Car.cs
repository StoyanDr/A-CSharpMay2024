using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models;

public class Car : Vehicle
{
    public Car(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
    {
    }
    public override void Drive(double kilometers)
    {
        double neededFuel = kilometers * (0.9 + FuelConsumption);
        if (neededFuel > Fuel)
        {
            Console.WriteLine("Car needs refueling");
            return;
        }
        Fuel -= neededFuel;
        Console.WriteLine($"Car travelled {kilometers} km");
    }
}
