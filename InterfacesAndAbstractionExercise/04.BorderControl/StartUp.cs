using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string,IBuyer> list = new();
        string input = string.Empty;
        for(int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            string[] tokens = input.Split();
            if (tokens.Length == 4)
            {
                IBuyer citizen = new Citizen(tokens[2], tokens[0], int.Parse(tokens[1]), tokens[3]);
                list[tokens[0]] = citizen;
            }
            else
            {
                IBuyer rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                list[tokens[0]] = rebel;
            }
        }
        input = string.Empty;
        while((input = Console.ReadLine()) != "End")
        {
            if(list.ContainsKey(input))
            {
                list[input].BuyFood();
            }
        }
        int sum = 0;
        foreach(var item in list)
        {
            sum += item.Value.Food;
        }
        Console.WriteLine(sum);
    }
}
