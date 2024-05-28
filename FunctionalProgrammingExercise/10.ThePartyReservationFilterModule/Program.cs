using System;
using System.Collections.Generic;
using System.Linq;

List<string> names = Console.ReadLine().Split().ToList();
List<string> filters = new();

string input = string.Empty;

while((input = Console.ReadLine()) != "Print")
{
    //Add filter; Starts with; P

    //Add filter; Starts with; M
    string[] tokens = input.Split(';');
    string command = tokens[0];
    string operation = tokens[1];
    string value = tokens[2];
    string name = operation + ";" + value;
    

    if (command == "Add filter")
    {
        filters.Add(name);
        /*filters[name] = (names) =>
        {
            return
            operation == "Starts with" ? names.Where(x => !x.StartsWith(value)).ToList()
            : operation == "Ends with" ? names.Where(x => !x.EndsWith(value)).ToList()
            : operation == "Length" ? names.Where(x => !(x.Length == int.Parse(value))).ToList()
            : names.Where(x => !x.Contains(value)).ToList();
        };*/
    }
    else
    {
        filters.Remove(name);
    }
}
foreach(string str in filters)
{
    string[] tokens = str.Split(";");
    string operation = tokens[0];
    string value = tokens[1];
    Func<List<string>, string, string, List<string>> filter = (names, operation, value) =>
    {
        return
            operation == "Starts with" ? names.Where(x => !x.StartsWith(value)).ToList()
            : operation == "Ends with" ? names.Where(x => !x.EndsWith(value)).ToList()
            : operation == "Length" ? names.Where(x => !(x.Length == int.Parse(value))).ToList()
            : names.Where(x => !x.Contains(value)).ToList();
    };
    names = filter(names, operation, value);
}
Console.WriteLine(string.Join(' ', names));