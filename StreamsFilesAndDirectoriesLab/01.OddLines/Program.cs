using System;
using System.IO;

using (StreamReader reader = new(@"..\..\..\Files\input.txt"))
{
    using (StreamWriter writer = new(@"..\..\..\Files\output.txt"))
    {
        string line;
        int counter = 0;
        while((line = reader.ReadLine()) != null)
        {
            if(counter % 2 != 0)
            {
                writer.WriteLine(line);
            }
            counter++;
        }
    }
}