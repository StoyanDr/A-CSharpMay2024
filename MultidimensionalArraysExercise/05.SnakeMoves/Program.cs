using System;
using System.Linq;

int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
string word = Console.ReadLine();
char[,] matrix = new char[rows, cols];
int count = 0;
for(int i = 0; i <  rows; i++)
{
    if(i % 2 == 0){
        for (int j = 0; j < cols; j++)
        {
            count++;
            int desiredChar = count % word.Length;
            if (desiredChar == 0) matrix[i, j] = word[word.Length - 1];
            else matrix[i, j] = word[desiredChar - 1];
        }
    }
    else
    {
        for (int j = 0; j < cols; j++)
        {
            count++;
            int desiredChar = count % word.Length;
            if (desiredChar == 0) matrix[i, cols - j - 1] = word[word.Length - 1];
            else matrix[i, cols - j - 1] = word[desiredChar - 1];
        }
    }
}
for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}