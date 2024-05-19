using System;
using System.Collections.Generic;

Queue<string> queue = new(Console.ReadLine().Split(", "));
while(queue.Count > 0)
{
    string input = Console.ReadLine();
    if (input.Equals("Play")) queue.Dequeue();
    
    else if(input.Equals("Show")) Console.WriteLine(string.Join(", ", queue));

    else
    {
        input = input.Remove(0, 4);
        if (queue.Contains(input)) Console.WriteLine($"{input} is already contained!");
        else queue.Enqueue(input);
    }

}
Console.WriteLine("No more songs!");