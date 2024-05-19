using System;
using System.Linq;
using System.Collections.Generic;
int food = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
int max = int.MinValue;
foreach(int i  in queue) if(i > max) max = i;
Console.WriteLine(max);
while (true)
{
    if (queue.Count == 0) break;
    int order = queue.Peek();
    if (order <= food)
    {
        food -= order;
        queue.Dequeue();
    }
    else break;
}
if (queue.Count == 0) Console.WriteLine("Orders complete");
else
{
    Console.WriteLine("Orders left: " + string.Join(" ", queue));
}