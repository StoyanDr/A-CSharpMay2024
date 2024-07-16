﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models;

public class Animal
{
    protected Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }
    public string Name { get; set; }
    public string FavouriteFood { get; set; }
    public virtual string ExplainSelf()
    {
        return $"I am {Name} and my favourite food is {FavouriteFood}";
    }
}
