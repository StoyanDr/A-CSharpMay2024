using System;
using System.Linq;
int rows = int.Parse(Console.ReadLine());
int[][] arr = new int[rows][];
for(int i = 0; i < rows; i++)
{
    arr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}
string input = string.Empty;
while((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split();
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int val = int.Parse(tokens[3]);
    switch (tokens[0])
    {
        case "Add":
            if (arr.Length <= row)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            if (row < 0)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            if (arr[row].Length <= col)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            if (col < 0)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            arr[row][col] += val;
            break;
        case "Subtract":
            if (arr.Length <= row)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            if (row < 0)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            if (arr[row].Length <= col)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            if (col < 0)
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }
            arr[row][col] -= val;
            break;
    }
}
foreach (int[] a in arr) Console.WriteLine(string.Join(" ", a));