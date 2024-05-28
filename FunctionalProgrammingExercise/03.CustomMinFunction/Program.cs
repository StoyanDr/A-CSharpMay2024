using System;
using System.Linq;

int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Func<int[], int> min = arr => arr.Min();

Console.WriteLine(min(arr));