using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed;

public class Vehicle
{
    public Vehicle(int horsePower, double fuel)
    {
        Fuel = fuel;
        HorsePower = horsePower;
    }
    private const double DefaultFuelConsumption = 1.25;
    public virtual double FuelConsumption => DefaultFuelConsumption;
    public double Fuel { get; private set; }
    public int HorsePower { get; set; }
    public virtual void Drive(double kilometers)
    {
        Fuel -= kilometers * FuelConsumption;
    }
}
