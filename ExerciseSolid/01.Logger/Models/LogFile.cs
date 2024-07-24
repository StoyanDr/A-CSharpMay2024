using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models;

public class LogFile
{
    private StringBuilder log = new();
    public int Size { get; private set; }
    public void Write(string log)
    {
        this.log.AppendLine(log);
        using (StreamWriter writer = new("../../../log.txt"))
        {
            writer.Write(this.log);
        }
        for (int i = 0; i < log.Length; i++)
        {
            Size += log[i];
        }
    }
}
