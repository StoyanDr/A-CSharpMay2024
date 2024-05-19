using System;
using System.Linq;

int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[] columnsSum = new int[dimensions[1]];
int[,] arr = new int[dimensions[0], dimensions[1]];
for(int i = 0; i < arr.GetLength(0); i++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = line[j];
        columnsSum[j] += line[j];
    }
}
foreach(int i in columnsSum) Console.WriteLine(i);