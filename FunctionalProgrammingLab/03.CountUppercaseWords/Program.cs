using System;
using System.Linq;

string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Func<string, bool> isUpperCase = s => s[0] >= 'A' && s[0] <= 'Z';
foreach (string s in input)
{
    if(isUpperCase(s)) Console.WriteLine(s);
}