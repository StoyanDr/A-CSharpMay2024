using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class Family
{
    private List<Person> family = new();
    private int oldestPerson;

    public void AddMember(Person person)
    {
        if(family.Count == 0)  oldestPerson = 0;
        else if (person.Age > family[oldestPerson].Age) oldestPerson = family.Count;
        family.Add(person);
    }
    public Person GetOldestMember()
    {
        return family[oldestPerson];
    }
}
