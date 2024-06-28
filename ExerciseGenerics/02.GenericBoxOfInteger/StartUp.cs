using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString;

public class StartUp
{
    static void Swap<T>(List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<int>> list = new();
        for(int i = 0; i < n; i++)
        {
            list.Add(new Box<int>(int.Parse(Console.ReadLine())));
            Console.WriteLine(list[i]);
        }
    }
}
