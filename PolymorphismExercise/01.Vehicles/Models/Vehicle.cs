using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models;

public abstract class Vehicle
{
    private double fuel;
    private double fuelConsumption;
    private double tankCapacity;
    protected Vehicle(double fuel, double fuelConsumption, double tankCapacity)
    {
        TankCapacity = tankCapacity;
        Fuel = fuel;
        FuelConsumption = fuelConsumption;
    }
    public virtual double Fuel
    {
        get => fuel;
        set
        {
            if (value < 0) throw new ArgumentException("Invalid fuel!");
            if (value > tankCapacity)
            {
                fuel = 0;
            }
            else fuel = value;
        }
    }
    public virtual double FuelConsumption
    {
        get => fuelConsumption;
        set
        {
            if (value < 0) throw new ArgumentException("Invalid fuel consumption!");
            fuelConsumption = value;
        }
    }
    public virtual double TankCapacity
    {
        get => tankCapacity;
        set
        {
            if (value < 0) throw new ArgumentException("Invalid capacity");
            tankCapacity = value;
        }
    }
    public abstract void Drive(double kilometers);
    public virtual void Refuel(double liters)
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
        Fuel += liters;
    }
}
