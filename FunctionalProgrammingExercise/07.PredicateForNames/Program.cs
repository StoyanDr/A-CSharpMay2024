using System;

int n = int.Parse(Console.ReadLine());
string[]arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Predicate<string> length = x => x.Length <= n;
foreach (string str in arr)
    if(length(str)) Console.WriteLine(str);