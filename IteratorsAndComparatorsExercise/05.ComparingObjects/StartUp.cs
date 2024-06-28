using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects;

public class StartUp
{
    static void Main()
    {
        List<Person> list = new();
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] arr = input.Split();
            string name = arr[0];
            int age = int.Parse(arr[1]);
            string town = arr[2];
            Person pp = new(name, age, town);
            list.Add(pp);
        }
        int n = int.Parse(Console.ReadLine());
        int matches = 0;
        Person p = list[n - 1];
        for(int i = 0; i < list.Count; i++)
        {
            if (p.CompareTo(list[i]) == 0) matches++;
        }
        if(matches == 1) Console.WriteLine("No matches");
        else Console.WriteLine($"{matches} {list.Count - matches} {list.Count}");
    }
}
