using System;
using System.Collections.Generic;
using System.Linq;

List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

Func<List<string>, string, string, List<string>> filter = (listOfNames, operation, value) =>
{
    return operation == "StartsWith"
    ? listOfNames.Where(x => x.StartsWith(value)).ToList()
    : operation == "Length" ? listOfNames.Where(x => x.Length == int.Parse(value)).ToList()
    : listOfNames.Where(x => x.EndsWith(value)).ToList();
};

string input = string.Empty;

while((input = Console.ReadLine()) != "Party!")
{
    //Remove StartsWith P
    //Double Length 5
    string[] command = input.Split();
    string operation = command[0];
    string condition = command[1];
    string value = command[2];
    if (operation == "Remove")
    {
        List<string> removals = filter(names,condition, value);
        foreach(string removal in removals)
        {
            names.Remove(removal);
        }
    }
    else
    {
        List<string> doubles = filter(names,condition, value);
        foreach(string d in doubles)
        {
            int index = names.IndexOf(d);
            names.Insert(index, d);
        }
    }
}
if(names.Count == 0) Console.WriteLine("Nobody is going to the party!");
else Console.WriteLine(string.Join(", ", names) + " are going to the party!");
