using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        Person p1 = new();
        Person p2 = new(21);
        Person p3 = new("Pesho", 24);
    }
}
