namespace _02._StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();
            foreach (int i in list)
            {
                stack.Push(i);
            }
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] arr = input.Split();
                switch (arr[0])
                {
                    case "add":
                        int a = int.Parse(arr[1]);
                        int b = int.Parse(arr[2]);
                        stack.Push(a);
                        stack.Push(b);
                        break;
                    case "remove":
                        if (int.Parse(arr[1]) > stack.Count) break;
                        for (int i = int.Parse(arr[1]); i > 0; i--) stack.Pop();
                        break;
                }
            }
            int sum = 0;
            foreach (int i in stack)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
