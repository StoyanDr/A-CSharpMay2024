using System;
using System.Linq;
using System.Collections.Generic;

double[]arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s) * 1.2).ToArray();
foreach(double d in arr)
{
    Console.WriteLine($"{d:f2}");
}