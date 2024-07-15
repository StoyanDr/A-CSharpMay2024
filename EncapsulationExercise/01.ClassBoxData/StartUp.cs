using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData;

public class StartUp
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Box b;
        try
        {
            b = new(length, width, height);
            Console.WriteLine($"Surface Area - {b.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {b.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {b.Volume():F2}");
        }catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
