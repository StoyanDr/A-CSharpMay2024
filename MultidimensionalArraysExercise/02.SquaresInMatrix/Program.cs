using System;
using System.Linq;

int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = dimensions[0];
int columns = dimensions[1];
char[,] matrix = new char[rows, columns];
for(int i = 0; i < rows; i++)
{
    string[] line = Console.ReadLine().Split();
    for(int j = 0; j < columns; j++)
    {
        matrix[i,j] = line[j][0];
    }
}
int squares = 0;
for(int i = 0; i < rows - 1; i++)
{
    for(int j = 0; j < columns - 1; j++)
    {
        if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1]) squares++;
    }
}
Console.WriteLine(squares);