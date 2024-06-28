using _07.Tuple;
using System;

string[] tokens = Console.ReadLine().Split(' ');
CustomTuple<string, string> name = new(tokens[0] + " " +  tokens[1], tokens[2]);
Console.WriteLine(name);
tokens = Console.ReadLine().Split(" ");
CustomTuple<string, int> beer = new(tokens[0], int.Parse(tokens[1]));
Console.WriteLine(beer);
tokens = Console.ReadLine().Split(" ");
CustomTuple<int, double> numbers = new(int.Parse(tokens[0]), double.Parse(tokens[1]));
Console.WriteLine(numbers);
