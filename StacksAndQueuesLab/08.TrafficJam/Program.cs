using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
string input = default;
Queue<string> queue = new();
int numberOfPassedCars = 0;
while((input = Console.ReadLine()) != "end")
{
    if(input != "green")
    {
        queue.Enqueue(input);
    }
    else
    {
        for(int i = 1; i <= n; i++)
        {
            if (queue.Count == 0) break;
            Console.WriteLine($"{queue.Dequeue()} passed!");
            numberOfPassedCars++;
        }
    }
}
Console.WriteLine($"{numberOfPassedCars} cars passed the crossroads.");
