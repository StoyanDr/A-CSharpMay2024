﻿using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models;

public class Robot : IIdentifiable
{
    public Robot(string id, string model)
    {
        Id = id;
        Model = model;
    }
    public string Id { get; set; }
    public string Model { get ; set ; }

}
