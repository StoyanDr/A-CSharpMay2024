﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant;

public class Product
{
    private string name;
    private decimal price;
    public string Name { get => name; set => name = value; }
    public decimal Price { get => price; set => price = value; }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
