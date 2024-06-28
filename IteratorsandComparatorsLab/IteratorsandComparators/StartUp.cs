using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsandComparators;

public class StartUp
{
    static void Main()
    {
        Book a = new("Allah", 2002);
        Book b = new("Ciganni", 1899, "Levski");
        Library l = new(a, b);
        foreach(Book book in l)
            Console.WriteLine(book.Title);
    }
}
