using System;
using System.Collections.Generic;

string input = Console.ReadLine();

SortedDictionary<char, int> chars = new();

foreach (char c in input)
{
    if(chars.ContainsKey(c)) chars[c]++;
    else chars.Add(c, 1);
}

foreach(var (ch, n) in chars)
{
    Console.WriteLine($"{ch}: {n} time/s");
}