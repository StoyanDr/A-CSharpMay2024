using System;
using System.Linq;

int[]arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());
Func<int, bool> dividable = x => x % n != 0;
arr = arr.Where(dividable).ToArray();
Console.WriteLine(string.Join(' ', arr.Reverse()));