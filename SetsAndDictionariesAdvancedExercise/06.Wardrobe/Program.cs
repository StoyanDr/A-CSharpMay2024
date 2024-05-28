using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> colorClothes = new();
string[]arr = new string[2];
arr[0] = " -> ";
arr[1] = ",";

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(arr, StringSplitOptions.RemoveEmptyEntries);
    string color = input[0];
    if(colorClothes.ContainsKey(color))
    {
        for(int j = 1; j < input.Length; j++)
        {
            if (colorClothes[color].ContainsKey(input[j]))
            {
                colorClothes[color][input[j]]++;
            }
            else colorClothes[color].Add(input[j], 1);
        }
    }
    else
    {
        colorClothes.Add(color, new());
        for (int j = 1; j < input.Length; j++)
        {
            if (colorClothes[color].ContainsKey(input[j]))
            {
                colorClothes[color][input[j]]++;
            }
            else colorClothes[color].Add(input[j], 1);
        }
    }
}
string[] searched = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach((string color, Dictionary<string, int> clothes) in colorClothes)
{
    Console.WriteLine(color + " clothes:");
    foreach((string piece, int times) in clothes)
    {
        string line = $"* {piece} - {times}";
        if (color == searched[0] && piece == searched[1]) line += " (found!)";
        Console.WriteLine(line);
    }
}