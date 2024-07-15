using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person;

public class Person
{
    private string name;
    private int age;
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public override string ToString()
    {
        return $"{GetType().Name} -> Name: {Name}, Age: {Age}";
    }
}
