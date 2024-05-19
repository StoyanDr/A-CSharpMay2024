using System;
using System.Collections.Generic;
using System.Linq;
int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
for(int i = 1; i <= n; i++)
{
    string input = Console.ReadLine();
    int[]arr = input.Split().Select(int.Parse).ToArray();
    switch (arr[0])
    {
        case 1:
            stack.Push(arr[1]);
            break;
        case 2:
            stack.Pop();
            break;
        case 3:
            if (stack.Count == 0) continue;
            else
            {
                int max = int.MinValue;
                foreach (int j in stack) if(j > max) max = j;
                Console.WriteLine(max);
                break;
            }
        case 4:
            if (stack.Count == 0) continue;
            else
            {
                int min = int.MaxValue;
                foreach (int j in stack) if (j < min) min = j;
                Console.WriteLine(min);
                break;
            }
    }
}
Console.WriteLine(string.Join(", ", stack));