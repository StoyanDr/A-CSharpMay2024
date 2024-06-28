
int n = int.Parse(Console.ReadLine());
char[,] arr = new char[n,n];
for(int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < n; j++)
        arr[i, j] = line[j];
}
int[] bee = new int[2];
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
        if(arr[i,j] == 'B')
        {
            bee[0] = i;
            bee[1] = j;
            break;
        }
}
int energy = 15;
int nectar = 0;
bool hiveReached = false;
bool increased = false;
while(energy >= 0 && !hiveReached)
{
    string command = Console.ReadLine();
    if (energy == 0 && !increased)
    {
        if (nectar > 30)
        {
            energy = nectar - 30;
            nectar -= energy;
        }
        else
        {
            Console.WriteLine("This is the end! Beesy ran out of energy.");
            break;
        }
    }
    if (energy == 0 && increased)
    {
        Console.WriteLine("This is the end! Beesy ran out of energy.");
        break;
    }
    if (command == "up")
    {
        arr[bee[0], bee[1]] = '-';
        if (bee[0] == 0) bee[0] = n - 1;
        else bee[0] = bee[0] - 1;
    }
    else if(command == "down")
    {
        arr[bee[0], bee[1]] = '-';
        if (bee[0] == n - 1) bee[0] = 0;
        else bee[0] = bee[0] + 1;
    }
    else if(command == "right")
    {
        arr[bee[0], bee[1]] = '-';
        if (bee[1] == n - 1) bee[1] = 0;
        else bee[1] = bee[1] + 1;
    }
    else
    {
        arr[bee[0], bee[1]] = '-';
        if (bee[1] == 0) bee[1] = n - 1;
        else bee[1] = bee[1] - 1;
    }

    char pos = arr[bee[0], bee[1]];
    arr[bee[0], bee[1]] = 'B';
    energy--;

    if (pos == 'H')
    {
        hiveReached = true;
        if (nectar >= 30)
        {
            Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
            break;
        }
        else
        {
            Console.WriteLine("Beesy did not manage to collect enough nectar.");
            break;
        }
    }
    else if(pos != '-')
    {
        int a = int.Parse(pos.ToString());
        nectar += a;
        
    }
}
arr[bee[0], bee[1]] = 'B';
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
        Console.Write(arr[i,j]);
    Console.WriteLine();
}

