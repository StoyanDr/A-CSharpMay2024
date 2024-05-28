using System;
using System.Collections.Generic;
using System.Linq;

Func<string, int> parser = s => int.Parse(s);

List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).ToList();
Console.WriteLine(numbers.Count);
Console.WriteLine(numbers.Sum());