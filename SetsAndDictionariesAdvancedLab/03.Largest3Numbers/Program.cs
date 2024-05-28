using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
numbers = numbers.OrderByDescending(n => n).ToList();
for(int i = 0; i < 3; i++)
{
    if (i >= numbers.Count) break;
    Console.Write(numbers[i] + " ");
}
