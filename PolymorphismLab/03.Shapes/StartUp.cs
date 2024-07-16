using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Models;

namespace Shapes;

public class StartUp
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine(rectangle.Draw());
    }
}
