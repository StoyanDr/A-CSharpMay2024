using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomDataStructures;

internal class StartUp
{
    static void Main()
    {
        CustomStack<int> stack = new();
        Console.WriteLine(stack.Pop());
    }
}
