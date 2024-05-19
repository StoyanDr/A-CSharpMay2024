using System;
using System.Collections.Generic;
using System.Text;

int n = int.Parse(Console.ReadLine());
Stack<string> states = new Stack<string>();
states.Push("");
string current = string.Empty;
for(int i = 0; i < n; i++)
{
    string[]command = Console.ReadLine().Split();
    switch (command[0])
    {
        case "1": 
            current += command[1];
            break;
        case "2":
            int count = int.Parse(command[1]);
            //abcde
            current = current.Substring(0, current.Length - count);
            break;
        case "3":
            int index = int.Parse(command[1]) - 1;
            Console.WriteLine(current[index]);
            break;
        case "4":
            states.Pop();
            current = states.Peek();
            break;
    }
    if (command[0] != "3" && command[0] != "4")
        states.Push(current);
}