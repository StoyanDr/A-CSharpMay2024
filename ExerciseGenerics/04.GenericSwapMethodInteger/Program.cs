using _01.GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
List<Box<int>> list = new();
for(int i = 0; i < n; i++)
{
    list.Add(new Box<int>(int.Parse(Console.ReadLine())));
}
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Swap(list, arr[0], arr[1]);
foreach(Box<int> box in list)
{
    Console.WriteLine(box);
}

static void Swap<T>(List<T> list, int index1, int index2)
{
    T temp = list[index1];
    list[index1] = list[index2];
    list[index2] = temp;
}