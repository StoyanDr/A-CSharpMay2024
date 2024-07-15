using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree;

public class Person : IEquatable<Person>
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        bagOfProducts = new();
    }
    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }
    public decimal Money
    {
        get
        {
            return money;
        }
        private set
        {
            if (value < 0) throw new ArgumentException("Money cannot be negative");
            money = value;
        }
    }
    public IReadOnlyCollection<Product> BagOfProducts
    {
        get
        {
            return bagOfProducts.AsReadOnly();
        }
    }
    public void AddProduct(Product product)
    {
        if (product.Price > Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
            return;
        }
        bagOfProducts.Add(product);
        money -= product.Price;
        Console.WriteLine($"{Name} bought {product.Name}");
    }

    public bool Equals(Person? other)
    {
        return this.Name == other.Name;
    }
    public override string ToString()
    {
        string s = $"{Name} - ";
        if(bagOfProducts.Count == 0)
        {
            s += "Nothing bought";
            return s;
        }
        foreach(Product product in bagOfProducts)
        {
            s += $"{product.Name}, ";
        }
        s = s.Substring(0, s.Length - 2);
        return s;
    }
}
