using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] arr = new int[dimensions[0], dimensions[1]];
int sum = 0;
for(int i =  0; i < dimensions[0]; i++)
{
    int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < dimensions[1]; j++)
    {
        arr[i, j] = line[j];
        sum += arr[i, j];
    }
}
Console.WriteLine(dimensions[0]);
Console.WriteLine(dimensions[1]);
Console.WriteLine(sum);
