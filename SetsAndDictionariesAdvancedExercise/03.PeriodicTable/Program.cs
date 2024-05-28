using System;
using System.Collections.Generic;

SortedSet<string> elements = new();

int n = int.Parse(Console.ReadLine());
string input = string.Empty;

for(int i = 0; i < n; i++)
{
    input = Console.ReadLine();
    string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach(string token in tokens) elements.Add(token);
}
Console.WriteLine(string.Join(' ', elements));