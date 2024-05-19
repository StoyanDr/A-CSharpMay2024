using System;
using System.Linq;

int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = dimensions[0];
int columns = dimensions[1];
int[,] matrix = new int[rows, columns];
for(int i = 0; i < rows; i++)
{
    int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = line[j];
    }
}
int[] coordinates = new int[2];
int biggestSum = int.MinValue;
for(int i = 0; i <  matrix.GetLength(0) - 2; i++)
{
    for(int j = 0; j < matrix.GetLength(1) - 2; j++)
    {
        int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
            matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;
            coordinates[0] = i;
            coordinates[1] = j;
        }
    }
}
Console.WriteLine($"Sum = {biggestSum}");
for(int i = coordinates[0]; i < coordinates[0] + 3; i++)
{
    for(int j = coordinates[1]; j < coordinates[1] + 3; j++)
    {
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}