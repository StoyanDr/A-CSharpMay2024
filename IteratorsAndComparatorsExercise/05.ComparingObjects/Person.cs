using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects;

public class Person : IComparable<Person>
{
    private string name, town;
    private int age;

    public Person(string name, int age, string town)
    {
        this.name = name;
        this.age = age;
        this.town = town;
    }

    public int CompareTo(Person? p)
    {
        if (name.CompareTo(p.name) != 0) return name.CompareTo(p.name);
        if(age.CompareTo(p.age) != 0)  return age.CompareTo(p.age);
        return town.CompareTo(p.town);
    }
}
