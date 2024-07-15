using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models;

public class Tesla : ICar, IElectricCar
{
    public string Model { get ; set; }
    public string Color { get; set; }
    public int Battery { get; set; }
    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }
    public void Start()
    {
        
    }

    public void Stop()
    {
        
    }
    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"{Color} Tesla {Model} with {Battery} batteries");
        sb.AppendLine("Engine start");
        sb.AppendLine("Breaaak!");
        return sb.ToString();
    }
}
