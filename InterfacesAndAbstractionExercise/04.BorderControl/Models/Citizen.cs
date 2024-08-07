﻿using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models;

public class Citizen : IIdentifiable, IBirthdayable, IBuyer
{
    public Citizen(string id, string name, int age, string birthDate)
    {
        Id = id;
        Name = name;
        Age = age;
        BirthDate = birthDate;
        Food = 0;
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age {  get; set; }
    public string BirthDate { get; set; }
    public int Food { get; set; }

    public void BuyFood()
    {
        Food += 10;
    }
}
