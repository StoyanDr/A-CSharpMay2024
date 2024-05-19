using System;
using System.Collections.Generic;
using System.Linq;
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
Queue<int> queue = new (list);
for(int i = 0; i < input[1]; i++) queue.Dequeue();
if(queue.Count == 0) Console.WriteLine(0);
else if (queue.Contains(input[2])) Console.WriteLine("true");
else
{
    int min = int.MaxValue;
    foreach(int i in queue)
    {
        if(i < min) min = i;
    }
    Console.WriteLine(min);
}