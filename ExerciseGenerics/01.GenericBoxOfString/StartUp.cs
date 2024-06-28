using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list = new();
        for(int i = 0; i < n; i++)
        {
            list.Add(new Box<string>(Console.ReadLine()));
            Console.WriteLine(list[i]);
        }
    }
}
