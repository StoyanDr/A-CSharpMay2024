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
        int n = int.Parse(Console.ReadLine());

        List<Person> p = new();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            Person pp = new(input[0], int.Parse(input[1]));
            if (pp.Age > 30) p.Add(pp);
        }
        p = p.OrderBy(p => p.Name).ToList();

        foreach (Person person in p) Console.WriteLine(person);
    }
}
