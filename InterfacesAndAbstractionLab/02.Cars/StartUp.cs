﻿using Cars.Models;
using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars;

public class StartUp
{
    static void Main()
    {
        ICar seat = new Seat("Leon", "Grey");
        ICar tesla = new Tesla("3", "Red", 2);
        Console.WriteLine(seat);
        Console.WriteLine(tesla);
    }
}
