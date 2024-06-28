using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Froggy;

public class StartUp
{
    static void Main()
    {
        string input = Console.ReadLine();
        Lake lake  = new(input);
        Console.WriteLine(string.Join(", ", lake));

    }
}
