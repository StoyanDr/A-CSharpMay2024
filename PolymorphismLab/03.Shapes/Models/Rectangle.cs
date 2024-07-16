using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models;

public class Rectangle : Shape
{
    private double width;
    private double height;
    public Rectangle(double width, double height)
    {
        Width = width; 
        Height = height;
    }
    public double Width
    {
        get => width;
        set
        {
            if (value <= 0) throw new ArgumentException("Invalid width");
            width = value;
        }
    }
    public double Height
    {
        get => height;
        set
        {
            if (value <= 0) throw new ArgumentException("Invalid width");
            height = value;
        }
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 *(Width + Height);
    }
}
