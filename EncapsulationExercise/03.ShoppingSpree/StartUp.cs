using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree;

public class StartUp
{
    static void Main()
    {
        List<Person> people = new();
        List<Product> products = new();
        string line = string.Empty;
        string[] split;
        try
        {
            line = Console.ReadLine();
            split = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < split.Length; i++)
            {
                string[] data = split[i].Split('=');
                Person p = new(data[0], decimal.Parse(data[1]));
                people.Add(p);
            }
            line = Console.ReadLine();
            split = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
            
            for(int i = 0; i < split.Length; i++)
            {
                string[] data = split[i].Split('=');
                Product p = new(data[0], decimal.Parse(data[1]));
                products.Add(p);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        while ((line = Console.ReadLine()) != "END")
            {
                split = line.Split();
                int productIndex = products.IndexOf(new Product(split[1], 100));
                int personIndex = people.IndexOf(new Person(split[0], 100));
                people[personIndex].AddProduct(products[productIndex]);
            }
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
        
    }
}
