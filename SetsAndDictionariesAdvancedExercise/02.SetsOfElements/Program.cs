using System;
using System.Collections.Generic;
using System.Linq;

HashSet<int> firstSet = new();
HashSet<int> secondSet = new();


int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = arr[0];
int m = arr[1];

for(int i  = 0; i < n; i++)
{
    int a = int.Parse(Console.ReadLine());
     firstSet.Add(a);
}
for(int i = 0; i < m; i++)
{
    int a = int.Parse(Console.ReadLine());
    secondSet.Add(a);
}
foreach(int i in firstSet)
{
    if(secondSet.Contains(i)) Console.Write(i + " ");
}