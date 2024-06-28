using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack;

public class StartUp
{
    static void Main()
    {
        CustomStack<int> stack = new();
        string input = string.Empty;
        while((input = Console.ReadLine()) != "END")
        {
            if (input.Contains("Push"))
            {
                input = input.Remove(0, 5);
                string[] arr = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arr.Length; i++)
                {
                    stack.Push(int.Parse(arr[i]));
                }
            }
            else try
                {
                    stack.Pop();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
        foreach(int i in stack)
        {
            Console.WriteLine(i);
        }
        foreach (int i in stack)
        {
            Console.WriteLine(i);
        }
    }
}
