namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                    continue;
                }
                int a;
                if (input[i] == ')')
                {
                    a = i;
                    int b = stack.Pop();
                    Console.WriteLine(input.Substring(b, a - b + 1));
                }
            }
        }
    }
}
