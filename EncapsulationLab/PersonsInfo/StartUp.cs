using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> list = new();
        for(int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            Person p = new(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3]));
            list.Add(p);
        }
        decimal percentage = decimal.Parse(Console.ReadLine());
        foreach(Person p in list)
        {
            p.IncreaseSalary(percentage);
            Console.WriteLine(p);
        }
    }
}
