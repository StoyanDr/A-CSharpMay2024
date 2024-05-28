using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    decimal grade = decimal.Parse(input[1]);
    if (grades.ContainsKey(input[0])) grades[input[0]].Add(grade);
    else
    {
        grades.Add(input[0], new List<decimal>());
        grades[input[0]].Add(grade);
    }
}
foreach(var (name, grade) in grades)
{
    string gradesStr = string.Join(" ",grade.Select(g => g.ToString("f2")));
    string aver = $"(avg: {grade.Average():F2})";
    Console.WriteLine($"{name} -> {gradesStr} {aver}");
}

