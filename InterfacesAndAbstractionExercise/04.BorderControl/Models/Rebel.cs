using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models;

public class Rebel : IBuyer
{
    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Food = 0;
        Group = group;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
    public int Food { get; set; }

    public void BuyFood()
    {
        Food += 5;
    }
}
