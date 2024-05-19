using System.ComponentModel.DataAnnotations;

namespace _03._SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            int result = int.Parse(stack.Pop().ToString());
            while (stack.TryPop(out string a))
            {
                if (a == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else result -= int.Parse(stack.Pop());

            }
            Console.WriteLine(result);
        }
    }
}
