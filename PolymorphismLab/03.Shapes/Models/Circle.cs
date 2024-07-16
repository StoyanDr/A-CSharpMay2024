using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models;

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius 
    { get => radius;
        set
        {
            if (value <= 0) throw new ArgumentException("Invalid radius");
            radius = value;
        } 
    }
    public override double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }

    public override double CalculatePerimeter()
    {
        return Radius * 2 * Math.PI;
    }
}
