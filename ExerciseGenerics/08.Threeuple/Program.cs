using _08.Threeuple;
using System;


string[] tokens = Console.ReadLine().Split(' ');
Threeuple<string, string, string> name;
if (tokens.Length == 5)
{
     name = new(tokens[0] + " " + tokens[1], tokens[2], tokens[3] + " " + tokens[4]);
}
else name = new(tokens[0] + " " + tokens[1], tokens[2], tokens[3]);

Console.WriteLine(name);
tokens = Console.ReadLine().Split(" ");
bool isDrunk = tokens[2].Equals("drunk");
Threeuple<string, int, bool> beer = new(tokens[0], int.Parse(tokens[1]), isDrunk);
Console.WriteLine(beer);
tokens = Console.ReadLine().Split(" ");
Threeuple<string, double, string> numbers = new(tokens[0], double.Parse(tokens[1]), tokens[2]);
Console.WriteLine(numbers);

