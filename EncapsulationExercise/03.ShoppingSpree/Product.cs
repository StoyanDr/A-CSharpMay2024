using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree;

public class Product : IEquatable<Product>
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }
    public decimal Price
    {
        get
        {
            return price;
        }
        private set
        {
            if (price < 0) throw new ArgumentException("Money cannot be negative");
            price = value;
        }
    }

    public bool Equals(Product? other)
    {
        return this.Name == other.Name;
    }
}
