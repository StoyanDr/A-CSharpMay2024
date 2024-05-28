using System;
using System.Linq;

int[] boundries = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string condition = Console.ReadLine();

Predicate<int> predicate;
if (condition == "odd") predicate = n => n % 2 != 0;
else predicate = n => n % 2 == 0;

for(int i = boundries[0]; i <= boundries[1]; i++)
{
    if(predicate(i)) Console.Write(i + " ");
}