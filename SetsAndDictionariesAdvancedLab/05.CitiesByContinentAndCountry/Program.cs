using System;
using System.Collections.Generic;

Dictionary<string, Dictionary<string, List<String>>> cities = new();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string continent = input[0];
    string country = input[1];
    string city = input[2];
    if (!cities.ContainsKey(continent))
        cities.Add(continent, new());
    if (!cities[continent].ContainsKey(country)) cities[continent].Add(country, new());
    cities[continent][country].Add(city);
}
foreach(var (continent, countries) in cities)
{
    Console.WriteLine(continent + ":");
    foreach (var (country, citys) in cities[continent])
    {
        Console.Write("  " + country + " -> ");
        Console.WriteLine(string.Join(", ", citys));
    }
}