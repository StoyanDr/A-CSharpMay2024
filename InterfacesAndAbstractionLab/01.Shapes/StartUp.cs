﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public class StartUp
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());
        IDrawable circle = new Circle(radius);
        
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        IDrawable rectangle = new Rectangle(width, height);

        circle.Draw();
        rectangle.Draw();
    }
}
