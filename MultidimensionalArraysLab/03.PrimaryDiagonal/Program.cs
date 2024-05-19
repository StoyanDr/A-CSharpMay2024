using System;
using System.ComponentModel;
using System.Linq;
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[n,n];
int sumPrimaryDiagonal = 0;

for(int i = 0; i < n; i++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for(int j = 0; j < n; j++)
    {
        arr[i, j] = line[j];
        if(i == j) sumPrimaryDiagonal += arr[i,j];
    }

}
Console.WriteLine(sumPrimaryDiagonal);