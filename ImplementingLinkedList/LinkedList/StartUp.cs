using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList;

public class StartUp
{
    static void Main()
    {
        LinkedList<int> list = new(1);
        list.AddLast(3);
        list.AddFirst(4);
        list.RemoveLast();
        list.RemoveFirst();
        int[]arr = list.ToArray();
        Console.WriteLine(string.Join(" ", arr));
    }
    
    
    
    
}
