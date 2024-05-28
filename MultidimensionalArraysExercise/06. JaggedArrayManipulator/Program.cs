using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());
int[][] jagged = new int[rows][];
for(int i = 0; i < rows; i++)
{
    jagged[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}
if(jagged.Length > 1)
{
    for (int i = 0; i < jagged.Length - 1; i++)
    {
        if (jagged[i].Length == jagged[i + 1].Length)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] *= 2;
                jagged[i + 1][j] *= 2;
            }
        }
        else
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] /= 2;
            }
            for (int j = 0; j < jagged[i + 1].Length; j++)
            {
                jagged[i + 1][j] /= 2;
            }
        }
    }
}
string input = string.Empty;
while((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split(' ');
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    if (row >= jagged.Length || row < 0) continue;
    if(col >= jagged[row].Length || col < 0) continue;
    switch(tokens[0])
    {
        case "Add":
            jagged[row][col] += int.Parse(tokens[3]);
            break;
        case "Subtract":
            jagged[row][col] -= int.Parse(tokens[3]);
            break;
    }
}
foreach (int[]arr in jagged)
{
    Console.WriteLine(string.Join(' ', arr));
}