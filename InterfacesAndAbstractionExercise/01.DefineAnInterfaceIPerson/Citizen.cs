using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo;

public class Citizen : IPerson, IBirthable, IIdentifiable
{
    private string name;
    private int age;
    private string birthdate;
    private string id;

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Birthdate = birthdate;
        Id = id;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid name");
            name = value;
        }
    }
    public int Age
    {
        get => age;
        set
        {
            if (value < 0) throw new ArgumentException("Invalid age");
            age = value;
        }
    }

    public string Birthdate { get => birthdate; set => birthdate = value; }
    public string Id { get => id; set => id = value; }
}
