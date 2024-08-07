﻿using System;
using P03.Detail_Printer.Models.Interfaces;

namespace P03.DetailPrinter;

public class Employee : IEmployee
{
    public Employee(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public void GetDetails()
    {
        Console.WriteLine(Name);
    }
}
