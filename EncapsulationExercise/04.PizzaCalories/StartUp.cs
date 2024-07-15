using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.PizzaCalories;

public class StartUp
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Dough dough = new(input[0], input[1], double.Parse(input[2]));
        Console.WriteLine(dough.Calories);
    }
}
