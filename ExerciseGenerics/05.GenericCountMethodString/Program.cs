using _01.GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
List<Box<string>> list = new();
for (int i = 0; i < n; i++)
{
    list.Add(new Box<string>(Console.ReadLine()));
}
Box<string> value = new Box<string>(Console.ReadLine());
int count = Compare(list, value);
Console.WriteLine(count);

static void Swap<T>(List<T> list, int index1, int index2)
{
    T temp = list[index1];
    list[index1] = list[index2];
    list[index2] = temp;
}
static int Compare(List<Box<string>> list, Box<string> value)
{
    int count = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (value.CompareTo(list[i]) < 0)
            count++;
    }
    return count;
}