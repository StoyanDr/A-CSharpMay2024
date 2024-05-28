using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Channels;

List<Person> people = ReadPeople();

// false - younger
// true - older
string condition = Console.ReadLine();
int threshhold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();
Func<Person, bool> filter = CreateFilter(condition, threshhold);
Action<Person> printer = CreatePrinter(format);
PrintFilteredPeople(people, filter, printer);
static List<Person> ReadPeople()
{
    int n = int.Parse(Console.ReadLine());
    List<Person> people = new List<Person>();
    for(int i = 0; i < n; i++)
    {
        string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        Person p = new(tokens[0], int.Parse(tokens[1]));
        people.Add(p);
    }
    return people;
}
static Func<Person, bool> CreateFilter(string condition, int threshhold)
{
    Func<Person, bool> filter;
    if (condition == "older")
    {
        filter = p => p.Age >= threshhold;
    }
    else filter = p => p.Age < threshhold;
    return filter;
}
static Action<Person> CreatePrinter(string format)
{
    Action<Person> printer;
    if (format == "name age")
    {
        printer = p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if(format == "age") printer = p => Console.WriteLine($"{p.Age}");
    else printer = p => Console.WriteLine($"{p.Name}");
    return printer;
}
static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
{
    people = people.Where(filter).ToList();
    foreach (Person person in people)
    {
        printer(person);
    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        this.Age = age;
    }
}


