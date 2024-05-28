using System;
using System.Collections.Generic;
using System.Linq;

SortedDictionary<string, Dictionary<string, double>> pricePerShops = new();

string input = string.Empty;
while((input = Console.ReadLine()) != "Revision")
{
    string[] tokens = input.Split(", ");
    string shopName = tokens[0];
    string productName = tokens[1];
    double price = double.Parse(tokens[2]);
    if (!pricePerShops.ContainsKey(shopName))
    {
        pricePerShops[shopName] = new Dictionary<string, double>();
    }
    pricePerShops[shopName].Add(productName, price);
}
foreach(  (string shop, Dictionary<string, double> products) in pricePerShops)
{
    Console.WriteLine(shop + "->");
    foreach((string product,  double price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}