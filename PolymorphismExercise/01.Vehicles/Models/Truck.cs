using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models;

public class Truck : Vehicle
{
    public Truck(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
    {
    }
    public override void Drive(double kilometers)
    {
        double neededFuel = kilometers * (FuelConsumption + 1.6);
        if (neededFuel > Fuel)
        {
            Console.WriteLine("Truck needs refueling");
            return;
        }
        Fuel -= neededFuel;
        Console.WriteLine($"Truck travelled {kilometers} km");
    }
    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }
        if (liters + Fuel > TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            return;
        }
        Fuel += liters * 0.95;
    }
}
