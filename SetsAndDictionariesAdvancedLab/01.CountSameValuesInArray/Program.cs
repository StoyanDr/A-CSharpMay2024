using System;
using System.Linq;
using System.Collections.Generic;

double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
Dictionary<double, int> dictionary = new();
foreach(double i in arr)
{
    if (dictionary.ContainsKey(i)) dictionary[i]++;
    else dictionary.Add(i, 1);
}
foreach(var item in dictionary)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}
