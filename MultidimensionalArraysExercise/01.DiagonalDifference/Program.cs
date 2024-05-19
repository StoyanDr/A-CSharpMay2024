using System;
using System.Linq;

int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int sum1 = 0;
int sum2 = 0;

for(int i = 0; i < n; i++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = line[j];
        if(i == j) sum1 += matrix[i, j];
        if(i + j == matrix.GetLength(0) - 1) sum2 += matrix[i, j];
    }
}
Console.WriteLine(Math.Abs(sum1 - sum2));
