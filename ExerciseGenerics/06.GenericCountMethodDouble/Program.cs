using _01.GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
List<Box<double>> list = new();
for (int i = 0; i < n; i++)
{
    list.Add(new Box<double>(double.Parse(Console.ReadLine())));
}
Box<double> value = new Box<double>(double.Parse(Console.ReadLine()));
int count = Compare(list, value);
Console.WriteLine(count);

static void Swap<T>(List<T> list, int index1, int index2)
{
    T temp = list[index1];
    list[index1] = list[index2];
    list[index2] = temp;
}
static int Compare(List<Box<double>> list, Box<double> value)
{
    int count = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (value.CompareTo(list[i]) < 0)
            count++;
    }
    return count;
}