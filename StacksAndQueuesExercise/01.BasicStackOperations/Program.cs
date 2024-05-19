using System;
using System.Collections.Generic;
using System.Linq;
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
Stack<int> stack = new(arr);
for(int i = 0; i < input[1]; i++)
{
    stack.Pop();
}
if (stack.Count == 0) Console.WriteLine(0);
else if (stack.Contains(input[2])) Console.WriteLine("true");
else
{
    arr = new(stack);
    int min = int.MaxValue;
    for(int i = 0; i < arr.Count; i++) if (arr[i] < min) min = arr[i];
    Console.WriteLine(min);
}

