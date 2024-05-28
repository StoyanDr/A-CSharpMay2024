using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

Dictionary<int, int> numberOfTimes = new();

for(int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if(numberOfTimes.ContainsKey(number)) numberOfTimes[number]++;
    else numberOfTimes.Add(number, 1);
}
foreach(var item in numberOfTimes)
{
    if(item.Value % 2 == 0) Console.WriteLine(item.Key);
}