using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models;

public class Seat : ICar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
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
        sb.AppendLine($"{Color} Seat {Model}");
        sb.AppendLine("Engine start");
        sb.AppendLine("Breaaak!");
        return sb.ToString();
    }
}
