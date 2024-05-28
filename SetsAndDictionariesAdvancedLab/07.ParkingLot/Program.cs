using System;
using System.Collections.Generic;

HashSet<string> plates = new();
string input = string.Empty;

while((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    switch (tokens[0])
    {
        case "IN":
            plates.Add(tokens[1]);
            break;
        case "OUT":
            plates.Remove(tokens[1]);
            break;
    }
}
if(plates.Count == 0) Console.WriteLine("Parking Lot is Empty");
else foreach (string plate in plates) Console.WriteLine(plate);