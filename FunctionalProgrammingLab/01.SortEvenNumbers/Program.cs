using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

numbers = numbers.Where(x => x % 2 == 0).ToList();
Console.WriteLine(string.Join(", ",numbers.OrderBy(n => n)));