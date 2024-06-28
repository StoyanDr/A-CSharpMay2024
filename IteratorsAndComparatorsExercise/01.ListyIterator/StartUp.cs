using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator;

public class StartUp
{
    static void Main()
    {
        ListyIterator<string> list = new(new List<string>());
        string input = Console.ReadLine();
        List<string> arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        arr.RemoveAt(0);
        list = new(arr);
        while ((input = Console.ReadLine()) != "END")
        {
            switch(input)
            {
                case "Move":
                    Console.WriteLine(list.MoveNext());
                    break;
                case "Print":
                    try
                    {
                        list.Print();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;
                case "HasNext":
                    Console.WriteLine(list.HasNext());
                    break;
                case "PrintAll":
                    list.PrintAll();
                    break;
            }
        }
    }
}
