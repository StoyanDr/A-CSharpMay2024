using System;
using System.Collections.Generic;

string input;
Queue<String> queue = new Queue<string>();
while((input = Console.ReadLine()) != "End")
{
    if(input != "Paid")
    {
        queue.Enqueue(input);
    }
    else
    {
        while(queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
Console.WriteLine($"{queue.Count} people remaining.");
