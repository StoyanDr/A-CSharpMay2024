using System;
using System.Collections.Generic;

HashSet<string> regulars = new();
HashSet<string> VIPs = new();

string input = string.Empty;

while((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0])) VIPs.Add(input);
    else regulars.Add(input);
}
while((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
        VIPs.Remove(input);
    }
    else regulars.Remove(input);
}
Console.WriteLine(regulars.Count + VIPs.Count);
foreach(string s in VIPs) Console.WriteLine(s);
foreach (string s in regulars) Console.WriteLine(s);