int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> packages = new(arr);
arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> couriers = new(arr);
int totalDelivered = 0;
while(couriers.Count > 0 && packages.Count > 0)
{
    int package = packages.Peek();
    int courier = couriers.Dequeue();
    if(courier >= package)
    {
        totalDelivered += package;
        if(courier - package > 0)
        {
            courier -= 2 * package;
            if(courier > 0) couriers.Enqueue(courier);
        }
        packages.Pop();
    }
    else
    {
        package -= courier;
        packages.Pop();
        totalDelivered += courier;
        packages.Push(package);
    }
}
Console.WriteLine($"Total weight: {totalDelivered} kg");
if(packages.Count == 0 && couriers.Count == 0)
    Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
else if(packages.Count > 0)
    Console.WriteLine("Unfortunately, there are no more available couriers to deliver the following packages: " + string.Join(", ", packages));
else
    Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
