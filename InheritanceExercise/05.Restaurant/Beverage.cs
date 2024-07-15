using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant;

public class Beverage : Product
{
    private double mililiters;
    public double Mililiters { get => mililiters; set => mililiters = value; }
    public Beverage(string name, decimal price, double mililiters) : base(name, price)
    {
        Mililiters = mililiters;
    }
}
