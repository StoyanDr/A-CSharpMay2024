using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        Family f = new();
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            Person person = new(input[0], int.Parse(input[1]));
            f.AddMember(person);
        }
        Console.WriteLine(f.GetOldestMember());
    }
}
