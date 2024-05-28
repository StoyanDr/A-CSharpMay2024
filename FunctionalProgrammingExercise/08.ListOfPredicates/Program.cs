using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());

List<int> numbers = Enumerable.Range(1, n).ToList();
int[] dividers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Func<int, int[], bool> func = (number, dividers) => dividers.All(x => number % x == 0);
numbers = numbers.Where(number => func(number, dividers)).ToList();
Console.WriteLine(string.Join(' ', numbers));