using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters;

public class Hero
{
    private string username;
    private int level;
    public string Username { get => username; set => username = value; }
    public int Level { get => level; set => level = value; }
    public Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }
    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
    }
}
