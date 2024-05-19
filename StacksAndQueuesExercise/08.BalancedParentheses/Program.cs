using System;
using System.Collections.Generic;

Stack<char> stack = new Stack<char>();
string input = Console.ReadLine();
bool isBalanced = true;
foreach (char c in input)
{
    if (input[0] != '(' && input[0] != '{' && input[0] != '[')
    {
        isBalanced = false;
        break;
    }
    if (c == '(' || c == '{' || c == '[') stack.Push(c);
    if(stack.Count == 0)
    {
        isBalanced = false;
        break;
    }

    if(c == ')')
    {
       if(stack.Peek() == '(')
        {
            stack.Pop();
            continue;
        }
       else
        {
            isBalanced = false;
            break;
        }
    }

    if (c == '}')
    {
        if (stack.Peek() == '{')
        {
            stack.Pop();
            continue;
        }
        else
        {
            isBalanced = false;
            break;
        }
    }
    if (c == ']')
    {
        if (stack.Peek() == '[')
        {
            stack.Pop();
            continue;
        }
        else
        {
            isBalanced = false;
            break;
        }
    }
}
Console.WriteLine(isBalanced ? "YES" : "NO");
