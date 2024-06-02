using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class Car
{
    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;
    private Engine _engine;
    private Tire[] _tires;

    public string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value;
        }
    }
    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }
    public double FuelQuantity
    {
        get
        {
            return fuelQuantity;
        }
        set
        {
            fuelQuantity = value;
        }
    }
    public double FuelConsumption
    {
        get
        {
            return fuelConsumption;
        }
        set
        {
            fuelConsumption = value;
        }
    }
    public Engine Engine
    {
        get
        {
            return _engine;
        }
        set
        {
            _engine = value;
        }
    }
    public Tire[] Tires
    {
        get
        {
            return _tires;
        }
        set
        {
            _tires = value;
        }
    }

    public Car()
    {
        make = "VW";
        model = "Golf";
        year = 2025;
        fuelQuantity = 200;
        fuelConsumption = 10;
    }
    public Car(string make, string model, int year) : this()
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        : this(make, model, year, fuelQuantity, fuelConsumption)
    {
        this.Engine = engine;
        this.Tires = tires;
    }

    public void Drive(double distance)
    {
        double neededFuel = distance / 100 * fuelConsumption;
        if (neededFuel > fuelQuantity)
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
        FuelQuantity -= neededFuel;
    }
    public string WhoAmI()
    {
        string s = "";
        s = $"Make: {this.Make}{Environment.NewLine}";
        s += $"Model: {this.Model}{Environment.NewLine}";
        s += $"Year: {this.Year}{Environment.NewLine}";
        s += $"Fuel: {this.FuelQuantity:F2}{Environment.NewLine}";
        return s;
    }
    public double SumOfPressure()
    {
        double sum = 0;
        foreach (Tire tire in Tires)
        {
            sum += tire.Pressure;
        }
        return sum;
    }
    public override string ToString()
    {
        string s = $"Make: {Make}{Environment.NewLine}";
        s += $"Model: {Model}{Environment.NewLine}";
        s += $"Year: {Year}{Environment.NewLine}";
        s += $"HorsePowers: {Engine.HorsePower}{Environment.NewLine}";
        s += $"FuelQuantity: {FuelQuantity}";
        return s;
    }

}
