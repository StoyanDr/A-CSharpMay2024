using System;
using System.Linq;

int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];
for(int i = 0; i < rows; i++)
{
    string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for(int j = 0; j < cols; j++)
    {
        matrix[i, j] = line[j];
    }
}
string input = string.Empty;

while((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if(tokens.Length != 5 || tokens[0] != "swap")
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    int row1 = int.Parse(tokens[1]), col1 = int.Parse(tokens[2]);
    int row2 = int.Parse(tokens[3]), col2 = int.Parse(tokens[4]);
    if (row1 >= matrix.GetLength(0) || row2 >= matrix.GetLength(0))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    if (col1 >= matrix.GetLength(1) || col2 >= matrix.GetLength(1))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    string temp = matrix[row1, col1];
    matrix[row1, col1] = matrix[row2, col2];
    matrix[row2, col2] = temp;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}