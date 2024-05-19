using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> queue = new();
string[] input = Console.ReadLine().Split();
foreach (string s in input)
{
    queue.Enqueue(s);
}
int n = int.Parse(Console.ReadLine());
while(queue.Count != 1)
{
    for(int i = 0; i < n - 1; i++)
    {
        string last = queue.Dequeue();
        queue.Enqueue(last);
    }
    Console.WriteLine($"Removed {queue.Dequeue()}");
}
Console.WriteLine($"Last is {queue.Dequeue()}");