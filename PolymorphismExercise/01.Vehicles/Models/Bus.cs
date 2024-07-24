using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models;

public class Bus : Vehicle
{
    public Bus(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
    {
    }
    public override void Drive(double kilometers)
    {
        double neededFuel = kilometers * (FuelConsumption);
        if (neededFuel > Fuel)
        {
            Console.WriteLine("Bus needs refueling");
            return;
        }
        Fuel -= neededFuel;
        Console.WriteLine($"Bus travelled {kilometers} km");
    }
    public void DriveFull(double kilometers)
    {
        double neededFuel = kilometers * (1.4 + FuelConsumption);
        if (neededFuel > Fuel)
        {
            Console.WriteLine("Bus needs refueling");
            return;
        }
        Fuel -= neededFuel;
        Console.WriteLine($"Bus travelled {kilometers} km");
    }
}
