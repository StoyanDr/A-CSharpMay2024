using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> stack = new(Console.ReadLine().Split().Select(int.Parse));
int capacity = int.Parse(Console.ReadLine());
int clothes = 0;
int neededRacks = 0;

while(stack.Count > 0)
{
    int piece = stack.Peek();
    if(piece + clothes == capacity)
    {
        stack.Pop();
        neededRacks++;
        clothes = 0;
    }
    else if(piece + clothes > capacity) 
    {
        neededRacks++;
        clothes -= clothes;
        clothes += piece;
        stack.Pop();
    }
    else
    {
        clothes += piece;
        stack.Pop();
    }
}
if(clothes != 0) neededRacks++;
Console.WriteLine(neededRacks);