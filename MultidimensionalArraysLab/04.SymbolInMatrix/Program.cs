using System;
using System.Collections.Concurrent;

bool found = false;
int n = int.Parse(Console.ReadLine());
char[,]arr = new char[n,n];
for (int i = 0; i < n; i++)
{
    char[] line = Console.ReadLine().ToCharArray();
    for(int j = 0; j < n; j++)
    {
        arr[i,j] = line[j];
    }
}
string symbol = Console.ReadLine();
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        if (arr[i, j].ToString() == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            found = true;
        }
if(!found) Console.WriteLine($"{symbol} does not occur in the matrix");
