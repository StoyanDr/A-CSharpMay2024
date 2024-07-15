using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant;

public class Coffee : HotBeverage
{
    public Coffee(string name, decimal price, double mililiters) : base(name, price, mililiters)
    {
        Price = CoffeePrice;
        Mililiters = CoffeeMililiters;
    }

    private const double CoffeeMililiters = 50;
    private const decimal CoffeePrice = 3.50m;
    public double Caffeine { get; set; }
}
