using System;
using System.Linq;
int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] arr = new int[dimensions[0], dimensions[1]];
for (int i = 0; i < dimensions[0]; i++)
{
    int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < dimensions[1]; j++)
    {
        arr[i, j] = line[j];
    }
}
int sum = 0;
int[] index = new int[2];
for(int i = 0; i < dimensions[0] - 1; i++)
{
    for (int j = 0; j < dimensions[1] - 1; j++)
    {
        int currentSum = arr[i, j] + arr[i + 1, j] + arr[i + 1, j + 1] + arr[i, j + 1];
        if (currentSum > sum)
        {
            sum = currentSum;
            index[0] = i;
            index[1] = j;
        }
    }
}
for (int i = index[0]; i <= +index[0] + 1; i++)
{
    for(int j = index[1]; j <= index[1] + 1; j++)
    {
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(sum);