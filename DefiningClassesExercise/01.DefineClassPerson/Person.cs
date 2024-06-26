﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }

    public Person()
    {
        Name = "No Name";
        Age = 1;
    }
    public Person(int age)
    {
        Age = age;
        Name = "No name";
    }
    public Person(string name, int age) : this(age)
    {
        Name = name;
    }
}
