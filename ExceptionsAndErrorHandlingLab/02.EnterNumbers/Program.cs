int startRange = 1;
int endRange = 100;
List<int> list = new();
while(list.Count < 10)
{
    try
    {
        int number = ReadNumber(startRange, endRange);
        list.Add(number);
        startRange = number;
    }catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine(string.Join(", ", list));

int ReadNumber(int start, int end)
{
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int number))
    {
        throw new ArgumentException("Invalid Number!");
    }
    if (number <= start || number >= end) throw new ArgumentException($"Your number is not in range {start} - {end}!");
    return number;
}