using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    public string Name { get => name; private set => name = value; }
    public IReadOnlyCollection<Person> FirstTeam { get => firstTeam.AsReadOnly();}
    public IReadOnlyCollection<Person> ReserveTeam { get => reserveTeam.AsReadOnly(); }

    public Team(string name)
    {
        Name = name;
        firstTeam = new();
        reserveTeam = new();
    }
    public void AddPlayer(Person person)
    {
        if(person.Age < 40)
            firstTeam.Add(person);
        else reserveTeam.Add(person);
    }
    public override string ToString()
    {
        return $"First team has {FirstTeam.Count} players.{Environment.NewLine}Reserve team has {ReserveTeam.Count} players.";
    }
}
